using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class SerializarXML<T> : IArchivos<T>
    {
        public bool Guardar(string rutaArchivo, T objeto)
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter(rutaArchivo, Encoding.UTF8);
                XmlSerializer ser = new XmlSerializer(typeof(T));
                ser.Serialize(writer, objeto);
                writer.Close();
                return true;
            }
            catch (Exception innerException)
            {
                throw new ErrorArchivoException(innerException);
            }
        }

        public T Leer(string rutaArchivo)
        {
            Votacion ret = default;
            try
            {
                using (XmlTextReader xmlWriter = new XmlTextReader(rutaArchivo))
                {
                    XmlSerializer serializar = new XmlSerializer(typeof(Votacion));

                    return (T)serializar.Deserialize(xmlWriter);
                }
                
            }
            catch (Exception e) {

                throw new ErrorArchivoException(e);

            }
        }
    }
}
