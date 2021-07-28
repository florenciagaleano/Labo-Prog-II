using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ArchivoInvalidoException : Exception
    {
        public ArchivoInvalidoException()
            :base("Archivo o ruta de archivo invalida")
        {

        }
    }
}
