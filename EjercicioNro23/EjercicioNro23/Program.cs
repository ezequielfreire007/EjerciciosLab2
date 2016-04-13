using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro23
{
    class Program
    {
        static void Main(string[] args)
        {

           // //Instanciamos los objetos
           //NumeroDecimal objDecimal = new NumeroDecimal(9);
           //NumeroBinario objBinario = new NumeroBinario("1001");

           // //Operamos con los numeros +
           // String nBinario = objBinario + objDecimal; 
           // Double nDecimal = objDecimal + objBinario; 
            
           // //Mostramos los valores
           // Console.WriteLine("suma binario: {0}", nBinario);
           // Console.WriteLine("suma decimal: {0}", nDecimal);
            
           // //Operamos con los numeros -
           // nBinario = objBinario - objDecimal; 
           // nDecimal = objDecimal - objBinario;

           // //Mostramos los valores
           // Console.WriteLine("resta binaria: {0}", nBinario);
           // Console.WriteLine("resta decimal: {0}", nDecimal);

            //Conversiones inplicitas
            NumeroBinario objBinario = "1001"; 
            NumeroDecimal objDecimal = 9;

            Console.WriteLine("El valor en Binario es {0}", (String)objBinario);
            Console.WriteLine("El valor en Decimal es {0}", (double)objDecimal);

            Console.ReadLine();
        }
    }
}
