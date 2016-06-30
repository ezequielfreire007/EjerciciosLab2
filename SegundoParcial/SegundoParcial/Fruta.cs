using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SegundoParcial
{
    [XmlInclude(typeof(Fruta))]
    [XmlInclude(typeof(Manzana))]
    public abstract class Fruta
    {
        #region Atributos
        protected ConsoleColor _color;
        protected float _peso;
        #endregion

        #region Propiedades
        public abstract bool TieneCarozo
        {
            get;
        }
        #endregion

        #region Constructores
        public Fruta(float peso, ConsoleColor color)
        {
            this._peso = peso;
            this._color = color;
        }
        #endregion

        #region Metodos
        protected virtual string FrutaToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Peso: " + this._peso);
            sb.Append("Color: " + this._color);

            return sb.ToString();
        }

        public static int OrdenarPorPesoAsc(Fruta una, Fruta dos)
        {
            int retorno = 0;
            
            if (una._peso == dos._peso)
            {
                retorno = 0;
            }
            if (una._peso < dos._peso)
            {
                retorno = 1;
            }
            if (una._peso > dos._peso)
            {
                retorno = -1;
            }

            return retorno;
        }

        public static int OrdenarPorPesoDesc(Fruta uno, Fruta dos)
        {
            return OrdenarPorPesoAsc(dos, uno);
        }
        #endregion

    }
}
