using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial
{

    public class Cajon
    {
        #region Atributos
        private int _capacidad;
        private List<Fruta> _frutas;
        #endregion

        #region Propiedades
        public List<Fruta> Fruta
        {
            get { return this._frutas; }
        }

        public double PrecioDeManazan
        {
            get { return this.ObtenerTotal(EtipoFruta.Manzana); } 
        }

        public double PrecioDePlatano
        {
            get { return this.ObtenerTotal(EtipoFruta.Platano); } 
        }

        public double PrecioTotal
        {
            get { return this.ObtenerTotal(EtipoFruta.Todo); } 
        }

        #endregion

        #region Constructor
        public Cajon()
        {
            this._frutas = new List<Fruta>(1);
        }

        public Cajon(int capacidad):this()
        {
            this._capacidad = capacidad;
        }

        #endregion

        #region Metodos
        private double ObtenerTotal(EtipoFruta tipo)
        {
            double retorno = 0;

            if (EtipoFruta.Manzana == tipo)
            {
                foreach (Fruta item in this._frutas)
                {
                    if (item is Manzana)
                    {
                        retorno += ((Manzana)item).precio;
                    }
                }
            }

            if (EtipoFruta.Platano == tipo)
            {
                foreach (Fruta item in this._frutas)
                {
                    if (item is Platano)
                    {
                        retorno += ((Platano)item).precio;
                    }
                }
            }

            if (EtipoFruta.Todo == tipo)
            {
                foreach (Fruta item in this._frutas)
                {
                    if (item is Manzana)
                    {
                        retorno += ((Manzana)item).precio;
                    }
                    else
                    {
                        retorno += ((Platano)item).precio;
                    }
                }
            }

            return retorno;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("------- Cajon ---------");
            sb.AppendLine("Capacidad: " + this._capacidad);

            foreach (Fruta item in this._frutas)
            {
                if (item is Manzana)
                {
                    sb.AppendLine(((Manzana)item).ToString());
                }
                else
                {
                    sb.AppendLine(((Platano)item).ToString());
                }

            }
            return sb.ToString();
        }

        public static Cajon operator +(Cajon cajon, Fruta fruta)
        {
            foreach (Fruta item in cajon.Fruta)
            {
                if (cajon.Fruta.Count < cajon._capacidad && (item is Manzana))
                {
                    cajon.Fruta.Add((Manzana)item);
                }
                else
                {
                    cajon.Fruta.Add((Platano)item);
                }
            }

            return cajon;
        }
        #endregion
    }
}
