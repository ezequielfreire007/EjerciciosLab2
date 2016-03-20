using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 09";

            String dato = null;
            int numero = 0;
            String caracter = null;

            Console.WriteLine("Ingrese la altura: ");
            dato = Console.ReadLine();

            while(int.TryParse(dato, out numero) == false)
            {
                Console.WriteLine("Debe ingresar un dato numerico. Instentelo nuevamente.");
                dato = Console.ReadLine();
            }

            Console.WriteLine();
            for (int i = 0; i < numero; i++ )
            {
                caracter += "*";
                Console.WriteLine("{0}", caracter);
            }

            Console.ReadLine();
        }
    }
}
