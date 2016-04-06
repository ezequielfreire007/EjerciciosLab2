using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geormetria
{
    class Rectangulo
    {
        //Atributos
        public Punto vertice1;
        public Punto vertice2;
        public Punto vertice3;
        public Punto vertice4;
        public float perimetro;
        public float superficie;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = new Punto(this.vertice3.getX(), this.vertice1.getY());
            this.vertice4 = new Punto(this.vertice1.getX(), this.vertice3.getY());
            CalcularSuperficie();
            CalcularPerimetro();
        }

        public void CalcularSuperficie()
        {
            float bas = 0;
            float altura = 0;
            
            bas = Math.Abs(this.vertice4.getX() - this.vertice3.getX());
            altura = Math.Abs(this.vertice4.getY() - this.vertice1.getY());

            this.superficie = bas * altura;
            //Console.WriteLine("La superficier del rectangulo : {0}", this.superficie);
        }

        public void CalcularPerimetro()
        {
            float lado1;
            float lado2;

            lado1 = Math.Abs(this.vertice4.getX() - this.vertice3.getX());
            lado2 = Math.Abs(this.vertice4.getY() - this.vertice1.getY());

            this.perimetro = 2 * lado1 + 2 * lado2;
            //Console.WriteLine("El perimetro del rectangulo: {0}", this.perimetro);
        }

    }
}
