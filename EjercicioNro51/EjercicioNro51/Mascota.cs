﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace EjercicioNro51
{
    [XmlInclude(typeof(Mascota))]
    [XmlInclude(typeof(Perro))]
    [XmlInclude(typeof(Gato))]
    public abstract class Mascota
    {
        #region Atributos
        protected int _edad;
        protected string _nombre;
        protected ERaza _raza;
        #endregion

        #region Propiedades

        #endregion

        #region Constructor
        public Mascota()
        { }

        public Mascota(string nombre, ERaza raza)
        {
            this._nombre = nombre;
            this._raza = raza;
        }

        public Mascota(string nombre, int edad, ERaza raza):this(nombre,raza) 
        {
            this._edad = edad;
        }
        #endregion

        #region Metodos
        public virtual void jugar(string conQueJuego)
        {
            Console.WriteLine("Juego con " + conQueJuego);
        }

        public abstract string mostrar();
        #endregion
    }
}
