using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 11";
            
            //Variables
            int cont = 0;
            int numero = 0;
            String numeros = "";
            String[] separados = {};
            float suma = 0;
            int max = 0;
            int min = 99999;


            //Ingreso y validacion de datos
            while(cont<2)
            {
                Console.WriteLine("Ingrese un numero entre -100 y 100:");
                numero = int.Parse(Console.ReadLine());
                if (Validacion.Validar(100, -100, numero))
                {
                    numeros += numero + ","; 
                    suma += numero;
                }
                cont++;
            }

            separados = numeros.Split(',');

            foreach(String num in separados)
            {
               
                int numaux = 0;

                while (int.TryParse(num, out numaux) == false)
                {
                    
                    if (num == "")
                    {
                        break;
                    }
                    numaux = int.Parse(num);
                }
                if (numaux > max)
                {
                    if (numaux < min)
                    {
                        min = numaux;
                    }

                    max = numaux;
                }

            }

            Console.WriteLine("Maximo: {0}",max);
            Console.WriteLine("Minimo: {0}",min);
            Console.WriteLine("Promedio: {0}",suma/cont);

        }
    }
}
