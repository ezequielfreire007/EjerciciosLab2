using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 10";

            String dato = null;
            int numero = 0;
            

            Console.WriteLine("Ingrese un numero: ");
            dato = Console.ReadLine();

            while(int.TryParse(dato,out numero) == false)
            {
                Console.WriteLine("Debe ingresar un numero. Intentelo nuevamente");
                dato = Console.ReadLine();
            }

            for (int i = 1; i < numero; i++)
            {
                int cont = 0;
                for (int j = 1; j < numero; j++)
                {
                    if (i % j == 0)
                    {
                        cont++;
                    }
                }

                if (cont == 2)
                {
                    Console.WriteLine("{0}, es primo", i);
                }
                
            }
      
            Console.ReadLine();
        }
    }
}
