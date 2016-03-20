using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 06";

            String dato = null;
            int numero;

            Console.WriteLine("Ingrese un anio: ");
            dato = Console.ReadLine();

            while(int.TryParse(dato, out numero) == false)
            {
                Console.WriteLine("Debe ingresar un dato numerico. Intente nuevamente.");
                dato = Console.ReadLine();
            }

            if ((numero % 4 == 0) && (numero % 100 != 0) || (numero % 400 == 0))
            {
                Console.WriteLine("El anio {0} es bisiesto.",numero);
            }
            else 
            {
                Console.WriteLine("El anio {0} no es bisiesto.", numero);
            }

            Console.ReadLine();
        }
    }
}
