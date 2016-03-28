using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro11
{
    class Validacion
    {

        public static bool Validar(int max, int min, int numero)
        {
            bool retorno = false;

            if ((numero < max) && (numero > min))
            {
                retorno = true;
            }
            
            return retorno;
        }

    }
}
