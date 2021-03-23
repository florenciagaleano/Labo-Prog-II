using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7_DateTimeNow
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime cumple;
            int edad;

            Console.Write("Ingrese fecha de nacimiento (dd/mm/aaaa): ");
            cumple = DateTime.Parse(Console.ReadLine());

            // edad = DateTime.Today - cumple;
            edad = DateTime.Today.Year - cumple.Year;
            if (DateTime.Today.Month < cumple.Month || (DateTime.Today.Month == cumple.Month && DateTime.Today.Day < cumple.Day))
                edad--;

            Console.WriteLine("Usted tiene {0}",edad);

            Console.ReadKey();
        }
    }
}
