using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro61
{
    public class PasajerosOverFlowException : Exception
    {
        public string mensage;

        public PasajerosOverFlowException(string mensaje)
            : base(mensaje)
        { }
    }
}
