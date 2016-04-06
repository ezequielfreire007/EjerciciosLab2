using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geormetria
{
    class Punto
    {
        //Atributos
        private int _x;
        private int _y;

        //Constructor 
        public Punto(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        //Getter
        public int getX()
        {
            return this._x;
        }

        public int getY()
        {
            return this._y;
        }
     
    }
}
