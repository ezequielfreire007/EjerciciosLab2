using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro51
{
    public class Gato : Mascota
    {
        #region Atributos
        public bool maulla;
        #endregion

        #region Propiedades
        #endregion

        #region Constructor
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
        public override void mostrar()
        {
            Console.WriteLine("----- Gato ------");
            Console.WriteLine("Nombre: {0}", base._nombre);
            Console.WriteLine("Edad: {0}", base._edad);
            Console.WriteLine("Raza: {0}", base._raza);
        }
        #endregion

    }
}
