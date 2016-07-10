using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace EjercicioNro51
{
    [XmlInclude(typeof(Gato))]
    public class Gato : Mascota
    {
        #region Atributos
        public bool maulla;
        #endregion

        #region Propiedades
        #endregion

        #region Constructor
        public Gato()
        { }

        public Gato(string nombreGato, ERaza razaGato):base(nombreGato,razaGato)
        { }

        public Gato(string nombreGato, int edadGato, ERaza razaGato)
            : base(nombreGato, edadGato, razaGato)
        { }
        #endregion

        #region Metodos
        public static ERaza retornarRaza(Gato gatito)
        {
            return gatito._raza;
        }
        public override string mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----- Gato ------");
            sb.AppendLine("Nombre: " + base._nombre);
            sb.AppendLine("Edad: " + base._edad);
            sb.AppendLine("Raza: " + base._raza);

            return sb.ToString();
        }
        #endregion

    }
}
