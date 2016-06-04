using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
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
            this._listaDeLlamada = new List<Llamada>();
        }

        public Centralita(String nombreEmpresa):this()
        {
            this._razonSocial = nombreEmpresa;
        }
        #endregion

        #region Metodos
        private float CalcularGanancia(TipoLlamada tipo)
        {

            float retorno = 0;

            if (tipo == TipoLlamada.Todas)
            {
                for (int i = 0; i < this._listaDeLlamada.Count; i++)
                {
                    if (this._listaDeLlamada[i] is Local)
                    {
                        retorno += ((Local)this._listaDeLlamada[i]).CostoLlamada;
                    }
                    else
                    {
                        retorno += ((Provincial)this._listaDeLlamada[i]).CostoLlamada;
                    }
                }
            }
            else
            {
                for (int i = 0; i < this._listaDeLlamada.Count; i++)
                {
                    if ((this._listaDeLlamada[i] is Local) && (tipo == TipoLlamada.Local))
                    {
                        retorno += ((Local)this._listaDeLlamada[i]).CostoLlamada;
                    }
                    if ((this._listaDeLlamada[i] is Provincial) && (tipo == TipoLlamada.Provincial))
                    {
                        retorno += ((Provincial)this._listaDeLlamada[i]).CostoLlamada;
                    }
                }
 
            }
            
            return retorno;
        }

        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Razon social: " + this._razonSocial);
            sb.AppendLine("Ganancia total: " + this.GananciaTotal);
            sb.AppendLine("Ganancia por llamadas locales: " + this.GananciaPorLocal);
            sb.AppendLine("Ganancia por llamadas Provinciales: " + this.GananciaPorProvincial);

            sb.AppendLine("------------ Detalle de llamadas -------------");
            Console.WriteLine(sb.ToString());
            for (int i = 0; i < this._listaDeLlamada.Count; i++)
            {
                if (this._listaDeLlamada[i] is Local)
                {
                    ((Local)this._listaDeLlamada[i]).Mostrar();
                }
                else
                {
                    ((Provincial)this._listaDeLlamada[i]).Mostrar();
                }
            }
        }

        public void OrdenarLlamadas()
        {
            this._listaDeLlamada.Sort(Llamada.OrdenarPorDuracion);
        }

        #endregion

    }
}
