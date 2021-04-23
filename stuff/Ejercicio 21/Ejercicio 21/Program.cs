using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Temperaturas;

/*Crear tres clases: Fahrenheit, Celsius y Kelvin. Realizar un ejercicio similar al anterior, teniendo encuenta que:
  ♥ F = C * (9/5) + 32     ♥ C = (F-32) * 5/9     ♥ F = K * 9/5 – 459.67     ♥ K = (F + 459.67) * 5/9  */

namespace Ejercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fahrenheit f = 98.6;
            Console.WriteLine("{0}", ((Celsius) f).GetCantidad()); prueba truchita*/
            Celsius tC = 25;
            Fahrenheit tF = 32;//0 ceslius
            Kelvin tK = 273.15;//0 celsius

            Console.WriteLine("{0}",(tC+tK).GetCantidad());//ok
            Console.WriteLine("{0}", (tF - tC).GetCantidad());//revisar, no se si da bien ¿?¿?

            Console.ReadKey();
        }
    }
}
