﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Llamada
    {
        #region Atributos
        protected float _duracion;
        protected String _nroDestino;
        protected String _nroOrigen;
        #endregion

        #region Propiedades
        public float Duracion
        {
            get { return this._duracion; }
        }

        public String NroDestino
        {
            get { return this._nroDestino; }
        }

        public String NroOrigen
        {
            get { return this._nroOrigen; }
        }
        #endregion

        #region Constructores
        public Llamada(String origen, String destino, float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        }
        #endregion

        #region Metodos de instancia Mostrar
        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nro de Origen: "+this._nroOrigen);
            sb.AppendLine("Nro de Destino: "+this._nroDestino);
            sb.AppendLine("Duracion de llamada: "+this._duracion);
            Console.WriteLine(sb.ToString());
        }
        #endregion

        #region Metodo de clase Ordenar por duracion
        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            int retorno = 0;
            if (uno._duracion == dos._duracion)
            {
                retorno = 0;
            }
            if (uno._duracion < dos._duracion)
            {
                retorno = 1; //Con 1 en esta posicion lo ordena de mayoar a menos y con -1 al contrario
            }
            if (uno._duracion > dos._duracion) //una de las condiciones debe ser el opuesto siempre al otro
            {
                retorno = -1; //Con 1 en esta posicion lo ordena de mayoar a menos y con -1 al contrario
            }
            return retorno;
        }
        #endregion
    }
}
