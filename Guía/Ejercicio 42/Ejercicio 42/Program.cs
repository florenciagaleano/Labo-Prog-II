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
            try
            {
                OtraClase x = new OtraClase();
                x.MetodoDeInstancia();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

                //if(!object.ReferenceEquals(ex.InnerException,null))
                //{
                Exception e = ex.InnerException;
                while (!object.ReferenceEquals(e, null))
                    {
                        
                        Console.WriteLine(e.Message);//voy imprimiendo todas las excepciones ya entendi
                    e = e.InnerException;
                    }
                //}

            }

            Console.ReadKey();
        }
    }
}
