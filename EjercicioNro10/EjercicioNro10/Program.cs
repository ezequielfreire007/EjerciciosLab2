using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 10";

            //variables
            String dato = null;
            int numero = 0;
            Console.WriteLine("Ingrese la altura: ");
            dato = Console.ReadLine();
            String caracter = null;
            String posicion = null; 
            String caracterResul = null;
            int cont = 0;
            int numeroPorDos = 0;

            //validacion de dato
            while(int.TryParse(dato, out numero) == false)
            {
                Console.WriteLine("Debe ingresar un dato numerico positivo.");
                dato = Console.ReadLine();
            }


            Console.WriteLine();
            cont = numero ;
            numeroPorDos = numero + numero;
            for (int i = 0; i < numeroPorDos; i++ )
            {
                posicion = null;
                //espacios
                for (int k = cont; k > 0; k-- )
                {
                    posicion += " ";
                    
                }
                
                caracter += "*";
                //asteriscos
                caracterResul = posicion + caracter;
                if (caracter.Length % 2 != 0)
                {
                    Console.WriteLine("{0}", caracterResul);      
                }
                else
                {
                    cont--;
                }
                
            }

            Console.ReadLine();

        }
    }
}
