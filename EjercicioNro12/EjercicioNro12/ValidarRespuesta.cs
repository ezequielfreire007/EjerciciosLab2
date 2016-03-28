using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro12
{
    class ValidarRespuesta
    {
        public static bool ValidaS_N()
        {
            bool retorno = false;
            bool seguir = true;
            String continua = "";
            String mayuscula = "";

            Console.WriteLine("¿Continua? S/N:");
            continua = Console.ReadLine();
            mayuscula = continua.ToUpper();

            while (seguir)
            {
                if (mayuscula.Equals("S"))
                {
                    retorno = true;
                    seguir = false;
                }
                else if (mayuscula.Equals("N"))
                {
                    retorno = false;
                    seguir = false;
                }
                else
                {
                    Console.WriteLine("Ingrese S o N");
                    continua = Console.ReadLine();
                    mayuscula = continua.ToUpper();
                }
                
            }
            
            
            

            return retorno;
        }
    }
}
