using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Vacuna
    {
        string nombre;
        public Vacuna(string nombre)
        {
            this.nombre = nombre;
        }

        public string getName()
        {
            return this.nombre;
        }
    }
}
