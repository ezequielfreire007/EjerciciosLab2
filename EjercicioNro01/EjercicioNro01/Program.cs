using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";
            String dato = null;
            int numero = 0;
            int[] num = new int [5];
            float promedio = 0;
            int sum = 0;
            
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                dato = Console.ReadLine();
                while (int.TryParse(dato, out numero) == false)
                {
                    Console.WriteLine("Error reingrese un numero.");
                    dato = Console.ReadLine();

                }
                num[i] = int.Parse(dato);
            }

            for (int i = 0; i < num.Length; i++)
            {
                sum = sum + num[i];
            }
            promedio = sum / num.Length;

            Console.WriteLine("Valor Maximo: {0}", num.Max());
            Console.WriteLine("Valor Minimo: {0}", num.Min());
            Console.WriteLine("Valor Promedio: {0}", promedio);
            Console.ReadLine();
            
        }
    }
}
