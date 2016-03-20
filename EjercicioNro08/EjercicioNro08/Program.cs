using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 08";
            
            //Variables
            float valorHora = 0;
            String nombre;
            int antiguedad = 0;
            int cantindadHoras = 0;
            float importe = 0;
            float importeACobrar;
            float porcentaje;

            //Ingreso de datos
            Console.WriteLine("Ingrese valor hora: ");
            valorHora = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese antiguedad: ");
            antiguedad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de horas trabajadas: ");
            cantindadHoras = int.Parse(Console.ReadLine());

            importe = (valorHora * cantindadHoras) + (antiguedad * 150);
            porcentaje = (13 * importe) / 100;
            importeACobrar = importe - porcentaje;

            Console.WriteLine("------- Total a cobrar --------");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Total bruto: {0}", importe);
            Console.WriteLine("Concepto de descuento de 13 %, {0}", porcentaje);
            Console.WriteLine("Total neto: {0}", importeACobrar);

            Console.ReadLine();
        }
    }
}
