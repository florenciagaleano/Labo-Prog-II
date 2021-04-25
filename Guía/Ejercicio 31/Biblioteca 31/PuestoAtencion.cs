using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_31
{
    public class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1,
            Caja2,
        }

        int numeroActual;
        Puesto puesto;

        private static int NumeroActual
        {
            get
            {
                return ++this.numeroActual;
            }
        }

        


    }
}
