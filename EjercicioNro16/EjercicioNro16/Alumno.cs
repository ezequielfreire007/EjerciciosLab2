using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro16
{
    class Alumno
    {
        //Atributos
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;
        public String apellido;
        public String nombre;
        public int legajo;

        public void CalcularFinal()
        {
            if ((this._nota1 >= 4) && (this._nota2 >= 4))
            {
                Random nota = new Random(10);
                this._notaFinal = nota.Next();
            }
            else
            {
                this._notaFinal = -1;
            }
        }

        public void Estudiar(byte nota1, byte nota2)
        {
            this._nota1 = nota1;
            this._nota2 = nota2;
        }

        public void Mostrar()
        {
            Console.WriteLine("********* Datos del alumno ************");
            Console.WriteLine("Nombre: {0}",  this.nombre);
            Console.WriteLine("Apellido: {0}", this.apellido);
            Console.WriteLine("Nro de Legajo: {0}", this.legajo);
            Console.WriteLine("Nota 1: {0}", this._nota1);
            Console.WriteLine("Nota 2: {0}", this._nota2);
            if (this._notaFinal != -1)
            {
                Console.WriteLine("Nota final: {0}", this._notaFinal);
            }

            
        }


    }
}
