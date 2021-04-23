using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formas;

namespace Clase_11
{
    class Program
    {
        //a.Crear una lista de figuras.
        //b.Agregar a la lista una figura de cada tipo.
        //c.Recorrer la lista mostrando el resultado del método Dibujar, el área y el perímetro de cada figura
        //(con una precisión de 2 decimales), y el tipo(GetType()).
        static void Main(string[] args)
        {
            List<Figura> l = new List<Figura>();

            Rectangulo r = new Rectangulo(4, 2);
            l.Add(r);
            Circulo o = new Circulo(5.2);
            l.Add(o);
            Cuadrado c = new Cuadrado(6.56461);
            l.Add(c);

            foreach (Figura item in l)
            {
                Console.WriteLine($"============= Figura {l.IndexOf(item) + 1} ==============");
                Console.WriteLine(item.Dibujar());
                Console.WriteLine("Perimetro: {0}",item.CalcularPerimetro().ToString("#.##"));
                Console.WriteLine("Area: {0}", item.CalcularSuperficie().ToString("#.##")); 
                Console.WriteLine(item.GetType());
                Console.WriteLine(" ");
            }

            Console.ReadKey();
        }
    }
}
