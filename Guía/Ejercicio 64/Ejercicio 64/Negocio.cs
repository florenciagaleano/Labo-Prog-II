using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_64
{
    public class Negocio
    {
        private Caja caja1;
        private Caja caja2;
        private List<string> clientes;

        public Caja Caja1
        {
            get
            {
                return this.caja1;
            }
        }

        public Caja Caja2
        {
            get
            {
                return this.caja2;
            }
        }

        public List<string> Clientes
        {
            get
            {
                return this.clientes;
            }
        }

        public void AsignarCaja()
        {
            Console.WriteLine("Asignando cajas...");
            foreach (string item in this.clientes)
            {
                if(caja1.FilaClientes.Count < caja2.FilaClientes.Count)
                {
                    caja1.FilaClientes.Add(item);
                }
                else
                {
                    caja2.FilaClientes.Add(item);
                }

                Thread.Sleep(1000);

            }

        }

        public Negocio(Caja c1,Caja c2)
        {
            this.clientes = new List<string>();
            caja1 = c1;
            caja2 = c2;
        }
    }
}
