using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio, fin;

            Console.WriteLine("Ingrese un año de inicio: ");
            int.TryParse(Console.ReadLine(),out inicio);

            Console.WriteLine("Ingrese un año de fin: ");
            int.TryParse(Console.ReadLine(), out fin);

            for(;inicio<=fin; inicio++)
            {
                if( inicio % 4 == 0 && (inicio % 100 != 0 || (inicio % 100 == 0 && inicio % 400 ==0) )) 
                {
                    Console.WriteLine("El año {0} es bisiesto",inicio);
                }
            }

            Console.ReadKey();
            
        }
    }
}
