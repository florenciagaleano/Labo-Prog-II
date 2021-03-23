using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            int min = 0;
            int max = 0;
            int acumulador = 0;
            int promedio;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese nums entre -100 y 100: ");

                valor = int.Parse(Console.ReadLine());
                while (!Validacion.Validar(valor, -100, 100))
                {
                    Console.WriteLine("Valor fuera de rango, reingrese numero: ");
                    valor = int.Parse(Console.ReadLine());
                }

                max = valor;
                min = valor;

                if (max < valor)
                {
                    max = valor;
                }

                if (min > valor)
                {
                    min = valor;
                }

                acumulador += valor;

            }

            promedio = acumulador / 10;

            Console.WriteLine("Minimo: {0}   Maximo:{1}   Promedio:{2}", min, max, promedio);
            Console.ReadKey();
        }


    }
}
