using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CentralitaSerializacion
{
    [XmlInclude(typeof(Centralita))]
    public class Centralita : ISerializable
    {
        #region Atributos
        private List<Llamada> _listaDeLlamada;
        protected String _razonSocial;
        private String _ruta;
        #endregion

        #region Propiedades
        public float GananciaPorLocal
        {
            get { return this.CalcularGanancia(TipoLlamada.Local); }
        }

        public float GananciaPorProvincial
        {
            get { return this.CalcularGanancia(TipoLlamada.Provincial);}
        }

        public float GananciaTotal
        {
            get { return this.CalcularGanancia(TipoLlamada.Todas);}
        }

        public List<Llamada> Lista
        {

            get { return this._listaDeLlamada; }
        
        }

        public string RutaDeArchivo
        {
            get
            {
                return this._ruta;
            }
            set
            {
                this._ruta = value;
            }
        }
        #endregion

        #region Constructores

        public Centralita()
        {
            this._listaDeLlamada = new List<Llamada>(1);
        }

        public Centralita(String nombreEmpresa):this()
        {
            this._razonSocial = nombreEmpresa;
        }
        #endregion

        #region Metodos

        private void AgregarLlamada(Llamada nuevaLllamada)
        {
            this._listaDeLlamada.Add(nuevaLllamada);
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {

            float retorno = 0;

            if (tipo == TipoLlamada.Todas)
            {
                for (int i = 0; i < this._listaDeLlamada.Count; i++)
                {
                    if (this._listaDeLlamada[i] is Local)
                    {
                        retorno += ((Local)this._listaDeLlamada[i]).CostosLlamada;
                    }
                    else
                    {
                        retorno += ((Provincial)this._listaDeLlamada[i]).CostosLlamada;
                    }
                }
            }
            else
            {
                for (int i = 0; i < this._listaDeLlamada.Count; i++)
                {
                    if ((this._listaDeLlamada[i] is Local) && (tipo == TipoLlamada.Local))
                    {
                        retorno += ((Local)this._listaDeLlamada[i]).CostosLlamada;
                    }
                    if ((this._listaDeLlamada[i] is Provincial) && (tipo == TipoLlamada.Provincial))
                    {
                        retorno += ((Provincial)this._listaDeLlamada[i]).CostosLlamada;
                    }
                }
 
            }
            
            return retorno;
        }



        public void OrdenarLlamadas()
        {
            this._listaDeLlamada.Sort(Llamada.OrdenarPorDuracion);
        }

        #endregion

        #region Sobrecarga de ToString

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Razon social: " + this._razonSocial);
            sb.AppendLine("Ganancia total: " + this.GananciaTotal);
            sb.AppendLine("Ganancia por llamadas locales: " + this.GananciaPorLocal);
            sb.AppendLine("Ganancia por llamadas Provinciales: " + this.GananciaPorProvincial);

            sb.AppendLine("------------ Detalle de llamadas -------------");
           
            for (int i = 0; i < this._listaDeLlamada.Count; i++)
            {
                if (this._listaDeLlamada[i] is Local)
                {
                    sb.Append(((Local)this._listaDeLlamada[i]).ToString());
                }
                else
                {
                    sb.Append(((Provincial)this._listaDeLlamada[i]).ToString());
                }
            }

            return sb.ToString();
        }

        #endregion

        #region Operadores Sobrecargados

        public static bool operator ==(Centralita centralita, Llamada llamada)
        {
            bool retorno = false;

            foreach (Llamada item in centralita._listaDeLlamada)
	        {
                if (item.Equals(llamada))
                {
                    retorno = true;
                    break;
                }
	        }

      
            return retorno;
        }

        public static bool operator !=(Centralita centralita, Llamada llamada)
        {
            return !(centralita == llamada);
        }

        public static Centralita operator +(Centralita centralita, Llamada llamada)
        {
            if (centralita != llamada)
            {
                centralita.AgregarLlamada(llamada); 
            }
            else
            {
                Console.WriteLine("La llamada ya se encuentra en la centralita.");
                
            }

            return centralita;
        }

        #endregion

        #region Metodos Deserealizar y Serializar

        public bool Deserealizarse()
        {
            
            Centralita aux;
            try
            {
                using (XmlTextReader lector = new XmlTextReader(this.RutaDeArchivo ))
                {
                    XmlSerializer serilizar = new XmlSerializer(typeof(Centralita));
                    aux = (Centralita)serilizar.Deserialize(lector);
                    Console.WriteLine("-------- Objeto Deserializado ------------");
                    aux.ToString();
                    return true;
                }
            }
            catch (Exception ex)
            {
                CentralitaExeption miExcepcion = new CentralitaExeption("Error al intentar Deserializar", this.GetType().ToString(), "Deserializar",ex);
                Console.WriteLine("Mensaje: {0}", miExcepcion.Message);
                Console.WriteLine("Clase: {0}", miExcepcion.NombreClase);
                Console.WriteLine("Metodo: {0}", miExcepcion.NombreMetodo);
                Console.WriteLine("Mensaje de la Excepcion: {0}", ex.Message);
                return false;
            }


        }

        public bool Serializarse()
        {
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter(this.RutaDeArchivo ,Encoding.UTF8))
                {
                    XmlSerializer serializar = new XmlSerializer(typeof(Centralita));
                    serializar.Serialize(escritor, this);
                    Console.WriteLine("Objeto Serializado de forma exitosa.");
                    return true;
                }
            }
            catch (Exception ex)
            {
                CentralitaExeption miExcepcion = new CentralitaExeption("Error al intentar serializar", this.GetType().ToString(), "Serialize",ex);
                Console.WriteLine("Mensaje: {0}",miExcepcion.Message);
                Console.WriteLine("Clase: {0}", miExcepcion.NombreClase);
                Console.WriteLine("Metodo: {0}", miExcepcion.NombreMetodo);
                Console.WriteLine("Mensaje de la Excepcion: {0}", ex.Message);
                return false;
            }
        }

        public bool GuardarEnArchivo(Llamada unaLlamada, bool agrego)
        {
            
            try
            {
                using (StreamWriter archivo = new StreamWriter(this.RutaDeArchivo, agrego))
                {

                    archivo.WriteLine("Fecha y hora: {0}", DateTime.Now);
                    archivo.WriteLine("-------------------------------");
                    archivo.WriteLine(unaLlamada.ToString());
                    return true;
                }
            }
            catch (Exception ex)
            {
                CentralitaExeption miExcepcion = new CentralitaExeption("Problema al guardar archivo", this.GetType().ToString(), "GuardarEnArchivo");
                Console.WriteLine("Mensaje: {0}", miExcepcion.Message);
                Console.WriteLine("Clase: {0}", miExcepcion.NombreClase);
                Console.WriteLine("Metodo: {0}", miExcepcion.NombreMetodo);
                Console.WriteLine("Mensaje de la Excepcion: {0}", ex.Message);
                return false;    
            }
           
        }
        #endregion
 
    }
}
