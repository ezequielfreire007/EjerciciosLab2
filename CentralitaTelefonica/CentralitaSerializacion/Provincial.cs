using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CentralitaSerializacion
{
    [XmlInclude(typeof(Provincial))]
    public class Provincial : Llamada
    {
        #region Atributos
        protected Franja _franjaHoraria;
        #endregion

        #region Propiedades
        public override  float CostosLlamada
        {
            get { return this.CalcularCosto(); }
        }
        #endregion

        #region Constructores

        public Provincial()
        { }

        public Provincial(Franja miFranja, Llamada unaLlamada):base(unaLlamada.NroOrigen,unaLlamada.NroDestino,unaLlamada.Duracion)
        {
            this._franjaHoraria = miFranja;
        }

        public Provincial(String origen, Franja miFranja, float duracion, String destino)
            : base(origen, destino, duracion)
        { }
        #endregion

        #region Metodos
        private float CalcularCosto()
        {
            float retorno=0;
            if (this._franjaHoraria == Franja.Franja_1)
            {
                retorno = 0.99f * this.Duracion;
            }
            if (this._franjaHoraria == Franja.Franja_2)
            {
                retorno = 1.25f * this.Duracion;
            }
            if (this._franjaHoraria == Franja.Franja_3)
            {
                retorno = 0.66f * this.Duracion;
            }
            return retorno;
        }

        protected string Mostrar()
        {     
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine("Franja Horaria: " + this._franjaHoraria);
            sb.AppendLine("Consto de llamada: " + this.CostosLlamada);
            return sb.ToString();
        }
        #endregion

        #region Sobrecarga Equal y ToString
        public override bool Equals(object obj)
        {
            bool retorno = true;
            if(obj == null || GetType() != obj.GetType())
            {
                retorno = false;
            }

            return retorno;
        }

        public override string ToString()
        {
            return Mostrar();
        }
        #endregion

    }
}
