using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    public class Cartuchera1
    {
        public List<IAcciones> lista;

        public Cartuchera1()
        {
            this.lista = new List<IAcciones>();
        }

        public bool ProbarElementos(List<IAcciones> elementos)
        {
            foreach(IAcciones item in this.lista)
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
                    return item.Recargar(1);
                }
            }

            return false;
        }
    }
}
