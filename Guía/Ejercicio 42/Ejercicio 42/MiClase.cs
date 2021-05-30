using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class MiClase
    {
        public MiClase()//instancia
        {
            try
            {
                new MiClase(10);
            }
            catch (UnaExcepcion e)
            {
                throw new MiExcepcion("2do ctor", e);
            }
        }

        public MiClase(int num)
        {
            try
            {
                MiClase.MetodoEstatico();
            }
            catch (DivideByZeroException e)
            {

                throw new UnaExcepcion("Miclase",e);
            }
        }

        static void MetodoEstatico()
        {
            throw new DivideByZeroException();
        }
    }
}
