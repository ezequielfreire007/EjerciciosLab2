using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro23
{
    class NumeroBinario
    {
        //Atributo
        private String _numero;

        //Getter y Setter
        public String getNumero()
        {
            return this._numero;
        }

        //Constructor
        private NumeroBinario(String numero)
        {
            this._numero = numero;
        }

        //Operadores sobrecargados
        public static String operator +(NumeroBinario uno, NumeroDecimal dos)
        {
            String retorno = " ";
            double dato = 0;
            dato = Conversor.BinarioDecimal(uno._numero) + dos.getNumero();
            retorno = Conversor.DecimalBinario(dato);
            return retorno;
        }

        public static String operator -(NumeroBinario uno, NumeroDecimal dos)
        {
            String retorno = "";
            double dato = 0;
            dato = Conversor.BinarioDecimal(uno._numero) - dos.getNumero();
            retorno = Conversor.DecimalBinario(dato);
            return retorno;
        }

        public static bool operator ==(NumeroBinario uno, NumeroDecimal dos)
        {
            bool retorno = false;
            double dato = 0;
            dato = Conversor.BinarioDecimal(uno._numero);
            if (dato == dos.getNumero())
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(NumeroBinario uno, NumeroDecimal dos)
        {
            return !(uno == dos);
        }

       // Operador explicito e implicito
        public static implicit operator NumeroBinario(String dato)
        {
            NumeroBinario retorno = new NumeroBinario("");
            retorno._numero = dato;
            return retorno;
        }

        public static explicit operator String(NumeroBinario uno)
        {
            String retorno = "";
            retorno = uno._numero;
            return retorno;
        }

       
    }
}
