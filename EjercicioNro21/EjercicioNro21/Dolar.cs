using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    class Dolar
    {
        //Atributos
        private double _valor;

        //Getter y Setter
        public double getValor()
        {
            return this._valor;
        }

        public void setValor(double valor)
        {
            this._valor = valor;
        }

        //Consturctor 
        public Dolar()
        { }

        public Dolar(double valor)
        {
            this._valor = valor;
        }

        //Operadores sobrecargados
        public static Dolar operator +(Dolar uno, Dolar dos)
        {
            Dolar retorno = new Dolar();
            retorno._valor = uno._valor + dos._valor;
            return retorno;
        }

        public static Dolar operator -(Dolar uno, Dolar dos)
        {
            Dolar retorno = new Dolar();
            retorno._valor = uno._valor - dos._valor;
            return retorno;
        }

        public static Dolar operator ++(Dolar uno)
        {
            uno._valor++;
            return uno;
        }

        public static Dolar operator --(Dolar uno)
        {
            uno._valor++;
            return uno;
        }

        public static bool operator ==(Dolar uno, Dolar dos)
        {
            bool retorno = false;
            if(uno._valor == dos._valor)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Dolar uno, Dolar dos)
        {
            return !(uno == dos);
        }

        public static Dolar operator +(Dolar uno, Euro dos)
        {
            Dolar retorno = new Dolar();
            retorno._valor = uno._valor + (dos.getValor() * 1.3642);
            return retorno;
        }

        public static Dolar operator -(Dolar uno, Euro dos)
        {
            Dolar retorno = new Dolar();
            retorno._valor = uno._valor - (dos.getValor() * 1.3642);
            return retorno;
        }

        public static bool operator ==(Dolar uno, Euro dos)
        {
            bool retorno = false;

            if (uno._valor == dos.getValor())
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Dolar uno, Euro dos)
        {
            return !(uno == dos);
        }

        //public static explicit operator Dolar(double uno)
        //{
        //    Dolar retorno = new Dolar();
        //    retorno._valor = uno;
        //    return retorno;
        //}

        public static implicit operator Dolar(double uno)
        {
            Dolar retorno = new Dolar();
            retorno._valor = uno;
            return retorno;
        }
    }
}
