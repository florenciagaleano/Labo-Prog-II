using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaConversor;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string bin;

            Console.Write("Ingrese entero a convertir a binario: ");
            int.TryParse(Console.ReadLine(), out num);
            Console.WriteLine("El numero {0} en binario es {1}", num, Conversor.DecimalBinario(num));

            Console.Write("Ingrese binario a convertir a entero: ");
            bin = Console.ReadLine();
            Console.WriteLine("El numero {0} en decimal es {1}", bin, Conversor.BinarioDecimal(bin));

            Console.ReadKey();
        }
    }
}
