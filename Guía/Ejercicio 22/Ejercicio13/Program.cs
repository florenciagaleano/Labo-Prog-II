using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaConversor;

namespace Ejercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int num;
            string bin;

            Console.Write("Ingrese entero a convertir a binario: ");
            int.TryParse(Console.ReadLine(), out num);
            Console.WriteLine("El numero {0} en binario es {1}", num, Conversor.DecimalBinario(num));

            Console.Write("Ingrese binario a convertir a entero: ");
            bin = Console.ReadLine();
            Console.WriteLine("El numero {0} en decimal es {1}", bin, Conversor.BinarioDecimal(bin));*/

            NumeroBinario b= "11000";//no pongo el new por la sobrecarga;)
            NumeroDecimal d= 3;

            string sumB = b + d;
            string resB = b - d;

            Console.WriteLine("{0}", sumB);//11011 (27)
            Console.WriteLine("{0}", resB);//10101 (21)
            Console.WriteLine("11000 == 3: {0}", b == d);//false
            Console.WriteLine("11000 != 3: {0}", b != d);//true

            Console.WriteLine(":::::::::::::::::");

            NumeroBinario b2 = "100011";//35
            NumeroDecimal d2 = 41;

            Console.WriteLine("{0}", d2+b2);//76
            Console.WriteLine("{0}", d2-b2);//6
            Console.WriteLine("100011 == 41: {0}", b == d);//false
            Console.WriteLine("100011 != 41: {0}", b != d);//true

            Console.ReadKey();
        }
    }
}
