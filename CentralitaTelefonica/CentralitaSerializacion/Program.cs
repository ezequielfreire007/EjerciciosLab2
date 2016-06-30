using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaSerializacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita miCentralita = new Centralita("Telefonica");

            Local unaLocal = new Local("Lanus", 30f, "Lomas de Zamora", 2.65f);
            Provincial unaProvincial = new Provincial("Cordoba", Franja.Franja_1, 21f, "Tucuman");
            Local dosLocal = new Local("Lanus", 45f, "Escalada", 1.99f);
            Provincial dosProvincial = new Provincial(Franja.Franja_3, unaProvincial);

            miCentralita.RutaDeArchivo = "Centralita.Xml";

            if (miCentralita.Deserealizarse())
            {
                Console.WriteLine("Se desarializo la centralita");
            }
            else
            {
                Console.WriteLine("No se puedo deserializar la centralita");
            }

            miCentralita += unaLocal;
            miCentralita += unaProvincial;
            miCentralita += dosLocal;
            miCentralita += dosProvincial;

            Console.WriteLine(miCentralita.ToString());

            Console.WriteLine(" ------- Ordenar las llamadas ---------");
            miCentralita.Lista.Sort(Llamada.OrdenarPorDuracion);

            Console.WriteLine(miCentralita.ToString());

            miCentralita.RutaDeArchivo = "Llamada.txt";
            miCentralita.GuardarEnArchivo(unaLocal, true);

            miCentralita.RutaDeArchivo = "Centralita.Xml";
            if (miCentralita.Serializarse())
            {
                Console.WriteLine("Se serializo la centralita");
            }
            else
            {
                Console.WriteLine("No se puedo serializar la centralita");
            }


            Console.ReadLine();
        }
    }
}
