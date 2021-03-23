using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int alto;

            Console.Write("Ingrese un num entero positivo (alto piramide): ");
            int.TryParse(Console.ReadLine(),out alto);

            alto = alto * 2;

            for (int i = alto; i >= 0; i--)
            {
                if (((alto - i) % 2) != 0)
                {
                    // Recorro el ancho del piso de la pirámide
                    for (int j = 0; j < i / 2; j++)
                    {
                        Console.Write(" ");
                    }
                    // Recorro el ancho del piso de la pirámide
                    for (int j = 0; j < alto - i; j++)
                    {
                        Console.Write("*");
                    }
                    // Salto de línea
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
