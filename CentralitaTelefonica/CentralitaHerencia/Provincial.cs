using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Provincial : Llamada
    {
        #region Atributos
        protected Franja _franjaHoraria;
        #endregion

        #region Propiedades
        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }
        #endregion

        #region Constructores
        public Provincial(Franja miFranja, Llamada unaLlamada):base(unaLlamada.NroOrigen,unaLlamada.NroDestino,unaLlamada.Duracion)
        {
            this._franjaHoraria = miFranja;
        }

        public Provincial(String origen, Franja miFranja, float duracion, String destino):this(miFranja,new Llamada(origen,destino,duracion))
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

        public void Mostrar()
        {
            base.Mostrar();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Franja Horaria: " + this._franjaHoraria);
            sb.AppendLine("Consto de llamada: " + this.CostoLlamada);
            Console.WriteLine(sb.ToString());
        }
        #endregion

   
    }
}
