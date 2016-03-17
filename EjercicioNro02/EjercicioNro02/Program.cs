using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 02"; 

            String dato = null;
            int numero = 0;
            double cuadrado = 0;
            double cubo = 0;

            Console.WriteLine("Ingrese un numero: ");
            dato = Console.ReadLine();

            while(int.TryParse(dato, out numero) == false && numero > 0)
            {
                Console.WriteLine("Error. Reingrese numero!!!");
                dato = Console.ReadLine();
            }

            cuadrado = Math.Pow(numero,2);
            cubo = Math.Pow(numero,3);

            Console.WriteLine("El cuadrado de {0} es {1}", numero, cuadrado);
            Console.WriteLine("El cubo de {0} es {1}", numero, cubo);

        }
    }
}
