using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a1 = new Alumno("Flor", "Galeano", 4523);
            Alumno a2 = new Alumno("Hugo", "Paz", 1235);

            a1.Estudiar(9, 8);
            a2.Estudiar(6, 7);

            a1.CalcularFinal();
            a2.CalcularFinal();

            Console.WriteLine(a1.Mostrar());
            Console.WriteLine(a2.Mostrar());

            Console.ReadKey();
        }
    }
}
