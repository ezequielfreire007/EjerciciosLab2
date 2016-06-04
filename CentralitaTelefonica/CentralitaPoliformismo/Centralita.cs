using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPoliformismo
{
    class Centralita
    {
        #region Atributos
        private List<Llamada> _listaDeLlamada;
        protected String _razonSocial;
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
                if (item == llamada)
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

    }
}
