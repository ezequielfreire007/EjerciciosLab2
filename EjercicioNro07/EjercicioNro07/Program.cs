using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 07";

            //variables
            int dia, mes, anio;
            DateTime fecha;
            DateTime fechaActual;
            TimeSpan cantiDias;

            //ingreso de datos
            Console.WriteLine("Ingrese dia: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese mes: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese anio");
            anio = int.Parse(Console.ReadLine());

            fecha = new DateTime(anio, mes, dia);
            fechaActual = DateTime.Now;
            cantiDias = fechaActual - fecha;

            Console.WriteLine("Cantidad de dias vividos: {0}", cantiDias.Days);
            Console.ReadLine();

        }
    }
}
