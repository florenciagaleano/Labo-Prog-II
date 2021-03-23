using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class ValidarRespuesta
    {
        public static bool ValidarS_N(char c)
        {
            if(char.ToUpper(c) != 'S')
            {
                return false;
            }

            return true;
        }
    }
}
