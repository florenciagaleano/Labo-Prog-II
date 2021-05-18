using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Interfaces;

namespace Ejercicio_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Fragil f = new Fragil(2, "A1B2N3", "Jamaica", "Aruba", 1500, true);
            Pesado p = new Pesado(58, "F1F2F3", "Argentina", "China", 28000, false);

            GestionImpuestos g = new GestionImpuestos();

            g.recaudoImpuestosAduana.Add(f);
            g.recaudoImpuestosAfip.Add(p);

            Console.WriteLine(f.Informacion());
            Console.WriteLine(p.Informacion());

            Console.ReadKey();
        }
    }
}
