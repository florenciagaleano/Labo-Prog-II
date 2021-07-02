using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Biblioteca
{
    public class Archivador
    {
        private readonly string ruta;

        public Archivador(string ruta)
        {
            this.ruta = ruta;
        }

        public void Guardar(string texto)
        {
            StreamWriter writer = null;
            try
            {
                if(!File.Exists(this.ruta))
                {
                    File.Create(this.ruta);
                }
                writer = new StreamWriter(this.ruta);
                writer.WriteLine("Hola!!" + texto);
            }
            finally
            {

                if(writer!=null)
                {
                    writer.Close();
                }
            }
        }

        public string Leer()
        {
            StreamReader reader = null;
            try
            {
                if (!File.Exists(this.ruta))
                {
                    File.Create(this.ruta);
                }
                reader = new StreamReader(this.ruta);
                return reader.ReadToEnd();
            }
            finally
            {

                if (reader != null)
                {
                    reader.Close();
                }
            }
        }
    }
}
