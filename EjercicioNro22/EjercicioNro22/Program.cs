using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 22";

            //Fahrenheit
            Fahrenheit unFa = new Fahrenheit(50);
            Fahrenheit dosFa = new Fahrenheit(5);

            unFa = unFa + dosFa;
            unFa = unFa - dosFa;
            dosFa++;
            dosFa--;
            dosFa = 50;

            if(unFa == dosFa)
            {
                Console.WriteLine("Son iguales");
            }

            //Celsius
            Celsius unCe = new Celsius(10);
            Celsius dosCe = new Celsius(5);

            unCe = unCe + dosCe;
            unCe = unCe - dosCe;
            unCe++;
            unCe--;
            unCe = 5;

            if(unCe == dosCe)
            {
                Console.WriteLine("Son iguales");
            }

            //Kelvin
            Kelvin unKel = new Kelvin(10);
            Kelvin dosKel = new Kelvin(5);

            unKel = unKel + dosKel;
            unKel = unKel - dosKel;
            unKel++;
            unKel--;
            unKel = 5;

            if(unKel == dosKel)
            {
                Console.WriteLine("Son iguales");
            }


            //Operamos con operadores distintos

            // Fahrenheit y otros
            unFa = unFa + unCe;
            unFa = unFa + unKel;
            unFa = unFa - unCe;
            unFa = unFa - unKel;

            unFa = 37;
            if (unFa == unCe)
            {
                Console.WriteLine("Son iguales");
            }

            unFa = -450.67;
            if (unFa == unKel)
            {
                Console.WriteLine("Son iguales");
            }


            // Celsius y otros
            unCe = unCe + unFa;
            unCe = unCe + unKel;
            unCe = unCe - unFa;
            unCe = unCe - unKel;

            if(unCe == unFa)
            {
                Console.WriteLine("Son iguales");
            }

            if (unCe == unKel)
            {
                Console.WriteLine("Son iguales");
            }

            // Kelvin y otros
            unKel = unKel + unFa;
            unKel = unKel + unCe;
            unKel = unKel - unFa;
            unKel = unKel - unCe;

            if (unKel == unFa)
            {
                Console.WriteLine("Son iguales");
            }

            if (unKel == unCe)
            {
                Console.WriteLine("Son iguales");
            }


        }
    }
}
