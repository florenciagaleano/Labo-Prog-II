using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BibliotecaCalculadora;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta,
            multiplicación y división). Para ello se le debe pedir al usuario que ingrese dos números y la
            operación que desea realizar (pulsando el caracter +, -, * ó /).
            El usuario decidirá cuándo finalizar el programa.
            Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
            a. Calcular (público): Recibirá tres parámetros, el primer número, el segundo número y la
            operación matemática. El método devolverá el resultado de la operación.
            b. Validar (privado): Recibirá como parámetro el segundo número. Este método se debe
            utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá
            TRUE si el número es distinto de CERO.*/
            int num1, num2;
            char operacion;

            Console.Write("Ingrese 1er operando: ");
            int.TryParse(Console.ReadLine(),out num1);
            Console.Write("Ingrese 2do operando: ");
            int.TryParse(Console.ReadLine(), out num2);

            Console.Write("Ahora ingrese el tipo de operacion (+,-,*,/):");
            char.TryParse(Console.ReadLine(), out operacion);
            while(operacion != '+' && operacion != '-' && operacion != '*' && operacion != '/')
            {
                Console.Write("Ingrese tipo de operacion valida (+,-,*,/):");
                char.TryParse(Console.ReadLine(), out operacion);
            }

            Console.Clear();
            Console.WriteLine("{0} {1} {2} = {3}",num1,operacion,num2,Caclculadora.Calcular(num1,num2,operacion));
            Console.ReadKey();
        }
    }
}
