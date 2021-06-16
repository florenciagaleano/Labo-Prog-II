using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsYT
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(MetodoSaludo);
            Thread t2 = new Thread(MetodoSaludo);

            t1.Start();
            t2.Start();

            Console.WriteLine("Hola desde thread 1!!");
            Thread.Sleep(500);
            Console.WriteLine("Hola desde thread 1!!");
            Console.WriteLine("Hola desde thread 1!!");
            Console.WriteLine("Hola desde thread 1!!");
            Console.WriteLine("Hola desde thread 1!!");

           // MetodoSaludo();
        }

        static void MetodoSaludo()
        {
            Console.WriteLine("Hola desde thread 2!!");
            Thread.Sleep(500);
            Console.WriteLine("Hola desde thread 2!!");
            Console.WriteLine("Hola desde thread 2!!");
            Console.WriteLine("Hola desde thread 2!!");
            Console.WriteLine("Hola desde thread 2!!");

            Console.ReadKey();
        }
    }
}
