using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marca;
using Procesador;
using LaComputadora;

namespace EjercicioNro18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 18";

            Computadora miComputadora = new Computadora(false, EMarca.Apple, 2, EProcesador.Inter_Core_i7);
            
            Console.ReadLine();
        }
    }
}
