using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro37
{
    class CuentaCorriente
    {

        //Atributos
        private Usuario _dueño;
        private int _nuemeroCuenta;
        private double _saldo;

        //Propiedades
        public Usuario Dueño
        {
            get { return this._dueño; }
        }

        public double Saldo
        {
            get { return this._saldo; }
            set { this._saldo = value; }
        }

        //Constructor
        public CuentaCorriente(String apellido, String nombre, double dni, int numero, double saldo)
        {
            this._dueño = new Usuario(apellido, nombre, dni);
            this._saldo = saldo;
        }

        public CuentaCorriente(Usuario miDueño, int numero, double saldo)
        {
            this._dueño = miDueño;
            this._nuemeroCuenta = numero;
            this._saldo = saldo;
        }

        //Operadores sobrecargados
        public static bool operator ==(CuentaCorriente uno, CuentaCorriente dos)
        {
            bool retorno = false;
            if(uno.Dueño.DNI == dos.Dueño.DNI)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(CuentaCorriente uno, CuentaCorriente dos)
        {
            return !(uno == dos);
        }

        public static explicit operator double(CuentaCorriente cuenta)
        {
             return cuenta._saldo;                          
        }

        public static implicit operator CuentaCorriente(Usuario usuario)
        {
            CuentaCorriente retorno = new CuentaCorriente(usuario,0,0);
            return retorno;
        }
    }
}
