using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Biblioteca
{
    public class SerializadorXML<T>
    {
        private readonly string ruta;

        public SerializadorXML(string ruta)
        {
            this.ruta = ruta;
        }
        public void Guardar(T objeto)
        {
            //el using hace el close
            using (XmlTextWriter xmlWriter = new XmlTextWriter(ruta, Encoding.UTF8))
            {
                XmlSerializer serializar = new XmlSerializer(typeof(T));

                serializar.Serialize(xmlWriter, objeto);

                //xmlWriter.Close();
            }
        }

        public T Leer()
        {
            using (XmlTextReader xmlWriter = new XmlTextReader(ruta))
            {
                XmlSerializer serializar = new XmlSerializer(typeof(T));

                return (T) serializar.Deserialize(xmlWriter);
            }
        }
    }
}
