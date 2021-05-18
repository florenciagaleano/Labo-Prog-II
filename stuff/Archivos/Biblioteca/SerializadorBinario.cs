using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Biblioteca
{
    public class SerializadorBinario<T>
    {

        private readonly string ruta;

        public SerializadorBinario(string ruta)
        {
            this.ruta = ruta;
        }
        public void Guardar(T objeto)
        {
            //el using hace el close
           
            BinaryFormatter b = new BinaryFormatter();
            using (Stream stream = new FileStream(this.ruta, FileMode.Create))
            {
                b.Serialize(stream, objeto);
            }

        }

        public T Leer()
        {
            BinaryFormatter b = null;
            Stream stream = null;
            try
            {
                b = new BinaryFormatter();
                stream = new FileStream(this.ruta, FileMode.Create);
                return (T)b.Deserialize(stream);
            }
            finally
            {
                stream.Close();
            }
        }


        }
}
