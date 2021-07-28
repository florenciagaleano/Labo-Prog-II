using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Serializadora
    {
        public static bool Guardar(Persona p)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Personas.xml";
                using (XmlTextWriter xw = new XmlTextWriter(path,Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Persona));
                    ser.Serialize(xw, p);
                    return true;
                }
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
