using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNro27
{
    class Jugador
    {

        //Atributos
        public int golesConvertidos;
        public String nombre;
        public String nombrEquipo;
        public int partidosJugados;
        public float promedioDeGol;

        public void getPromedio()
        {
            this.Calcular();
        }

        private void Calcular()
        {
            this.promedioDeGol = this.golesConvertidos / this.partidosJugados;
        }
        
    }
}
