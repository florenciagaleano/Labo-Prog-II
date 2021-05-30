using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class Program
    {
        static void Main(string[] args)
        {
            ArchivoTexto a = new ArchivoTexto();

            try
            {
                OtraClase x = new OtraClase();
                x.MetodoDeInstancia();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

                Exception e = ex.InnerException;
                while (!object.ReferenceEquals(e, null))
                {

                    //Console.WriteLine(e.Message);//voy imprimiendo todas las excepciones ya entendi
                    a.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + (DateTime.Now.Year).ToString()+ (DateTime.Now.Month).ToString()+(DateTime.Now.Day).ToString() + "-" + DateTime.Now.Hour.ToString() + DateTime.Now.Hour.ToString() + ".txt", e.Message);
                    e = e.InnerException;
                }
            }


            Console.WriteLine(a.Leer(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + (DateTime.Now.Year).ToString() + (DateTime.Now.Month).ToString() + (DateTime.Now.Day).ToString() + "-" + DateTime.Now.Hour.ToString() + DateTime.Now.Hour.ToString() + ".txt"));

            //se rompe
            Console.ReadKey();
        }
    }
}
