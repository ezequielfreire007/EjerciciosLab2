using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro61
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trenes
            TrenElectrico trenElectrico = new TrenElectrico("Burzaco", 3);
            TrenBala trenBala = new TrenBala("Pinar", 3);

            //Pasajeros 3
            Pasajero unPasajero = new Pasajero("Gaston", "Pereyra", Rangos.Maquinista);
            Pasajero dosPasajero = new Pasajero("Natalia","Perez",Rangos.Azafata);
            Pasajero tresPasajero = new Pasajero("Pedro","Aznar",Rangos.Cliente);

            //Pasajeros 4
            Pasajero cuartoPasajero = new Pasajero("Ricardo", "Almagro", Rangos.Maquinista);
            Pasajero quintoPasajero = new Pasajero("Esteban", "Rodriguez", Rangos.Cocinero);
            Pasajero sextoPasajero = new Pasajero("Marina" , "Arriondo", Rangos.Azafata);
            Pasajero septimoPasajero = new Pasajero("Carlos", "Martin", Rangos.Cliente);

            //Ingreso de Pasajeros
            try
            {
                trenElectrico.Ingresar(unPasajero);
                trenElectrico.Ingresar(dosPasajero);
                trenElectrico.Ingresar(tresPasajero);

                trenBala.Ingresar(cuartoPasajero);
                trenBala.Ingresar(quintoPasajero);
                trenBala.Ingresar(sextoPasajero);
                trenBala.Ingresar(septimoPasajero);
            }
            catch (Exception ex)
            {
                ManejadorArvhicos.GuardarTexto(ex.Message);
                Console.WriteLine(ex.Message);
            }

            //Lista generica de trenes
            List<Tren> listaDeTrenes = new List<Tren>();
            listaDeTrenes.Add(trenElectrico);
            listaDeTrenes.Add(trenBala);

            if (ManejadorArvhicos.SerializarLista(listaDeTrenes))
            {
                Console.WriteLine("Se lista los trenes");   
            }

            if(ManejadorArvhicos.DeserializarLIsta())
            {
                Console.WriteLine("Se deserializan los trenes");
            }

            Console.ReadLine();
        }
    }
}
