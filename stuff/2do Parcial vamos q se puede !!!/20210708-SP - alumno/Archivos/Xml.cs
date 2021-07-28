using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        /// <summary>
        /// Guarda datos en un archivo XML
        /// </summary>
        /// <param name="ruta">Ruta en la que se guardará el archivo</param>
        /// <param name="info">Información a guadar</param>
        /// <returns>True si se pudo guardar, sino se lanza una excepción</returns>
        public bool Guardar(string ruta, T info)
        {
            bool seGuardo;
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(ruta, System.Text.Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(writer, info);
                }
                seGuardo = true;
            }
            catch (Exception e)
            {
                throw new ArchivoInvalidoException();
            }

            return seGuardo;
        }

        /// <summary>
        /// Lee un archivo de tipo XML
        /// </summary>
        /// <param name="ruta">Ruta de la cuál se lee el archivo</param>
        /// <returns>La información contenida en el archivo</returns>
        public T Leer(string ruta)//esto no anda no se q onda
        {
            try
            {
                using (XmlTextReader reader = new XmlTextReader(ruta))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));

                    T info = (T)ser.Deserialize(reader);
                    return info;
                }
            }
            catch (Exception)
            {
                throw new ArchivoInvalidoException();
            }
        }

    }
}
