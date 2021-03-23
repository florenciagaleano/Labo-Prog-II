using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;

            Console.Title = "Ejercicio 5";

            Console.Write("Ingrese un numero: ");
            int.TryParse(Console.ReadLine(), out valor);

            for(int centro=1; centro<valor; centro++)
            {
                int suma1 = 0;
                int suma2 = 0;
                
                for(int i=0; i<centro; i++)
                {
                    suma1 += i;
                }

                for(int j=centro+1; j<=suma1; j++)
                {
                    if ((suma1 == suma2) || (suma2 > suma1))
                        break;

                    suma2 += j;
                }

                if(suma1==suma2)
                {
                    Console.WriteLine("{0} es un centro numerico",centro);
                }
            }

            Console.ReadKey();
        }
    }
}
