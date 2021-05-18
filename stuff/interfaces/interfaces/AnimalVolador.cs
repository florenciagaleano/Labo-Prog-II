using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public abstract class AnimalVolador
    {
        protected string nombre;

        protected AnimalVolador(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
