using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class OtraClase
    {
        static void Metodo()
        {
            try
            {
                new MiClase(10);
            }catch(MiExcepcion miEx)
            {
                throw new Exception("Mi ex de otraClase", miEx);
            }
        }
    }
}
