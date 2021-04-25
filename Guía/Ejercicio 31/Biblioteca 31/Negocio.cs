using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_31
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue <Cliente> clientes;
        string nombre;
            
        public Negocio()
        {
            this.clientes = new Queue<Cliente>();
        }

        public Negocio(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
