using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moneda;

namespace MiPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 21";

            Dolar unDolar = new Dolar(10);
            Dolar dosDolar = new Dolar(4);

            Euro unEuro = new Euro(10);
            Euro dosEuro = new Euro(2);

            //Dolares
            unDolar = unDolar + dosDolar;
            unDolar = unDolar - dosDolar;
            unDolar++;
            dosDolar--;
            unDolar = unDolar + unEuro;

            if (unDolar == dosDolar)
            {
                Console.WriteLine("Son iguales");
            }

            if (unDolar == unEuro)
            {
                Console.WriteLine("Son iguales");
            }

            unDolar = 7;

            //Euro
            unEuro = unEuro + dosEuro;
            unEuro = unEuro - dosEuro;
            unEuro++;
            unEuro--;
            unEuro = unEuro + unDolar;

            if (unEuro == dosEuro)
            {
                Console.WriteLine("Son iguales");
            }

            if (unEuro == unDolar)
            {
                Console.WriteLine("Son iguales");
            }

            unEuro = 5;

        }
    }
}
