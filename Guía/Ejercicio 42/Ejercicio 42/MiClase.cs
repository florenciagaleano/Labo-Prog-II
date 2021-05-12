using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class MiClase
    {
        public MiClase(string str)
        {
            try
            {
                MiClase.MetodoEstatico();
            }catch(Exception e)
            {
                throw new Exception("1er ctor",e);
            }
        }

        public MiClase(int num)
        {
            try
            {
                new MiClase("Hola");
            }catch(UnaExcepcion e)
            {
                throw new Exception("2do ctor", e);
            }
        }

        static void MetodoEstatico()
        {
            throw new DivideByZeroException();
        }
    }
}
