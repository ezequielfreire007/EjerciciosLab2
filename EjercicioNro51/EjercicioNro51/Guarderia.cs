using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace EjercicioNro51
{
    public class Guarderia : ICargar,IGuardar
    {
        #region Atributos
        private List<Mascota> _listaMascota;
        private float _precioGato;
        private float _precioPerro;
        #endregion

        #region Propiedades
        public float PrecioPorGato
        {
            get { return this._precioGato; }
        }

        public float PrecioPorPerro
        {
            get { return this._precioPerro; }
        }
        #endregion

        #region Constructor
        public Guarderia(float precioGato, float precioPerro)
        {
            this._precioGato = precioGato;
            this._precioPerro = precioPerro;
            this._listaMascota = new List<Mascota>();
        }
        #endregion

        #region Metodos
        public static Guarderia operator +(Guarderia guarderia, Mascota mascota)
        {
            if (mascota is Perro)
            {
                guarderia._listaMascota.Add((Perro)mascota);
            }
            else
            {
                guarderia._listaMascota.Add((Gato)mascota);
            }

            return guarderia;
        }

        public float mostrarTotalFacturado()
        {
            float retorno = 0;

            foreach (Mascota item in this._listaMascota)
            {
                if (item is Perro)
                {
                    retorno += this._precioPerro;
                }
                else
                {
                    retorno += this._precioGato;
                }
            }

            return retorno;
        }

        public float mostrarTotalFacturado(EMascota mascota)
        {
            float retorno = 0;

            foreach (Mascota item in this._listaMascota)
            {
                if (EMascota.Perro == mascota)
                {
                    retorno += this._precioPerro;
                }
                else
                {
                    retorno += this._precioGato;
                }  
            }

            return retorno;
        }

        public void ingresarMascota(Mascota mascota)
        {
            this._listaMascota.Add(mascota);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            foreach (Mascota item in this._listaMascota)
            {
                if (item is Perro)
                {
                    sb.AppendLine(((Perro)item).mostrar());
                }
                else
                {
                    sb.AppendLine(((Gato)item).mostrar());
                }
            }

            return sb.ToString();
        }
        #endregion

        public bool ImprimirDatosListaMascota()
        {
            try
            {
                using (StreamWriter archivo = new StreamWriter("Lista.txt", false))
                {
                    archivo.Write(this.ToString());
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
                
            }
            
        }

        public bool SerializarListaMascota()
        {
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("Lista.Xml",Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Mascota>));
                    ser.Serialize(escritor, this._listaMascota);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool DeserealizarListaMascota()
        {
            try
            {
                List<Mascota> aux;

                using (XmlTextReader lector = new XmlTextReader("Lista.Xml"))
                {
                    XmlSerializer des = new XmlSerializer(typeof(List<Mascota>));
                    aux = (List<Mascota>)des.Deserialize(lector);
                    foreach (Mascota item in aux)
                    {
                        if (item is Perro)
                        {
                            Console.WriteLine(((Perro)item).mostrar());
                        }
                        else
                        {
                            Console.WriteLine(((Gato)item).mostrar());
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool TraerDatosMascota()
        {
            try
            {
                
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
