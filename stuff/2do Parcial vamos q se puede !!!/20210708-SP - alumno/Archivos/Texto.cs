using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        /// <summary>
        /// Guarda datos en un archivo de texto
        /// </summary>
        /// <param name="ruta">Ruta en la que se guardará el archivo</param>
        /// <param name="info">Información a guadar</param>
        /// <returns>True si se pudo guardar, sino se lanza una excepción</returns>
        public bool Guardar(string ruta, string info)
        {
            bool seGuardo = false;
            try
            {
                using (StreamWriter writer = new StreamWriter(ruta))
                {
                    if (!File.Exists(ruta))
                    {
                        File.Create(ruta);
                    }

                    writer.WriteLine(info.ToString());
                    seGuardo = true;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Problema al guardar en formato texto. ", e);
            }

            return seGuardo;
        }

        /// <summary>
        /// Lee un archivo de texto
        /// </summary>
        /// <param name="ruta">Ruta de la cuál se lee el archivo</param>
        /// <returns>La información contenida en el archivo</returns>
        public string Leer(string ruta)
        {
            try
            {
                using (StreamReader reader = new StreamReader(ruta))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Problemas para leer el archivo en formato XML. ", e);
            }
        }
    }
}
