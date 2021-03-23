using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarRespuesta
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ValidarS_N(char c)
            {
                if(char.ToUpper(c) != 'S')
                {
                    return false;
                }

                return true;
            }
        }
    }
}
