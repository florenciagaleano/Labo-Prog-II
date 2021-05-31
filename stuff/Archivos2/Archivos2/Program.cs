using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreFile;
            string rutaFile;

            try
            {
                nombreFile = "ArchivoEjemplo.txt";
                rutaFile = AppDomain.CurrentDomain.BaseDirectory + nombreFile;//devuelve la ruta del bin del proyecto
                //rutaFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                using(StreamWriter sw = new StreamWriter(rutaFile))//no hace falta el close
                {
                    sw.WriteLine("a ver que onda");
                }
            }catch(Exception)
            {

            }

        }
    }
}
