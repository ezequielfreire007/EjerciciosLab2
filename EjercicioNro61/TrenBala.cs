using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace EjercicioNro61
{
    [XmlInclude(typeof(TrenBala))]
    public class TrenBala : Tren, IservicioComedor
    {
        #region Atributo
        private List<Pasajero> _pasajeros;
        #endregion

        #region Propiedades
        public override List<Pasajero> Pasajeros
        {
            get { return this._pasajeros; }
        }
        #endregion

        #region Constructor
        public TrenBala()
        {
            this._pasajeros = new List<Pasajero>(1);
        }

        public TrenBala(string destino, int cantMax):base(destino,cantMax)
        {
            this._pasajeros = new List<Pasajero>(1);
        }
        #endregion

        #region Metodo
        public override void Ingresar(Pasajero pasajero)
        {
            if (this._pasajeros.Count < this._cantMaxPasajeros)
            {
                this._pasajeros.Add(pasajero);
            }
            else
            {
                throw new PasajerosOverFlowException("No se puede ingresar otro pasajero");
            }
        }

        public void ServirComida(string comida)
        {
            Console.WriteLine("Comida servida: {0}",comida);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());

            foreach (Pasajero item in this._pasajeros)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
        #endregion

    }
}
