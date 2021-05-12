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
                throw new MiExcepcion("Mi excepcion♥");
            }catch(MiExcepcion e)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }
    }
}
