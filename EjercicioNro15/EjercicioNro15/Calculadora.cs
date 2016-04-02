using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro15
{
    class Calculadora
    {
        public static double Calcular(double numero1, double numero2, String operacion)
        {
            double resultado = 0;

            switch (operacion)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    resultado = numero1 / numero2;
                    if (Validar(numero2))
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        Console.WriteLine("El divisor debe ser distinto de cero");
                    }
                    break;
                default:
                    break;
            }

            return resultado;
        }

        private static bool Validar(double numero)
        {
            bool respuesta = false;

            if (numero != 0 )
            {
                respuesta = true;
            }

            return respuesta;
        }

        public static void Mostrar(double mostrar)
        {
            Console.WriteLine("Operacion: {0}",mostrar);
        }
    }
}
