using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    class Euro
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

        //constructor
        public Euro()
        { }
    
        public Euro(double valor)
        {
            this._valor = valor;
        }

        //Operadores sobrecargados
        public static Euro operator +(Euro uno, Euro dos)
        {
            Euro retorno = new Euro();
            retorno._valor = uno._valor + dos._valor;
            return retorno;
        }

        public static Euro operator -(Euro uno, Euro dos)
        {
            Euro retorno = new Euro();
            retorno._valor = uno._valor - dos._valor;
            return retorno;
        }

        public static Euro operator ++(Euro uno)
        {
            uno._valor++;
            return uno;
        }

        public static Euro operator --(Euro uno)
        {
            uno._valor--;
            return uno;
        }

        public static bool operator ==(Euro uno, Euro dos)
        {
            bool retorno = false;
            if(uno._valor == dos._valor)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Euro uno, Euro dos)
        {
            return !(uno == dos);
        }

        public static Euro operator +(Euro uno, Dolar dos)
        {
            Euro retorno = new Euro();
            retorno._valor = uno._valor + (dos.getValor() / 1.3642);
            return retorno;
        }

        public static Euro operator -(Euro uno, Dolar dos)
        {
            Euro retorno = new Euro();
            retorno._valor = uno._valor - (dos.getValor() / 1.3642);
            return retorno;
        }

        public static bool operator ==(Euro uno, Dolar dos)
        {
            bool retorno = false;
            if(uno._valor == dos.getValor())
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Euro uno, Dolar dos)
        {
            return !(uno == dos);
        }

        //public static explicit operator Euro(double valor)
        //{
        //    Euro retorno = new Euro();
        //    retorno._valor = valor;
        //    return retorno;
        //}

        public static implicit operator Euro(double valor)
        {
            Euro retorno = new Euro();
            retorno._valor = valor;
            return retorno;
        }

    }
}
