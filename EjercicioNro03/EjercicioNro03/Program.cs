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
            int [] primo;
            

            Console.WriteLine("Ingrese un numero: ");
            dato = Console.ReadLine();

            while(int.TryParse(dato,out numero) == false)
            {
                Console.WriteLine("Debe ingresar un numero. Intentelo nuevamente");
                dato = Console.ReadLine();
            }

            for (int j = numero; numero <= 2; j--)
            {
                int numeroPrimo = numero;
                int cont = 0;
                int cont2 = 0;
                while (cont == 0)
                {
                    for (int j = numeroPrimo - 1; numeroPrimo <= 2; j--)
                    {
                        if (numero % numeroPrimo == 0)
                        {
                            cont++;
                        } 
                    }
                    
                    primo[cont2] = numero;
                    cont2++;
                }
            }

            Console.WriteLine("Numeros primos");
            for(int i = 0; i < primo.Length; i++)
            {

            }

        }
    }
}
