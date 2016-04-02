using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boligrafos;

namespace EjercicioNro19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 19";

            //Instancia de boligrafos
            Console.WriteLine("Se instancian los boligrafos");
            Boligrafo boligrafoAzul = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo boligrafoRojo = new Boligrafo(ConsoleColor.Red, 100);

            //Uso de boligrafos
            Console.WriteLine("Se usan los boligrafos");
            boligrafoAzul.Pintar();
            boligrafoAzul.Pintar();
            boligrafoRojo.Pintar();

            //Mostrar nivel de tinta
            Console.WriteLine("Nivel de tinta boligrafo azul: {0}", boligrafoAzul.getTinta());
            Console.WriteLine("Nivel de tinta boligrafo rojo: {0}", boligrafoRojo.getTinta());

            //Carga de boligrafo azul
            Console.WriteLine("Se carga el boligrafo azul desde le metodo recargar");
            boligrafoAzul.Recargar();

            //Muestra nivel de tinta de boligrafo azul
            Console.WriteLine("Nivel de tinta boligrafo azul: {0}", boligrafoAzul.getTinta());

            Console.WriteLine("Recargar boligrafo rojo");
            boligrafoRojo.setTinta(150);
            if(boligrafoRojo.getTinta() == -1)
            {
                Console.WriteLine("Se desbordo la tinta");
            }

            //Cargo nuevamente el boligrafo rojo
            Console.WriteLine("Cargo nuevamente el boligrafo rojo");
            boligrafoRojo.setTinta(100);
            Console.WriteLine("Nivel de tinta boligrafo rojo: {0}", boligrafoRojo.getTinta());

            Console.ReadLine();

        }
    }
}
