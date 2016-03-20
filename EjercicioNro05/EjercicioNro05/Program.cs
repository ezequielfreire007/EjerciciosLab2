using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 05";

            String dato = null;
            int numero;
            int numeroIncremental = 1;
            int sumaIzquierda;
            int sumaDerecha;
           

            //Ingreso del dato
            Console.WriteLine("Ingrese un numero entero.");
            dato = Console.ReadLine();

            while(int.TryParse(dato, out numero) == false)
            {
                Console.WriteLine("El valor debe ser numero. Intentelo nuevamente.");
                dato = Console.ReadLine();
            }


            do
            {
                numeroIncremental++;
                sumaIzquierda = 0;
                sumaDerecha = 0;

                //Suma de izquierda
                for (int i = 1; i < numeroIncremental; i++ )
                {
                    sumaIzquierda += i;
                }

                //Suma derecha
                for (int j = numeroIncremental + 1; j <= sumaIzquierda; j++ )
                {
                    if ((sumaIzquierda == sumaDerecha) || (sumaDerecha > sumaIzquierda))
                    {
                        break;
                    }
                    sumaDerecha += j;
                }

                if (sumaIzquierda == sumaDerecha)
                {
                    Console.WriteLine("El numero {0} es centro numerico.", numeroIncremental);
                }
            
            }while(numeroIncremental < numero);

            Console.ReadLine();

        }
    }
}
