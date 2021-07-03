using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CheatSheet
{
    public class Xml//ctores publicos por defectos y propiedades publicas
    {
        string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public void Guardar(object p)//paso elobj a guardar
        {
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(ruta, System.Text.Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(object));
                    ser.Serialize(writer, p);
                }
                Console.WriteLine("Objeto 'P' serializado...");

                Console.WriteLine("Deserealizando al objeto 'P'...");


                using (XmlTextReader reader = new XmlTextReader(ruta))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(object));

                    object aux = new object();

                    aux = ser.Deserialize(reader);//esto se caseta!!!

                    Console.WriteLine(aux.ToString());

                }
            }
            catch (Exception)
            {

            }
        }

        public object Leer()
        {
            try
            {
                using (XmlTextReader reader = new XmlTextReader(ruta))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(object));

                    return ser.Deserialize(reader);
                }
            }
            catch (Exception e)
            {
                
            }

            return null;
        }
    }
}
