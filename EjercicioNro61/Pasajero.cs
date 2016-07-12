using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace EjercicioNro61
{
    [XmlInclude(typeof(Pasajero))]
    public class Pasajero
    {
        #region Atributos
        public string nombre;
        public string apellido;
        public Rangos rango;
        #endregion

        #region Constructor
        public Pasajero()
        { }

        public Pasajero(string nombre, string apellido, Rangos rango)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.rango = rango;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----- Pasajero ------");
            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Apellido: " + this.apellido);
            sb.AppendLine("Rango: " + this.rango);

            return sb.ToString();
        }
        #endregion
    }
}
