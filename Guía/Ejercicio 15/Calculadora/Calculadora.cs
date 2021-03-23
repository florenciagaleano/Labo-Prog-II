using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCalculadora
{
    public class Caclculadora
    {
        public static float Calcular(int num1,int num2,char operacion)
        {
            float resultado = 0;

            switch(operacion)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    if(Validar(num2))
                    {
                        resultado = num1 / num2;
                    }
                    break;
            }
            return resultado;
        }
        private static bool Validar(int num)
        {
            if(num != 0)
            {
                return true;
            }

            return false;
        }
    }
}
