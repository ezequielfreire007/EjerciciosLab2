using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro23
{
    class NumeroDecimal
    {
        //Atributos
        private double _numero;

        //Getter y Setter
        public double getNumero()
        {
            return this._numero;
        }

        //Constructor
        private NumeroDecimal(double numero)
        {
            this._numero = numero;
        }


        //Operadores sobrecargados
        public static double operator +(NumeroDecimal uno, NumeroBinario dos)
        {
            double dato = 0;
            dato = uno._numero + Conversor.BinarioDecimal(dos.getNumero());
            return dato;
        }

        public static double operator -(NumeroDecimal uno, NumeroBinario dos)
        {
            double dato = 0;
            dato = uno._numero - Conversor.BinarioDecimal(dos.getNumero());
            return dato;
        }

        public static bool operator ==(NumeroDecimal uno, NumeroBinario dos)
        {
            bool retorno = false;
            double dato = Conversor.BinarioDecimal(dos.getNumero());
            if(dato ==  uno._numero)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(NumeroDecimal uno, NumeroBinario dos)
        {
            return !(uno == dos);
        }

        //Operadore explicito e inplicito
        public static implicit operator NumeroDecimal(int dato)
        {
            NumeroDecimal retorno = new NumeroDecimal(0);
            retorno._numero = dato;
            return retorno;
        }

        public static explicit operator double(NumeroDecimal uno)
        {
            double retorno = 0;
            retorno = uno._numero;
            return retorno;
        }
    }
}
