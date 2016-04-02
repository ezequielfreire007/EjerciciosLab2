using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 15";

            Calculadora.Mostrar(Calculadora.Calcular(2, 5, "+"));
            Calculadora.Mostrar(Calculadora.Calcular(9,6,"-"));
            Calculadora.Mostrar(Calculadora.Calcular(2,3,"*"));
            Calculadora.Mostrar(Calculadora.Calcular(5, 2, "/"));
            Calculadora.Mostrar(Calculadora.Calcular(5, 0, "/"));

            Console.ReadLine();
        }
    }
}
