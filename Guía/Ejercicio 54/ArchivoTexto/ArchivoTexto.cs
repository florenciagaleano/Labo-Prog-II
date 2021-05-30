using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArchivoTexto
{
    public class ArchivoTexto
    {
        public void Guardar(string ruta,string texto)
        {
           if(!File.Exists(ruta))
            {
                File.Create(ruta);
            }

            StreamWriter writer = new StreamWriter(ruta);
            writer.WriteLine(texto);
            writer.Close();
        }

        public string Leer(string ruta, string texto)
        {
            StreamReader reader = null;
            try
            {
               reader  = new StreamReader(ruta);

            }catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }finally
            {
                if(reader != null)
                {
                    reader.Close();
                }
            }

            return reader.ReadToEnd();
        }
    }
}
