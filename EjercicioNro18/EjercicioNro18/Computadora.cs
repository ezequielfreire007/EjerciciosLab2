using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Procesador;
using Marca;

namespace LaComputadora
{
    class Computadora
    {
        //Atributos
        private bool _estaEncendida;
        private EMarca _marca;
        private float _peso;
        private EProcesador _procesador;

        //Constructor
        public Computadora(bool estaEncendida, EMarca marca, float peso, EProcesador procesador)
        {
            this._estaEncendida = estaEncendida;
            this._marca = marca;
            this._peso = peso;
            this._procesador = procesador;
            InformarEstado();
            Encender();
            InformarEstado();
            Apagar();
            InformarEstado();
        }

        //Getter y Setter
        public bool getEstaEncendida()
        {
            return this._estaEncendida;
        }

        public void setEstaEncendida(bool estaEncendida)
        {
            this._estaEncendida = estaEncendida;
        }

        public EMarca getMarca()
        {
            return this._marca;
        }

        public void setMarca(EMarca marca)
        {
            this._marca = marca;
        }

        public float getPeso()
        {
            return this._peso;
        }

        public void setPeso(float peso)
        {
            this._peso = peso;      
        }

        public EProcesador getProcesador()
        {
            return this._procesador;
        }

        public void setProcesador(EProcesador procesador)
        {
            this._procesador = procesador;
        }

        //Metodos
        public void InformarEstado()
        {
            Console.WriteLine("********** Estados de la computadora *************");
            Console.WriteLine("Marca: {0}",this._marca);
            Console.WriteLine("Procesador: {0}",this._procesador);
            Console.WriteLine("Peso: {0}",this._peso);
            if(this._estaEncendida)
            {
                Console.WriteLine("Estado: Encendida");
            }
            else
            {
                Console.WriteLine("Estado: Apagada");
            }
            Console.WriteLine("**************************************************");
            
        }

        public void Encender()
        {
            this._estaEncendida = true;
        }

        public void Apagar()
        {
            this._estaEncendida = false;
        }
    }
}
