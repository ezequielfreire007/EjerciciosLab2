using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro17
{
    class Cuenta
    {
        //Atributos
        private String _nombre;
        private long _nroCuenta;
        private double _saldo;
        private ETipoInteres _tipoInteres;

        //Getter y Setter
        public String getNombre()
        {
            return this._nombre;
        }

        public void setNombre(String nombre)
        {
            //Object comparacion = nombre;
            int numero = 0;
            bool comparacion = int.TryParse(nombre, out numero);
            
            
            if (comparacion)
            {
                this._nombre = "1";
            }
            else 
            {
                this._nombre = nombre;
            }
         
        }

        public long getNroCuenta()
        {
            return this._nroCuenta;
        }

        public void setNroCuenta(long nroCuenta)
        {
 
            if (nroCuenta > 0)
            {
                this._nroCuenta = nroCuenta;
            }
            if(nroCuenta < 0)
            {
                this._nroCuenta = -1;
            }
            
        }

        public double getSaldo()
        {
            return this._saldo;
        }

        public void setSaldo(double saldo)
        {

            if (saldo >= 0)
            {
                this._saldo = saldo;
            }
            if (saldo < 0)
            {
                this._saldo= -1;
            }


        }

        public ETipoInteres getTipoInteres()
        {
            return this._tipoInteres;
        }

        public void setTipoInteres(ETipoInteres tipoInteres)
        {
            if ((tipoInteres <= (ETipoInteres)3) && (tipoInteres > (ETipoInteres)0))
            {
                this._tipoInteres = tipoInteres;
            }
            else
            {
                this._tipoInteres = (ETipoInteres)4;
            }
        }

    }
}
