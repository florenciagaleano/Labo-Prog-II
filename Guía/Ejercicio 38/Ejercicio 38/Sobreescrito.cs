using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//a.Sobrescribir el método ToString para que retorne "¡Este es mi método ToString
//sobrescrito!".
//b. Sobrescribir el método Equals para que retorne true si son del mismo tipo (objetos de la
//misma clase), false en caso contrario.
//c. Sobrescribir el método GetHashCode para que retorne el número 1142510187.

namespace Ejercicio_38
{
    public abstract class Sobreescrito
    {
        protected string miAtributo;

        public Sobreescrito(string miAtributo)
        {
            this.miAtributo = miAtributo;
        }
        public override string ToString()
        {
            return "Este es mi metodo ToString sobrecargado";
        }

        public override bool Equals(object obj)
        {
            return obj is Sobreescrito;
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
