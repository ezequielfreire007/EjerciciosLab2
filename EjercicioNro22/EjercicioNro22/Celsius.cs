using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro22
{
    class Celsius
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
        public Celsius()
        { }

        public Celsius(double grados)
        {
            this._grados = grados;
        }

        //Metodos
        public static Celsius FahrenheitACelsius(Fahrenheit fahrenheit)
        {
            //C = (F-32) * 5/9
            Celsius retorno = new Celsius();
            retorno._grados = (fahrenheit.getGrados() - 32) * 5 / 9;
            return retorno;
        }

        public static Celsius KelvinACelsius(Kelvin kelvin)
        {
            Celsius retorno = new Celsius();
            retorno = Celsius.FahrenheitACelsius((Fahrenheit.KelvinAFahrenheit(kelvin)));
            return retorno;
        }

        //Operadores sobrecargados
        public static Celsius operator +(Celsius uno, Celsius dos)
        {
            Celsius retorno = new Celsius();
            retorno._grados = uno._grados + dos._grados;
            return retorno;
        }

        public static Celsius operator -(Celsius uno, Celsius dos)
        {
            Celsius retorno = new Celsius();
            retorno._grados = uno._grados - dos._grados;
            return retorno;
        }

        public static Celsius operator ++(Celsius uno)
        {
            uno._grados++;
            return uno;
        }

        public static Celsius operator --(Celsius uno)
        {
            uno._grados--;
            return uno;
        }

        public static bool operator ==(Celsius uno, Celsius dos)
        {
            bool retorno = false;
            if(uno._grados == dos._grados)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Celsius uno, Celsius dos)
        {
            return !(uno == dos);
        }

        public static Celsius operator +(Celsius uno, Fahrenheit dos)
        {
            Celsius retorno = new Celsius();
            retorno = uno + Celsius.FahrenheitACelsius(dos);
            return retorno;
        }

        public static Celsius operator +(Celsius uno, Kelvin dos)
        {
            Celsius retorno = new Celsius();
            retorno = uno + Celsius.KelvinACelsius(dos);
            return retorno;
        }

        public static Celsius operator -(Celsius uno, Fahrenheit dos)
        {
            Celsius retorno = new Celsius();
            retorno = uno + Celsius.FahrenheitACelsius(dos);
            return retorno;
        }

        public static Celsius operator -(Celsius uno, Kelvin dos)
        {
            Celsius retorno = new Celsius();
            retorno = uno - Celsius.KelvinACelsius(dos);
            return retorno;
        }

        public static bool operator ==(Celsius uno, Fahrenheit dos)
        {
            bool retorno = false;
            Celsius convertidor = new Celsius();
            convertidor = Celsius.FahrenheitACelsius(dos);

            if(uno == convertidor)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Celsius uno, Fahrenheit dos)
        {
            return !(uno == dos);
        }

        public static bool operator ==(Celsius uno, Kelvin dos)
        {
            bool retorno = false;
            Celsius convertidor = new Celsius();
            convertidor = Celsius.KelvinACelsius(dos);

            if (uno == convertidor)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Celsius uno, Kelvin dos)
        {
            return !(uno == dos);
        }


        //operador explicit e implicit
        //public static explicit operator Celsius(double dato)
        //{
        //    Celsius retorno = new Celsius();
        //    retorno._grados = dato;
        //    return retorno;
        //}

        public static implicit operator Celsius(double dato)
        {
            Celsius retorno = new Celsius();
            retorno._grados = dato;
            return retorno;
        }


    }
}
