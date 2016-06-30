using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SegundoParcial
{
    [XmlInclude(typeof(Manzana))]
    public class Manzana:Fruta,ISerializable
    {

        #region Atributo
        public double precio;
        #endregion

        #region Propiedades
        public override bool TieneCarozo
        {
            get { return true; }
        }

        public string Tipo
        {
            get { return "Manzana"; }
        }

        public string RutaArchivo
        {
            get
            {
                return "Manzana.Xml";
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        #endregion
        
        #region Constructor
        public Manzana() { }

        public Manzana(float peso, ConsoleColor color, double precio):base(peso,color)
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

        public override string ToString()
        {
            return this.FrutaToString();
        }

        public bool SerializarXML()
        {

            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter(this.RutaArchivo,Encoding.UTF8))
                {
                    XmlSerializer serializar = new XmlSerializer(typeof(Manzana));
                    serializar.Serialize(escritor, this);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
        #endregion
  

       
    }
}
