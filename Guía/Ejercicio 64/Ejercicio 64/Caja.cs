using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_64
{
    public class Caja
    {
        private List<string> filaClientes;

        public List<string> FilaClientes
        {
            get
            {
                return this.filaClientes;
            }
        }


        public Caja()
        {
            this.filaClientes = new List<string>();
        }

        public void AtenderCaja()
        {
            foreach (string item in this.filaClientes)
            {
                Console.WriteLine($"{item} {Thread.CurrentThread.Name}");
                Thread.Sleep(2000);
            }
        }

    }
}
