using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro25
{
    class Program
    {
        static void Main(string[] args)
        {

            int cont = 0;
            int cont1 = 0;
            int [] numeros = new int[20] { 1, 5, 2, 3, 4, 7, 6, 9, 10, 8,
                                          -8, -9, -5, -6, -1, -2, -3, -8, -6, -7 };
            
            int [] positivos = new int[10];
            int[] negativos = new int[10];

            //Mostrar vector inicial
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("\t Vector inicial");
            Console.WriteLine("-------------------------------------");
            foreach (int item in numeros)
            {
                Console.WriteLine("\t{0}",item);
            }
            Console.WriteLine("-------------------------------------");

            //Numeros positivos
            foreach (int numero in numeros)
            {
                if (numero > 0)
                {
                    positivos[cont] = numero;
                    cont++;
                }
                else
                {
                    negativos[cont1] = numero;
                    cont1++;
                }
            }

            //Mostrar positivos en forma decreciente
            Array.Sort(positivos);
            Console.WriteLine("Numeros positivos en forma decreciente");
            Console.WriteLine("-------------------------------------");
            foreach (int item in positivos)
            {
                Console.WriteLine("{0}", item);
            }

            Console.WriteLine("-------------------------------------");
            //Mostrar negativos en forma creciente
            Array.Sort(negativos);
            Array.Reverse(negativos);
            Console.WriteLine("Numeros negativos en forema creciente");
            Console.WriteLine("-------------------------------------");
            foreach (int item in negativos)
            {
                Console.WriteLine("{0}",item);
            }

            Console.ReadLine();
        }
    }
}
