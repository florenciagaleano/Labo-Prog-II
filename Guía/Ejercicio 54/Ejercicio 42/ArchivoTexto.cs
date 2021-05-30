using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio_42
{
    public class ArchivoTexto
    {
        public ArchivoTexto()
        { 
        }

        public void Guardar(string ruta,string texto)
        {
            StreamWriter writer = null;

          try
            {
                if (!File.Exists(ruta))
                {
                    File.Create(ruta);
                }

                writer = new StreamWriter(ruta);
                writer.WriteLine(texto);
            }catch(IOException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                if(writer != null)
                {
                    writer.Close();
                }
            }
        }

        public string Leer(string ruta)
        {
            StreamReader reader = null;
            string ret = string.Empty;
            try
            {
               reader  = new StreamReader(ruta);
                ret = reader.ReadToEnd(); 

            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }finally
            {
                if(reader != null)
                {
                    reader.Close();
                }
            }

            return ret;
        }
    }
}
