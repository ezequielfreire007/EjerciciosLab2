using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace EjercicioNro61
{
    public class ManejadorArvhicos
    {
        public static bool GuardarTexto(string mensaje)
        {
            try
            {
                using (StreamWriter escritor = new StreamWriter("logErrores.txt", true))
                {
                    escritor.Write(DateTime.Now);
                    escritor.Write(" -- ");
                    escritor.Write(mensaje);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            
        }

        public static bool SerializarLista(List<Tren> lista)
        {
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("Lista.Xml",Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Tren>));
                    ser.Serialize(escritor, lista);                    
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool DeserializarLIsta()
        {
            try
            {
                List<Tren> listaAux;

                using (XmlTextReader lector = new XmlTextReader("Lista.Xml"))
                {
                    XmlSerializer des = new XmlSerializer(typeof(List<Tren>));
                    listaAux = (List<Tren>)des.Deserialize(lector);

                    foreach (Tren item in listaAux)
                    {
                        if (item is TrenElectrico)
                        {
                            using (StreamWriter escritor = new StreamWriter("MisTrenes.txt",true))
                            {
                                Console.WriteLine(((TrenElectrico)item).ToString());
                                escritor.WriteLine(((TrenElectrico)item).ToString());
                            }
                        }
                        else
                        {
                            using (StreamWriter escritor = new StreamWriter("MisTrenes.txt", true))
                            {
                                Console.WriteLine(((TrenBala)item).ToString());
                                escritor.WriteLine(((TrenBala)item).ToString());
                            }
                        }
                    }
                    
                }
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine();
                return false;
            }
        }
    }

    
}
