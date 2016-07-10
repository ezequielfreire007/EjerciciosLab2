using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace EjercicioNro51
{
    [XmlInclude(typeof(Perro))]
    public sealed class Perro : Mascota
    {
        #region Atributos
        public bool ladra;
        #endregion

        #region Propiedades

        #endregion

        #region Constructor
        public Perro()
        { }

        public Perro(string nombrePerro, ERaza razaPerro):base(nombrePerro,razaPerro)
        { }

        public Perro(string nombrePerro, int edadPerro, ERaza razaPerro):base(nombrePerro,edadPerro,razaPerro)
        { }
        #endregion

        #region Metodos
        public static ERaza retornarRaza(Perro perrito)
        {
            return perrito._raza;
        }

        public override string mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----- Perro ------");
            sb.AppendLine("Nombre: " + base._nombre);
            sb.AppendLine("Edad: " + base._edad);
            sb.AppendLine("Raza: " + base._raza);

            return sb.ToString();
        }
        #endregion

        
    }
}
