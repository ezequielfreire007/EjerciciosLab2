using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Boligrafos
{
    class Boligrafo
    {
        //Atributos
        private ConsoleColor _color;
        private int _tinta;

        //Constructor
        public Boligrafo(ConsoleColor color, int tinta)
        {
            this._color = color;
            this._tinta = tinta;
        }

        //Getter y Setter
        public ConsoleColor getColor()
        {
            return this._color;
        }

        public void setColor(ConsoleColor color)
        {
            this._color = color;
        }

        public int getTinta()
        {
            return this._tinta;
        }

        public void setTinta(int tinta)
        {
            if(this._tinta == -1)
            {
                this._tinta = 0;
            }
            if ((this._tinta <= 100) && (this._tinta >= 0))
            {
                this._tinta += tinta;
            }
            if (this._tinta > 100)
            {
                this._tinta = -1;
            }
            if(this._tinta < 0)
            {
                this._tinta = -1;
            }
     
        }

        //Metodos
        public bool Pintar()
        {
            bool retornar = false;

            if ((this._tinta <= 100) && (this._tinta > 0))
            {
                this._tinta -= 10;
                retornar = true;
            }

            return retornar;
        }

        public void Recargar()
        {
            if ((this._tinta < 100) && (this._tinta > 0))
            {
                this.setTinta(5);
            }
        }
    }
}
