using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro27
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador unJugador = new Jugador();
            Jugador dosJugador = new Jugador();
            Jugador tresJugador = new Jugador();

            List<Jugador> listaJugadores = new List<Jugador>();
            listaJugadores.Add(unJugador);
            listaJugadores.Add(dosJugador);
            listaJugadores.Add(tresJugador);

            //Ingreso jugadores
            foreach (Jugador item in listaJugadores)
            {
                Console.WriteLine("Nombre: ");
                item.nombre = Console.ReadLine();
                Console.WriteLine("Nombre de Equipo: ");
                item.nombrEquipo = Console.ReadLine();
                Console.WriteLine("Partidos jugados: ");
                item.partidosJugados = int.Parse(Console.ReadLine());
                Console.WriteLine("Goles convertidos: ");
                item.golesConvertidos = int.Parse(Console.ReadLine());
                item.getPromedio();
            }

            //Muestro jugadores
            foreach(Jugador item in listaJugadores)
            {
                Console.WriteLine("Nombre: {0}", item.nombre);          
                Console.WriteLine("Nombre de Equipo: {0}",item.nombrEquipo);              
                Console.WriteLine("Partidos jugados: {0}",item.partidosJugados);
                Console.WriteLine("Goles convertidos: {0}",item.golesConvertidos);
                Console.WriteLine("Promedio de goles: {0}",item.promedioDeGol);
            }

            //Odenar por mejor promedio
            Console.WriteLine("\tOrdenado");
            Console.WriteLine("---------------------------------");
            List<Jugador> listaOrdenada = new List<Jugador>();
            


           
            foreach (Jugador item in listaJugadores)
            {
                Console.WriteLine("Nombre: {0}", item.nombre);          
                Console.WriteLine("Nombre de Equipo: {0}",item.nombrEquipo);              
                Console.WriteLine("Partidos jugados: {0}",item.partidosJugados);
                Console.WriteLine("Goles convertidos: {0}",item.golesConvertidos);
                Console.WriteLine("Promedio de goles: {0}",item.promedioDeGol);
            }

            Console.ReadLine();
            
        }
    }
}
