using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 12";

            String dato = "";
            int num = 0;
            int suma = 0;
            bool seguir = true;
                        
            while (seguir)
            {
                Console.WriteLine("Ingrese un numero: ");
                dato = Console.ReadLine();

                while (int.TryParse(dato, out num) == false)
                {
                    Console.WriteLine("El dato debe de ser numerico.Intentelo nuevamente.");
                    dato = Console.ReadLine();
                }
                suma += num;
                seguir = ValidarRespuesta.ValidaS_N();
            }

            Console.WriteLine("Suma: {0}", suma);
            Console.ReadLine();
        }
    }
}
