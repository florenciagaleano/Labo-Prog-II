using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class OtraClase
    {
        public void MetodoDeInstancia()
        {
            try
            {
                new MiClase(10);
            }
            catch (MiExcepcion miEx)
            {
                throw new UnaExcepcion("Mi ex de otraClase", miEx);
            }
        }
    }
}
