using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Utilizar Diccionarios(Dictionary<string, int>) para realizar un contador de palabras, recorriendo el
//texto palabra por palabra se deberá lograr que si se trata de una nueva palabra, se la agregará al
//diccionario e inicializar su contador en 1, caso contrario se deberá incrementar dicho contador.
//Ordenar los resultados de forma descendente por cantidad de apariciones de cada palabra.
//Informar mediante un MessageBox el TOP 3 de palabras con más apariciones.

namespace Ejercicio_28
{ 
    class Contador
    {
        private Dictionary<string, int> texto;
        private List<string> palabras;

        public Contador()
        {
            texto = new Dictionary<string, int>();
            palabras = new List<string>();
        }

        public void ContarPalabras(string txt)
        {
            palabras.AddRange(txt.Split(' '));//addrange pq voy a agregar muchas palabras ?

            foreach (string item in palabras)
            {
                if(!texto.ContainsKey(item))
                {
                    texto.Add(item, 1);

                }else
                {
                    texto[item] += 1;//voy aumentando la cant de veces que aparecio lapalabra ;)
                    //texto[key palabra] subo la cant de veces que aparece, uso el value como contador I guess
                }
            }

        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;

            while( i < 3)
            {
                foreach (KeyValuePair<string, int> palabra in texto)
                {
                    if(texto.Values.Max() == palabra.Value)
                    {
                        sb.AppendLine($" {palabra.Key}   {palabra.Value}");
                        i++;
                    }
                }
            }

            return sb.ToString();
        }
    }
}
