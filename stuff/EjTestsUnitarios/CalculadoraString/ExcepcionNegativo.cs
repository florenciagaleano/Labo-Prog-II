using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraString
{
    public class ExcepcionNegativo : Exception
    {
        public ExcepcionNegativo(string neg)
        {
            new Exception(neg);
        }
    }
}
