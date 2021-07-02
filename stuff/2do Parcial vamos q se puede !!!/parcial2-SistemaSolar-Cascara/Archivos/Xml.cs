using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IFile<T>
    {
        public string GetDirectoryPath
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
            }
        }

        public bool FileExists(string nombreArchivo)
        {
            return File.Exists(this.GetDirectoryPath + nombreArchivo);
        }

        public void Guardar(string nombreArchivo, T objeto)
        {
            this.Guardar(nombreArchivo, objeto, Encoding.UTF8);

        }

        public void Guardar(string nombreArchivo, T objeto, Encoding encoding)
        {
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(nombreArchivo, encoding))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(writer, objeto);
                }
            }
            catch (Exception e)
            {
                throw new ErrorArchivosException("Problemas para guardar el archivo en formato XML. ", e);
            }

        }

        public bool Leer(string nombreArchivo, out T objeto)
        {
            return this.Leer(nombreArchivo, out objeto, Encoding.UTF8);
        }

        public bool Leer(string nombreArchivo, out T objeto, Encoding encoding)
        {
            bool ret = false;

            try
            {
                using (XmlTextReader reader = new XmlTextReader(nombreArchivo))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    objeto = (T)ser.Deserialize(reader);
                    ret = true; 
                }
            }
            catch (Exception e)
            {
                throw new ErrorArchivosException("Problemas para leer el archivo en formato XML. ", e);
            }

            return ret;
        }

    }

}
