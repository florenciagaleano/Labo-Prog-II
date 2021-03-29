using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BibliotecaBoligrafo;

/*a. La cantidad máxima de tinta para todos los bolígrafos será de 100. Generar una constante
en el Boligrafo llamada cantidadTintaMaxima donde se guardará dicho valor.*/
/*e. En el Main, crear un bolígrafo de tinta azul (ConsoleColor.Blue) y una cantidad inicial de tinta
de 100 y otro de tinta roja (ConsoleColor.Red) y 50 de tinta.*/

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo bAzul = new Boligrafo(100,ConsoleColor.Blue);
            Boligrafo bRojo = new Boligrafo(50, ConsoleColor.Red);

            /*g. Utilizar todos los métodos en el Main.
            h. Al utilizar Pintar, si corresponde, se deberá dibujar por pantalla con el color de dicho
            bolígrafo.*/
            string param;
            string param2;

            bAzul.Pintar(10,out param);
            bRojo.Pintar(12,out param2);

            Console.WriteLine("{0}",param);
            Console.WriteLine("{0}", param2);

            Console.ReadKey();

        }
    }
}
