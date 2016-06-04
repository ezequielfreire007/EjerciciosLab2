using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita centralita = new Centralita("Telefonica");
            Local unaLlamada = new Local("Lanus", 30f, "Avellaneda", 2.65f);
            Provincial dosLlamada = new Provincial("Cordoba", Franja.Franja_1, 21f, "Santa Fe");
            Local tresLlamada = new Local("Lomas de Zamora", 45f, "Termperley", 1.99f);
            Provincial cuatroLlamada = new Provincial(Franja.Franja_3, dosLlamada);

            //Cargamos la lista
            centralita.Lista.Add(unaLlamada);
            centralita.Lista.Add(dosLlamada);
            centralita.Lista.Add(tresLlamada);
            centralita.Lista.Add(cuatroLlamada);

            //Mostramos el contenido
            centralita.Mostrar();

            //Ordenamos la lista y la mostramos
            centralita.OrdenarLlamadas();

            Console.WriteLine("############ Lista ordenada #############");
            centralita.Mostrar();

            Console.ReadLine();
        }
    }
}
