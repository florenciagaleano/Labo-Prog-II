using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected string dni;

        protected Persona(string nombre, string apellido, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }
    }
}
