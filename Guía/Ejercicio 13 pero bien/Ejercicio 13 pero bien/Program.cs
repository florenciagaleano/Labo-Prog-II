using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca_Conversor;

/*Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
    string DecimalBinario(int). Convierte un número de entero a binario.
    int BinarioDecimal(string). Convierte un número binario a entero.
    NOTA: no utilizar los atajos del lenguaje, hacerlo mediante estructuras repetitivas y de control.*/

namespace Ejercicio_13_pero_bien
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string bin = "";

            Console.Write("Ingrese entero a convertir a binario: ");
            int.TryParse(Console.ReadLine(), out num);
            Console.WriteLine("El numero {0} en binario es {1}", num, Conversor.DecimalBinario(num));

            Console.ReadKey();

        }
    }
}
