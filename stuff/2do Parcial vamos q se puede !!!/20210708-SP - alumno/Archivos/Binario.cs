using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Archivos
{
    public class Binario<T> : IArchivo<T>
    {
        public bool Guardar(string ruta,T objetoAGuardar)
        {
            bool ret = false;
            string file_name = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "SerializacionBinaria.dat";

            BinaryFormatter ser = new BinaryFormatter();

            FileStream fs = new FileStream(file_name, FileMode.Create);
            try
            {
                ser.Serialize(fs, objetoAGuardar);
                ret = true;
            }
            catch (Exception)
            {
                throw new ArchivoInvalidoException();
            }
            finally
            {
                fs.Close();
            }
            return ret;
        }

        public T Leer(string ruta)//devuelve el objeto leido
        {
            try
            {
                using (FileStream fileStream = File.Open(ruta, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    return (T)formatter.Deserialize(fileStream);
                }

            }
            catch (Exception)
            {
                throw new ArchivoInvalidoException();
            }

        }
    }
}
