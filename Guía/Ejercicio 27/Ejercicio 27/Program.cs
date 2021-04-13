using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Realizar el ejercicio anterior pero esta vez con las siguientes colecciones: Pilas, Colas y Listas.

namespace Ejercicio_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = 20;
            List <int> lista = new List<int>();
            Queue<int> colaPositivos = new Queue<int>();
            Queue<int> colaNegativos = new Queue<int>();
            Stack<int> pilaPositivos = new Stack<int>();
            Stack<int> pilaNegativos = new Stack<int>();

            Random random = new Random();

            Console.WriteLine("LISTA ORIGINAL");
            for (int i = 0; i < len; i++)
            {
                lista.Add(random.Next());
              //  colaInt.Enqueue(random.Next());
              //  pilaInt.Push(random.Next());
            }

            Console.WriteLine("Lista postivos");
            lista.Sort(Program.ordenarNumeros);
            foreach (int item in lista)
            {
                if(item > 0)
                {
                    Console.WriteLine(item);
                }
            }

            lista.Sort(Program.ordenarNumeros);
            foreach (int item in lista)
            {
                if (item > 0)
                {
                    Console.WriteLine(item);
                }
            }


            //no me estaria saliendo :(

            Console.ReadKey();

        }

        private static int ordenarNumeros(int n1,int n2)
        {
            int criterio = 0;

            if(n1 > n2)
            {
                criterio = -1;
            }else if(n1 < n2)
            {
                criterio = 1;
            }

            return criterio;
        }
       
    }
}
