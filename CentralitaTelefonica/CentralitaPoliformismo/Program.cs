using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPoliformismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instacion la centralita
            Centralita miCentralita = new Centralita("Telefonica");

            //Llamadas
            Local unoLocal = new Local("Lanus", 30f, "Lomas de Zamora", 2.65f);
            Provincial dosProvincial = new Provincial("Buenos Aires", Franja.Franja_1, 21f, "Tucuman");
            Local tresProvincial = new Local("Lanes Este", 45f, "Lanus Oeste", 1.99f);
            Provincial cuatroProvincial = new Provincial(Franja.Franja_3, dosProvincial);

            //Agregamos las llamadas
            miCentralita += unoLocal;
            miCentralita += dosProvincial;
            miCentralita += tresProvincial;
            miCentralita += cuatroProvincial;

            //Mostrar datos
            Console.WriteLine(miCentralita.ToString());

            miCentralita.OrdenarLlamadas();
            //Llamadas ordenadas
            Console.WriteLine("------------ Llamadas Ordenadas -------------");
            Console.WriteLine(miCentralita.ToString());

            Console.ReadLine();

            

            
        }
    }
}
