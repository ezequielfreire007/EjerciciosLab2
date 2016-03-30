using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            double respuesta  = 0;
            respuesta = lado * lado;

            return respuesta;
        }

        public static double CalcularTriangulo(double altura, double bas)
        {
            double respuesta = 0;
            respuesta = (bas * altura)/2;

            return respuesta;
        }

        public static double CalcularCirculo(double radio)
        {
            double respuesta = 0;
            respuesta = Math.PI * radio * radio;
            
            return respuesta;
        }
    }
}
