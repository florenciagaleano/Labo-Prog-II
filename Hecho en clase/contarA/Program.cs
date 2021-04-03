using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contarA
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            Console.WriteLine("Ingrese una palabra");
            cadena = Console.ReadLine();
            int cantidad = ContarLetras(cadena, 'a');

            Console.Clear();

            Console.WriteLine("Cant ingresada: "+ cantidad);//el 1ero no tenia lo de las mayus
            cantidad = ContarLetras2(cadena, 'a');
            Console.WriteLine(cantidad);
            cantidad = ContarLetras3(cadena, 'a');
            Console.WriteLine(cantidad);

            Console.ReadKey();
        }

        static int ContarLetras(string texto,char letra)
        {
            int contador = 0;
            
            for(int i=0 ; i<texto.Length ; i++)
                if( texto.ToCharArray()[i] == letra)
                    contador++;

            return contador;
        }

        static int ContarLetras2(string texto, char letra)
        {
            int contador = 0;

            foreach (char item in texto)
            {
                if (Char.ToUpper(item) == Char.ToUpper(letra))
                    contador++;
            }

            return contador;
        }

        static int ContarLetras3(string texto, char letra)
        {
            int contador = 0;
            int i = 0;

            do
            {
                if (Char.ToUpper(texto.ToCharArray()[i]) == Char.ToUpper(letra)) contador++;
                i++;
            } while (texto.Length < i);

            return contador;
        }
    }
}
