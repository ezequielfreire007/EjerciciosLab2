using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro23
{
    class Conversor
    {

        public static String DecimalBinario(double numero)
        {
            String resultado = "";
            int resto = 0;

            while(numero >= 1)
            {
                resto = (int)numero % 2;
                resultado = resto + resultado;
                numero = numero / 2;           
            }

            return resultado;
        }

        public static double BinarioDecimal(String binario)
        {
            double resultado = 1;
            int decrece = binario.Length;
            int posicion = 0;

            for (int i = 1; i < binario.Length; i++ )
            {
                decrece--;
                posicion =int.Parse( binario.Substring(i,1));
                resultado = resultado + Math.Pow(2, decrece * posicion);
            }

            return resultado;
        }

    }
}
