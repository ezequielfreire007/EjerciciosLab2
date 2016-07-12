using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace EjercicioNro61
{
    [XmlInclude(typeof(Tren))]
    [XmlInclude(typeof(TrenBala))]
    [XmlInclude(typeof(TrenElectrico))]

    public abstract class Tren
    {
        #region Atributos
        protected int _cantMaxPasajeros;
        protected bool _motorEncendido;
        protected string _destino;
        #endregion

        #region Propiedades
        public abstract List<Pasajero> Pasajeros
        {
            get;
        }
        #endregion

        #region Constructores
        public Tren()
        { }

        public Tren(string destino, int cantmax)
        {
            this._destino = destino;
            this._cantMaxPasajeros = cantmax;
            this.EncenderMotor();
        }
        #endregion

        #region Metodos
        public abstract void Ingresar(Pasajero pasajero);

        public virtual string IndicarDestino()
        {
            return this._destino;
        }

        public bool EncenderMotor()
        {
            if (this._motorEncendido)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Destino: " + this._destino);
            if (this._motorEncendido)
            {
                sb.AppendLine("Estado de motor: Encendido");
            }
            else
            {
                sb.AppendLine("Estado de motor: Apagado");
            }
            sb.AppendLine("Cantidad maxima de pasajeros: " + this._cantMaxPasajeros);

            return sb.ToString();
        }
        #endregion
    }
}
