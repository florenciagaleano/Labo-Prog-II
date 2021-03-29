using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Geometria;

namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto v1 = new Punto(4, 3);
            Punto v2 = new Punto(7, 2);
            Rectangulo r = new Rectangulo(v1, v2);

            Console.WriteLine("Area:{0}   Perimetro:{1}",r.GetArea(),r.GetPerimetro());

            Console.ReadKey();
        }
    }
}
