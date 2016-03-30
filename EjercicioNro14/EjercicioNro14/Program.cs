using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 14";

            double lado = 0;
            double bas = 0;
            double altura = 0;
            double radio = 0;


            Console.WriteLine("***** Calculo de areas *******");
            Console.WriteLine();
            Console.WriteLine("Calculo de area de un cuadrado");
            Console.WriteLine("Ingrese el lado del cuadrado: ");
            lado = double.Parse(Console.ReadLine());
            Console.WriteLine("El area del cuadrado es: {0}",CalculoDeArea.CalcularCuadrado(lado));
            Console.WriteLine();

            Console.WriteLine("Calculo de area de un triangulo");
            Console.WriteLine("Ingrese base: ");
            bas = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura: ");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("El area del triangulo es: {0}", CalculoDeArea.CalcularTriangulo(altura,bas));
            Console.WriteLine();

            Console.WriteLine("Calculo de area de un circulo");
            Console.WriteLine("Ingrese el radio: ");
            radio = double.Parse(Console.ReadLine());
            Console.WriteLine("El area del circulo es: {0}", CalculoDeArea.CalcularCirculo(radio));

            Console.ReadLine();
        }
    }
}
