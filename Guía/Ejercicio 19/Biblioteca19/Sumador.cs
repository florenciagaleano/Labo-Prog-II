using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca19
{
    public class Sumador
    {
        private int cantidadSumas;
        /*Crear dos constructores:
        i. Sumador(int) inicializa cantidadSumas en el valor recibido por parámetros.
        ii. Sumador() inicializa cantidadSumas en 0. Reutilizará al primer constructor.
        c. Generar una conversión explícita que retorne cantidadSumas.
        d. Sobrecargar el operador + (suma) para que puedan sumar cantidadSumas y retornen un long
        con dicho valor.
        e. Sobrecargar el operador | (pipe) para que retorne True si ambos sumadores tienen igual
        cantidadSumas.*/
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador()
            : this(0)
        {

        }

        public long Sumar(long a, long b)
        {
            return a + b;
        }

        public string Sumar(string a, string b)
        {
            return a + b;
        }

        //[acceso] static explicit operator nombreTipo(Tipo a)
        public static explicit operator int(Sumador x)
        {
            return x.cantidadSumas;
        }

        public static long operator + (Sumador x, Sumador y)
        {
            return (int)x + (int)y;

        }

        public static bool operator |(Sumador x, Sumador y)
        {
            if((int)x == (int)y)
            {
                return true;
            }

            return false;
        }

    }
}
