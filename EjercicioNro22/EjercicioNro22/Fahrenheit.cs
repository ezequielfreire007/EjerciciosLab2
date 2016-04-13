using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro22
{
    class Fahrenheit
    {
        //Atributos
        private double _grados;

        //Getter y Setter
        public double getGrados()
        {
            return this._grados;
        }

        public void setGrados(double grados)
        {
            this._grados = grados;
        }

        //Constructores
        public Fahrenheit()
        { }

        public Fahrenheit(double grados)
        {
            this._grados = grados;
        }

        //Metodos
        public static Fahrenheit CelsiusAFahrenheit(Celsius celsius)
        {
            //F = C * (9/5) + 32
            Fahrenheit retorno = new Fahrenheit();
            retorno._grados = celsius.getGrados() * (9 / 5) + 32;
            return retorno;

        }

        public static Fahrenheit KelvinAFahrenheit(Kelvin kelvin)
        {
            //F = K * 9/5 – 459.67
            Fahrenheit retorno = new Fahrenheit();
            retorno._grados = kelvin.getGrados() * 9 / 5 - 459.67;
            return retorno;
        }
        
        //Operadores sobrecargados
        public static Fahrenheit operator +(Fahrenheit uno, Fahrenheit dos)
        {
            Fahrenheit retorno = new Fahrenheit();
            retorno._grados = uno._grados + dos._grados;
            return retorno;
        }

        public static Fahrenheit operator -(Fahrenheit uno, Fahrenheit dos)
        {
            Fahrenheit retorno = new Fahrenheit();
            retorno._grados = uno._grados - dos._grados;
            return retorno;
        }

        public static Fahrenheit operator ++(Fahrenheit uno)
        {
            uno._grados++;
            return uno;
        }

        public static Fahrenheit operator --(Fahrenheit uno)
        {
            uno._grados--;
            return uno;
        }

        public static bool operator ==(Fahrenheit uno, Fahrenheit dos)
        {
            bool retorno = false;
            if(uno._grados == dos._grados)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Fahrenheit uno, Fahrenheit dos)
        {
            return !(uno == dos);
        }

        public static Fahrenheit operator +(Fahrenheit uno, Celsius dos)
        {
            Fahrenheit retorno = new Fahrenheit();
            retorno = uno + Fahrenheit.CelsiusAFahrenheit(dos);
            return retorno;
        }

        public static Fahrenheit operator +(Fahrenheit uno, Kelvin dos)
        {
            Fahrenheit retorno = new Fahrenheit();
            retorno = uno + Fahrenheit.KelvinAFahrenheit(dos);
            return retorno;
        }

        public static Fahrenheit operator -(Fahrenheit uno, Celsius dos)
        {
            Fahrenheit retorno = new Fahrenheit();
            retorno = uno - Fahrenheit.CelsiusAFahrenheit(dos);
            return retorno;
        }

        public static Fahrenheit operator -(Fahrenheit uno, Kelvin dos)
        {
            Fahrenheit retorno = new Fahrenheit();
            retorno = uno - Fahrenheit.KelvinAFahrenheit(dos);
            return retorno;
        }

        public static bool operator ==(Fahrenheit uno, Celsius dos)
        {
            bool retorno = false;
            Fahrenheit convertidor = new Fahrenheit();
            convertidor = Fahrenheit.CelsiusAFahrenheit(dos);

            if (uno == convertidor)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Fahrenheit uno, Celsius dos)
        {
            return !(uno == dos);
        }

        public static bool operator ==(Fahrenheit uno, Kelvin dos)
        {
            bool retorno = false;
            Fahrenheit convertidor = new Fahrenheit();
            convertidor = Fahrenheit.KelvinAFahrenheit(dos);

            if(uno == convertidor)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Fahrenheit uno, Kelvin dos)
        {
            return !(uno == dos);
        }

        
        //operdos explicit e inplicit
        //public static explicit operator Fahrenheit(double dato)
        //{
        //    Fahrenheit retorno = new Fahrenheit();
        //    retorno._grados = dato;
        //    return retorno;
        //}

        public static implicit operator Fahrenheit(double dato)
        {
            Fahrenheit retorno = new Fahrenheit();
            retorno._grados = dato;
            return retorno;
        }

    }
}
