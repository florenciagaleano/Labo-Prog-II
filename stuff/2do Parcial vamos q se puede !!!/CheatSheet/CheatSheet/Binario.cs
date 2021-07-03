using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace CheatSheet
{
    //ACORDARME DE QUE CLASES A SERIALIZAR VAN CON LA ETIQUETA [Serializable] y el ctor x defecto
    public class Binario
    {
        public void Guardar(object  objetoAGuardar)
        {
            string file_name = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "SerializacionBinaria.dat";

            BinaryFormatter ser = new BinaryFormatter();

            FileStream fs = new FileStream(file_name, FileMode.Create);
            try
            {
                ser.Serialize(fs, objetoAGuardar);
                
            }
            catch (Exception)
            {
                

            }
            finally
            {
                fs.Close();
            }

        }

        public object Leer()//devuelve el objeto leido
        {
            string file_name = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "SerializacionBinaria.dat";//ruta, puede ser por param
            FileStream fst = new FileStream(file_name, FileMode.Open);
            BinaryFormatter ser = new BinaryFormatter();
            object aux = null;

            try
            {

                aux = new object();

                //aux = (Dato)ser.Deserialize(fst);
                aux = ser.Deserialize(fst);

                Console.WriteLine(aux.ToString());
                Console.ReadLine();
            }
            catch (SerializationException e)
            {
                
            }
            finally
            {
                fst.Close();
            }

            return aux;
        }

    }

}
