using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro36
{
    class Container
    {
        //Atributos
        private int _capacidad;
        private String _empresa;
        private List<Producto> _listaProductos;

        //Constructor
        public Container(int capacidad, String empresa)
        {
            this._capacidad = capacidad;
            this._empresa = empresa;
            this._listaProductos = new List<Producto>();
        }

        //Metodos
        public static void Mostrar(Container contenedor)
        {
            Console.WriteLine("_-_-_-_Container_-_-_-_-");
            Console.WriteLine("Empresa: {0}", contenedor._empresa);
            Console.WriteLine("Capacidad: {0}", contenedor._capacidad);

            foreach (Producto item in contenedor._listaProductos)
            {
                item.mostrar();
            }
        }  
 
        //Operadores sobrecargados
        public static bool operator ==(Container contenedor, Producto producto)
        {
            bool retorno = false;
            foreach (Producto item in contenedor._listaProductos)
            {
                if (item == producto)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Container contenedor, Producto producto)
        {
            return !(contenedor == producto);
        }

        public static List<Producto> operator -(Container container, eTipoComestible tipo)
        {
            List<Producto> retorno = new List<Producto>();

            foreach  (Producto item in container._listaProductos)
            {
                if (item == tipo)
                {
                    retorno.Add(item);
                }
            }

            return retorno;
        }

        public bool Agregar(Producto producto)
        {
            bool retorno = false;

            if ((this != producto) && (this._listaProductos.Count < this._capacidad))
            {
                this._listaProductos.Add(producto);
                retorno = true;
            }

            return retorno;
        }
    }
}
