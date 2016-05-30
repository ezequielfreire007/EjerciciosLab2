using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boligrafos
{
    class Boligrafo
    {
        //Atributos
        private int _cantidadTinta;
        private String _color;
        private String _marca;

        //Constructores
        public Boligrafo(String color, String marca)
        {
            this._color = color;
            this._marca = marca;
            this._cantidadTinta = 0;
        }

         public Boligrafo(String color, String marca, int cantidad)
        {
            this._color = color;
            this._marca = marca;
            this._cantidadTinta = cantidad;
        }

        public Boligrafo(int cantidad, String color, String marca)
        {
            this._cantidadTinta = cantidad;
            this._color = color;
            this._marca = marca;
        }

        public Boligrafo(String color, int cantidad, String marca)
        {
            this._color = color;
            this._cantidadTinta = cantidad;
            this._marca = marca;
        }

        //Metodos 
        private void Mostrar()
        {
            Console.WriteLine("-------------Boligrafo-----------------");
            Console.WriteLine("Marca: {0}", this._marca);
            Console.WriteLine("Color: {0}", this._color);
            Console.WriteLine("Cantidad: {0}", this._cantidadTinta);
        }

        public static void MostrarBoligrafos(List<Boligrafo> lista)
        {
            foreach (Boligrafo item in lista)
            {
                item.Mostrar();
            }
        }

        public void Escribir(int cantidadNecesaria)
        {
            if (this._cantidadTinta > cantidadNecesaria)
            {
                this._cantidadTinta -= cantidadNecesaria;
            }
            else
            {
                Console.WriteLine("La cantidad de tinta no es suficiente para escribir");
                this.Mostrar();
            }
        }

        public bool RecargarTinta()
        {
            bool retorno = false;
            if (this._cantidadTinta < 50)
            {
                this._cantidadTinta = 100;
                retorno = true;
            }

            return retorno;
        }

        public bool RecargarTinta(int cantidad)
        {
            bool retorno = false;
            if (this._cantidadTinta > 50)
            {
                this._cantidadTinta += cantidad;
                retorno = true;
            }

            return retorno;
        }

        //Operadores sobrecargados
        public static bool operator ==(Boligrafo uno, Boligrafo dos)
        {
            bool retorno = false;
            if((uno._marca == dos._marca) && (uno._color == dos._color))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Boligrafo uno, Boligrafo dos)
        {
            return !(uno == dos);
        }

        public static List<Boligrafo> operator +(List<Boligrafo> lista, Boligrafo boligrafo)
        {
            lista.Add(boligrafo);
            return lista;
        }

        public static List<Boligrafo> operator -(List<Boligrafo> lista, Boligrafo boligrafo)
        {
            foreach (Boligrafo item in lista)
            {
                if (item == boligrafo)
                {
                    lista.Remove(item);
                    break;
                }
            }
            return lista;
        }
    }
}
