using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos) distintos de cero de
forma aleatoria utilizando la clase Random.
a. Mostrar el vector tal como fue ingresado
b. Luego mostrar los positivos ordenados en forma decreciente.
c. Por último, mostrar los negativos ordenados en forma creciente.*/

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = 20;
            int[] arrayNums = new int[len];
            Random random = new Random();

            Console.WriteLine("    LISTA ORIGINAL");
            for(int i=0; i<len; i++)
            {
                arrayNums[i] = random.Next(-100, 100);//asigno nums entre -100 y 100
                Console.WriteLine(arrayNums[i]);
            }

            Array.Sort(arrayNums, Program.OrdenAscendente);//ascendente
            Console.WriteLine("    NEGATIVOS");
            for(int i=0; i<len; i++)
            {
                if(arrayNums[i] < 0)
                {
                    Console.WriteLine(arrayNums[i]);
                }
            }

            Array.Sort(arrayNums, Program.OrdenDescendente);//descendente
            Console.WriteLine("    POSITIVOS");
            for (int i = 0; i < len; i++)
            {
                if (arrayNums[i] > 0)
                {
                    Console.WriteLine(arrayNums[i]);
                }
            }

            Console.ReadKey();

        }

        public static int OrdenDescendente(int n1, int n2)
        {
            return n2 - n1;
        }
        public static int OrdenAscendente(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}
