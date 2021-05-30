using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    public class Cartuchera2
    {
        public List<Boligrafo> listaB;
        public List<Lapiz> listaL;

        public Cartuchera2()
        {
            this.listaB = new List<Boligrafo>();
            this.listaL = new List<Lapiz>();
        }

        public bool ProbarElementos(List<IAcciones> elementos)
        {
            bool r = false;

            foreach (Lapiz item in this.listaL)
            {
                if (item.UnidadesDeEscritura < 0)
                {
                    item.Recargar(20);
                    return false;
                }
                else
                {
                    item.Escribir("F");
                    Console.WriteLine(item);
                    r = true;
                }
            }

            foreach (Boligrafo item in this.listaB)
            {
                if (item.UnidadesDeEscritura < 0)
                {
                    item.Recargar(20);
                    return false;
                }
                else
                {
                    item.Escribir("F");
                    Console.WriteLine(item);
                    r = true;
                }
            }

            return r;
        }

    }
}
