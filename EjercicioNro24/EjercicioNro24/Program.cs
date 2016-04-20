using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 24";

            int [] A = new int[10] {1,2,3,5,4,8,9,7,8,5};
            int [] B = new int[10] {5,2,3,4,8,7,8,2,7,4};
            int [] C = new int[10];

            for (int i = 0; i < A.Count(); i++ )
            {
                if (A[i] == B[i])
                {
                    C[i] = A[i];
                }
                else if (A[i] < B[i])
                {
                    C[i] = A[i];
                }
                else
                {
                    C[i] = B[i];
                }
            }

            Console.WriteLine("Vector A");
            foreach (int item in A)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Vector B");
            Console.WriteLine("-----------------");
            foreach (int item in B)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Vector C");
            Console.WriteLine("-----------------");
            foreach (int item in C)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Ordenar decendente");
            Array.Sort(C);
            Console.WriteLine("Vector C");
            Console.WriteLine("-----------------");
            foreach (int item in C)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Ordenar acendente");
            Array.Reverse(C);
            Console.WriteLine("Vector C");
            Console.WriteLine("-----------------");
            foreach (int item in C)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
