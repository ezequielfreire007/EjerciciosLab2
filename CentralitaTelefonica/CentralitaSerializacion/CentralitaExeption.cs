using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaSerializacion
{
    public class CentralitaExeption : Exception
    {
        #region Atributos
        protected Exception _excepcionInterna;
        protected String _nombreClase;
        protected String _nomrbeMetodo;
        #endregion

        #region Propiedades
        public Exception ExcepcionInterna
        {
            get
            {
                return this._excepcionInterna;
            }
        }

        public String NombreClase
        {
            get
            {
                return this._nombreClase;
            }
        }

        public String NombreMetodo
        {
            get
            {
                return this._nomrbeMetodo;
            }
        }
        #endregion

        #region Constructores

        public CentralitaExeption(String mensaje, String clase, String metodo):base(mensaje)
        {
            this._nombreClase = clase;
            this._nomrbeMetodo = metodo;
        }

        public CentralitaExeption(String mensaje, String clase, String metodo, Exception innerException):this(mensaje,clase,metodo)
        {
            this._excepcionInterna = innerException;
        }

        #endregion
    }
}
