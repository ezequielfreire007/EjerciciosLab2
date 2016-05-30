using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro36
{
    class Producto
    {

        //Atributos
        private int _codigoDeBarra;
        private String _nombre;
        private double _precio;
        private eTipoComestible _tipo;

        //Contrustores
        private Producto(int coidgoDeBarras)
        {
            this._codigoDeBarra = coidgoDeBarras;
        }

        public Producto(int codigoDeBarras, String nombre, eTipoComestible tipo):this(codigoDeBarras)
        {
            this._nombre = nombre;
            this._tipo = tipo;
        }

        public Producto(int codigoDeBarras, String nombre, eTipoComestible tipo, double precio)
            : this(codigoDeBarras, nombre, tipo)
        {
            this._precio = precio;
        }

        //Metodos
        public void mostrar()
        {
            Console.WriteLine("Producto:");
            Console.WriteLine("Nombre: {0}", this._nombre);
            Console.WriteLine("Tipo: {0}", this._tipo);
            Console.WriteLine("Codigo de barras: {0}", this._codigoDeBarra);
            Console.WriteLine("Precio: {0}", this._precio);
        }

        //Operadores sobrecargados
        public static bool operator ==(Producto uno, Producto dos)
        {
            bool retorno = false;
            if((uno._nombre == dos._nombre) && (uno._codigoDeBarra == dos._codigoDeBarra) && (uno._tipo == dos._tipo))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Producto uno, Producto dos)
        {
            return !(uno == dos);
        }

        public static bool operator ==(Producto producto, eTipoComestible tipo)
        {
            bool retorno = false;
            if (producto._tipo == tipo)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Producto producto, eTipoComestible tipo)
        {
            return !(producto == tipo);
        }
    }
}
