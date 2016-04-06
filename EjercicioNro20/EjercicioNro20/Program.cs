using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geormetria;

namespace PruebaGeometrica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 20";

            Punto vertice1 = new Punto(5,4);
            Punto vertice3 = new Punto(2,8);

            Rectangulo miRectangulo = new Rectangulo(vertice1,vertice3);
            Program.Mostrar(miRectangulo);
            Console.ReadLine();
            
        }

        public static void Mostrar(Rectangulo miRectangulo)
        {
            Console.WriteLine("Vertice 1: ({0},{1})", miRectangulo.vertice1.getX(),miRectangulo.vertice1.getY());
            Console.WriteLine("Vertice 2: ({0},{1})", miRectangulo.vertice2.getX(),miRectangulo.vertice2.getY());
            Console.WriteLine("Vertice 3: ({0},{1})", miRectangulo.vertice3.getX(),miRectangulo.vertice3.getY());
            Console.WriteLine("Vertice 4: ({0},{1})", miRectangulo.vertice4.getX(),miRectangulo.vertice4.getY());
            Console.WriteLine("Superficie: {0}", miRectangulo.superficie);
            Console.WriteLine("Perimetro: {0}",miRectangulo.perimetro);
        }
    }
}
