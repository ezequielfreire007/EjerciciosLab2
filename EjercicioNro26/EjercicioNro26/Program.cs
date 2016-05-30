using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro26
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////// Ejercicio Numero 25 con Pilas //////////////////////////////////////////
            //int cont = 0;
            //int cont1 = 0;
            //Stack<int> numeros = new Stack<int>(20);

            //numeros.Push(1);
            //numeros.Push(5);
            //numeros.Push(2);
            //numeros.Push(3);
            //numeros.Push(4);
            //numeros.Push(7);
            //numeros.Push(6);
            //numeros.Push(9);
            //numeros.Push(10);
            //numeros.Push(8);
            //numeros.Push(-8);
            //numeros.Push(-9);
            //numeros.Push(-5);
            //numeros.Push(-6);
            //numeros.Push(-1);
            //numeros.Push(-2);
            //numeros.Push(-3);
            //numeros.Push(-8);
            //numeros.Push(-6); 
            //numeros.Push(-7);

            //int [] positivos = new int [10];
            //int[] negativos = new int[10];
            //Stack<int> positivos2 = new Stack<int>(10);
            //Stack<int> negativos2 = new Stack<int>(10);

            ////Mostrar vector inicial
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("\t Vector inicial");
            //Console.WriteLine("-------------------------------------");
            //foreach (int item in numeros)
            //{
            //    Console.WriteLine("\t{0}", item);
            //}
            //Console.WriteLine("-------------------------------------");

            ////Numeros positivos
            //foreach (int numero in numeros)
            //{
            //    if (numero > 0)
            //    {
            //        positivos[cont] = numero;
            //        cont++;
            //    }
            //    else
            //    {
            //        negativos[cont1] = numero;
            //        cont1++;
            //    }
            //}

            ////Mostrar positivos en forma decreciente
            //Array.Sort(positivos);
            //Array.Reverse(positivos);
            //foreach (int item in positivos)
            //{
            //    positivos2.Push(item);
            //}
            //Console.WriteLine("Numeros positivos en forma decreciente");
            //Console.WriteLine("-------------------------------------");
            //foreach (int item in positivos2)
            //{
            //    Console.WriteLine("{0}", item);
            //}

            //Console.WriteLine("-------------------------------------");
            ////Mostrar negativos en forma creciente
            //Array.Sort(negativos);
            //foreach (int item in negativos)
            //{
            //    negativos2.Push(item);
            //}

            //Console.WriteLine("Numeros negativos en forema creciente");
            //Console.WriteLine("-------------------------------------");
            //foreach (int item in negativos2)
            //{
            //    Console.WriteLine("{0}", item);
            //}

            /////////////////////////////////// Ejercicio Numero 25 con Colas //////////////////////////////////////////
            //int cont = 0;
            //int cont1 = 0;
            //Queue<int> numeros = new Queue<int>(20);

            //numeros.Enqueue(1);
            //numeros.Enqueue(5);
            //numeros.Enqueue(2);
            //numeros.Enqueue(3);
            //numeros.Enqueue(4);
            //numeros.Enqueue(7);
            //numeros.Enqueue(6);
            //numeros.Enqueue(9);
            //numeros.Enqueue(10);
            //numeros.Enqueue(8);
            //numeros.Enqueue(-8);
            //numeros.Enqueue(-9);
            //numeros.Enqueue(-5);
            //numeros.Enqueue(-6);
            //numeros.Enqueue(-1);
            //numeros.Enqueue(-2);
            //numeros.Enqueue(-3);
            //numeros.Enqueue(-8);
            //numeros.Enqueue(-6);
            //numeros.Enqueue(-7);

            //int[] positivos = new int[10];
            //int[] negativos = new int[10];
            //Queue<int> positivos2 = new Queue<int>(10);
            //Queue<int> negativos2 = new Queue<int>(10);

            ////Mostrar vector inicial
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("\t Vector inicial");
            //Console.WriteLine("-------------------------------------");
            //foreach (int item in numeros)
            //{
            //    Console.WriteLine("\t{0}", item);
            //}
            //Console.WriteLine("-------------------------------------");

            ////Numeros positivos
            //foreach (int numero in numeros)
            //{
            //    if (numero > 0)
            //    {
            //        positivos[cont] = numero;
            //        cont++;
            //    }
            //    else
            //    {
            //        negativos[cont1] = numero;
            //        cont1++;
            //    }
            //}

            ////Mostrar positivos en forma decreciente
            //Array.Sort(positivos);
            
            //foreach (int item in positivos)
            //{
            //    positivos2.Enqueue(item);
            //}
            //Console.WriteLine("Numeros positivos en forma decreciente");
            //Console.WriteLine("-------------------------------------");
            //foreach (int item in positivos2)
            //{
            //    Console.WriteLine("{0}", item);
            //}

            //Console.WriteLine("-------------------------------------");
            ////Mostrar negativos en forma creciente
            //Array.Sort(negativos);
            //Array.Reverse(negativos);
            //foreach (int item in negativos)
            //{
            //    negativos2.Enqueue(item);
            //}

            //Console.WriteLine("Numeros negativos en forema creciente");
            //Console.WriteLine("-------------------------------------");
            //foreach (int item in negativos2)
            //{
            //    Console.WriteLine("{0}", item);
            //}

            //Console.ReadLine();

            ///////////////////////////////// Ejercicio Numero 25 con Listas //////////////////////////////////////////
            int cont1 = 0;
            List<int> numeros = new List<int>(20);

            numeros.Add(1);
            numeros.Add(5);
            numeros.Add(2);
            numeros.Add(3);
            numeros.Add(4);
            numeros.Add(7);
            numeros.Add(6);
            numeros.Add(9);
            numeros.Add(10);
            numeros.Add(8);
            numeros.Add(-8);
            numeros.Add(-9);
            numeros.Add(-5);
            numeros.Add(-6);
            numeros.Add(-1);
            numeros.Add(-2);
            numeros.Add(-3);
            numeros.Add(-8);
            numeros.Add(-6);
            numeros.Add(-7);

            List<int> positivos = new List<int>();
            List<int> negativos = new List<int>();


            //Mostrar vector inicial
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("\t Vector inicial");
            Console.WriteLine("-------------------------------------");
            foreach (int item in numeros)
            {
                Console.WriteLine("\t{0}", item);
            }
            Console.WriteLine("-------------------------------------");

            //Numeros positivos
            foreach (int numero in numeros)
            {
                if (numero >= 0)
                {
                    positivos.Add(numero);
                }
                else
                {
                    negativos.Add(numero);
                }
            }

            //Mostrar positivos en forma decreciente
            positivos.Sort();
            positivos.Reverse();

            Console.WriteLine("Numeros positivos en forma decreciente");
            Console.WriteLine("-------------------------------------");
            foreach (int item in positivos)
            {
                Console.WriteLine("{0}", item);
            }

            Console.WriteLine("-------------------------------------");
            //Mostrar negativos en forma creciente
            negativos.Sort();
            
            Console.WriteLine("Numeros negativos en forema creciente");
            Console.WriteLine("-------------------------------------");
            foreach (int item in negativos)
            {
                Console.WriteLine("{0}", item);
            }

            Console.ReadLine();
        }
    }
}
