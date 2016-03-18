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

            int numero = 1;
            bool bandera = true;
            int cont = 0;
                                  
            do
            {
                numero++;
                
                int suma = 0;

                for (int i = 1; i < numero; i++)
                {
                    
                    if (numero % i == 0)
                    {
                        //Console.WriteLine("{0}, es divisor ", i);
                        suma = suma + i;

                    }

                    if (suma == numero)
                    {
                        Console.WriteLine("{0}, es perfecto", numero);
                        cont++;
                        break;
                    }

                    if (cont == 4)
                    {
                        bandera = false;
                    }
  
                }   

            }while(bandera == true);

            Console.ReadLine();
        }
    }
}
