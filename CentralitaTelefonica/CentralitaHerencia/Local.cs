using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Local : Llamada
    {
        #region Atributos
        protected float _costo;
        #endregion

        #region Propiedades
        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }
        #endregion

        #region Constructor
        public Local(Llamada unaLlamada, float costo):base(unaLlamada.NroOrigen,unaLlamada.NroDestino,unaLlamada.Duracion)
        {
            this._costo = costo;
        }

        public Local(String origen, float duracion, String destino, float costo):this(new Llamada(origen,destino,duracion),costo)
        { }

        #endregion

        #region Metodos
        private float CalcularCosto()
        {
            return this.Duracion * this._costo;
        }

        public void Mostrar()
        {
            base.Mostrar();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Costo de la llamada: " + this.CostoLlamada);
        }
        #endregion

    }
}
