using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 04";

            String dato = null;
            int numero = 0;
            bool bandera = true;
            int [] numDivisor;
            int cont = 0;

            Console.WriteLine("Ingrese un numero: ");
            dato = Console.ReadLine();

            while(int.TryParse(dato, out numero) == false)
            {
                Console.WriteLine();
            }

            do
            {


            }while(bandera == true);

        }
    }
}
