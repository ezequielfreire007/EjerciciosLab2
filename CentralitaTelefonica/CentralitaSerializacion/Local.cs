using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CentralitaSerializacion
{
    [XmlInclude(typeof(Local))]
    public class Local : Llamada
    {
        #region Atributos
        protected float _costo;
        #endregion

        #region Propiedades
        public override float CostosLlamada
        {
            get { return this.CalcularCosto(); }
        }
        #endregion

        #region Constructor

        public Local()
        {
        }

        public Local(Llamada unaLlamada, float costo):base(unaLlamada.NroOrigen,unaLlamada.NroDestino,unaLlamada.Duracion)
        {
            this._costo = costo;
        }

        public Local(String origen, float duracion, String destino, float costo):base(origen,destino,duracion)
        {
            this._costo = costo;
        }

        #endregion

        #region Metodos
        private float CalcularCosto()
        {
            return this.Duracion * this._costo;
        }

        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine("Costo de la llamada: " + this.CostosLlamada);
            return sb.ToString();
        }
        #endregion


        #region Sobrecarga Equal y ToString
        public override bool Equals(object obj)
        {
            bool retorno = true;
            if (obj == null || GetType() != obj.GetType())
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
