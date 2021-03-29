using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca19;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador sum = new Sumador();
            Sumador sum2 = new Sumador(5);

            Console.WriteLine("{0} {1} operador int explicito:{2}",sum.Sumar(2,3),sum2.Sumar("Hola","Mundo"),(int)sum);
            Console.WriteLine("{0} {1}",sum+sum2,sum|sum2);

            Console.ReadKey();
        }
    }
}
