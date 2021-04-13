using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo team = new Equipo(10, "Bokita");
            Jugador j1 = new Jugador(123, "Tevez");
            Jugador j2 = new Jugador(456, "Mati");
            Jugador j3 = new Jugador(789, "Flor");
            Jugador j4 = new Jugador(456, "Barbi");

            if(team + j1)
            {
                Console.WriteLine(j1.MostrarDatos());
            }else
            {
                Console.WriteLine($"No se agrego{j1.MostrarDatos()}"); 
            }

            if (team + j2)
            {
                Console.WriteLine(j2.MostrarDatos());
            }
            else
            {
                Console.WriteLine($"No se agrego{j2.MostrarDatos()}");
            }

            if (team + j3)
            {
                Console.WriteLine(j3.MostrarDatos());
            }
            else
            {
                Console.WriteLine($"No se agrego{j3.MostrarDatos()}");
            }

            if (team + j4)//este no se deberia agregar
            {
                Console.WriteLine(j4.MostrarDatos());
            }
            else
            {
                Console.WriteLine($"No se agrego:\n{j4.MostrarDatos()}");
            }

            Console.ReadKey();
        }
    }
}
