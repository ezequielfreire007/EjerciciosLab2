using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SegundoParcial
{
    public class Platano:Fruta
    {
        #region Atributo
        public double precio;
        #endregion

        #region Propiedades
        public override bool TieneCarozo
        {
            get { return false; }
        }

        public string Tipo
        {
            get { return "Platano"; }
        }
        #endregion

        #region Constructores
        public Platano(float peso, ConsoleColor color, double precio):base(peso,color)
        {
            this.precio = precio;
        }
        #endregion

        #region Metodos
        protected override string FrutaToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.FrutaToString());
            sb.Append("Precio: " + this.precio);

            return sb.ToString();
        }
        #endregion

        
    }
}
