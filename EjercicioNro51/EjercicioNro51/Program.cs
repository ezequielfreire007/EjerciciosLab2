using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro51
{
    class Program
    {
        static void Main(string[] args)
        {
            Gato unGato = new Gato("Pelusa", 3, ERaza.Persa);
            Gato dosGato = new Gato("Ponpon", 2, ERaza.Egipcio);
            Gato tresGato = new Gato("Luna", 1, ERaza.Siames);

            Perro unPerro = new Perro("Tonton", 3, ERaza.Dogo);
            Perro dosPerro = new Perro("Sultan", 3, ERaza.PastorAleman);
            Perro tresPerro = new Perro("Terry", 3, ERaza.Doberman);

            Guarderia miGuarderia = new Guarderia(5, 10);

            miGuarderia += unGato;
            miGuarderia += dosGato;
            miGuarderia += tresGato;

            miGuarderia.ingresarMascota(unPerro);
            miGuarderia.ingresarMascota(dosPerro);
            miGuarderia.ingresarMascota(tresPerro);

            Console.WriteLine("--------- Facturacion -----------");
            Console.WriteLine("Total facturado: {0}",miGuarderia.mostrarTotalFacturado());
            Console.WriteLine("Total facturado por Gato: {0}",miGuarderia.mostrarTotalFacturado(EMascota.Gato));
            Console.WriteLine("Total facturado por Perro: {0}",miGuarderia.mostrarTotalFacturado(EMascota.Perro));

            miGuarderia.ImprimirDatosListaMascota();
            miGuarderia.SerializarListaMascota();
            miGuarderia.DeserealizarListaMascota();
            miGuarderia.TraerDatosMascota();

            Console.WriteLine(miGuarderia.ToString());
            Console.ReadLine();
        }
    }
}
