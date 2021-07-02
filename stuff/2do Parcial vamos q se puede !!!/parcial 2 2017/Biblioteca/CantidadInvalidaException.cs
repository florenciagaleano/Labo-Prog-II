using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CantidadInvalidaException : Exception
    {
        public CantidadInvalidaException()
            :base("Debe ingresar una cantidad mayor a 0")
        {

        }
    }
}
