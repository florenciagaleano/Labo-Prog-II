using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Calculadora
    {
        public static float Calcular(int num1,int num2,char operacion)
        {
            float resultado = 0; ;

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
                default:
                    break;
            }

            return resultado;
        }

        private static bool Validar(int num2)
        {
            if(num2 == 0)
            {
                return false;
            }

            return true;
        }
    }
}
