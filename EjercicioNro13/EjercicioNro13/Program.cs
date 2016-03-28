using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro13
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Ejercicio Nro 03";
            Console.WriteLine("Numero decimal a binario: {0}",Conversor.DecimalBinario(14));
            Console.WriteLine("Numero binario a decimal: {0}",Conversor.BinarioDecimal("1110"));

            Console.ReadLine();
        }
    }
}
