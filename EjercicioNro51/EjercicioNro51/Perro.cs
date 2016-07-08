using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro51
{
    public sealed class Perro : Mascota
    {
        #region Atributos
        public bool ladra;
        #endregion

        #region Propiedades

        #endregion

        #region Constructor
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

        public override void mostrar()
        {
            Console.WriteLine("----- Perro ------");
            Console.WriteLine("Nombre: {0}", base._nombre);
            Console.WriteLine("Edad: {0}", base._edad);
            Console.WriteLine("Raza: {0}", base._raza);
        }
        #endregion

        
    }
}
