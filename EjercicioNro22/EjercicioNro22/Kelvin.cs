using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro22
{
    class Kelvin
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
        public Kelvin()
        { }

        public Kelvin(double grados)
        {
            this._grados = grados;
        }

        //Metodos 
        public static Kelvin FahrenheitAKelvin(Fahrenheit fahrenheit)
        {
            //K = (F + 459.67) * 5/9
            Kelvin retorno = new Kelvin();
            retorno._grados = (fahrenheit.getGrados() + 459.67) * 5 / 9;
            return retorno;
        }

        public static Kelvin CelsiusAKelvin(Celsius celsius)
        {
            Kelvin retorno = new Kelvin();
            retorno = FahrenheitAKelvin(Fahrenheit.CelsiusAFahrenheit(celsius));
            return retorno;
        }

        //Operadores sobrecargados
        public static Kelvin operator +(Kelvin uno, Kelvin dos)
        {
            Kelvin retorno = new Kelvin();
            retorno._grados = uno._grados + dos._grados;
            return retorno;
        }

        public static Kelvin operator -(Kelvin uno, Kelvin dos)
        {
            Kelvin retorno = new Kelvin();
            retorno._grados = uno._grados - dos._grados;
            return retorno;
        }

        public static Kelvin operator ++(Kelvin uno)
        {
            uno._grados++;
            return uno;
        }

        public static Kelvin operator --(Kelvin uno)
        {
            uno._grados--;
            return uno;
        }

        public static bool operator ==(Kelvin uno, Kelvin dos)
        {
            bool retorno = false;
            if(uno._grados == dos._grados)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Kelvin uno, Kelvin dos)
        {
            return !(uno == dos);
        }

        public static Kelvin operator +(Kelvin uno, Fahrenheit dos)
        {
            Kelvin retorno = new Kelvin();
            retorno = uno + Kelvin.FahrenheitAKelvin(dos);
            return retorno;
        }

        public static Kelvin operator +(Kelvin uno, Celsius dos)
        {
            Kelvin retono = new Kelvin();
            retono = uno + Kelvin.CelsiusAKelvin(dos);
            return retono;
        }

        public static Kelvin operator -(Kelvin uno, Fahrenheit dos)
        {
            Kelvin retono = new Kelvin();
            retono = uno - Kelvin.FahrenheitAKelvin(dos);
            return retono;
        }

        public static Kelvin operator -(Kelvin uno, Celsius dos)
        {
            Kelvin retorno = new Kelvin();
            retorno = uno - Kelvin.CelsiusAKelvin(dos);
            return retorno;
        }

        public static bool operator ==(Kelvin uno, Fahrenheit dos)
        {
            bool retorno = false;
            Kelvin convertidor = new Kelvin();
            convertidor = Kelvin.FahrenheitAKelvin(dos);

            if(uno == convertidor)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Kelvin uno, Fahrenheit dos)
        {
            return !(uno == dos);
        }

        public static bool operator ==(Kelvin uno, Celsius dos)
        {
            bool retorno = false;
            Kelvin convertidor = new Kelvin();
            convertidor = Kelvin.CelsiusAKelvin(dos);

            if (uno == convertidor)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Kelvin uno, Celsius dos)
        {
            return !(uno == dos);
        }


        //operador explicit e implicit
        //public static explicit operator Kelvin(double dato)
        //{
        //    Kelvin retorno = new Kelvin();
        //    retorno._grados = dato;
        //    return retorno;
        //}

        public static implicit operator Kelvin(double dato)
        {
            Kelvin retorno = new Kelvin();
            retorno._grados = dato;
            return retorno;
        }

    }
}
