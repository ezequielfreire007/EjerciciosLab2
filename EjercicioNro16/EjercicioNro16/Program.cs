using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumnoUno = new Alumno();
            alumnoUno.nombre = "Pepe";
            alumnoUno.apellido = "Casanova";
            alumnoUno.legajo = 1;
            alumnoUno.Estudiar(5,7);
            alumnoUno.CalcularFinal();
            alumnoUno.Mostrar();

            Alumno alumnoDos = new Alumno();
            alumnoDos.nombre = "Barry";
            alumnoDos.apellido = "Alen";
            alumnoDos.legajo = 2;
            alumnoDos.Estudiar(4,2);
            alumnoDos.CalcularFinal();
            alumnoDos.Mostrar();

            Alumno alumnoTres = new Alumno();
            alumnoTres.nombre = "Clark";
            alumnoTres.apellido = "Kend";
            alumnoTres.legajo = 3;
            alumnoTres.Estudiar(10, 8);
            alumnoTres.CalcularFinal();
            alumnoTres.Mostrar();

            Console.ReadLine();
        }
    }
}
