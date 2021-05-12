using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_48
{
    class Program
    {
        static void Main(string[] args)
        {
            Recibo r = new Recibo(5000);
            Factura f = new Factura(1000);

            Contabilidad<Factura,Recibo> c = new Contabilidad<Factura,Recibo>();

            c=c + r;
            c = c + f;

            Console.WriteLine(c.ToString());
            Console.ReadKey();
        }
    }
}
