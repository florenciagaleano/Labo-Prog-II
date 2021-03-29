using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private static double cotizRespectoDolar;
        private double cantidad;

        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;//poruqe es dolar kj
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;   
        }
        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        /// <summary>
        /// retorna el valor en euros de determinada cant de dolares (d)
        /// </summary>
        /// <param name="d">dolar(es) cuya cantidad sera pasada a euros</param>
        public static explicit operator Euro (Dolar d)
        {
            return new Euro(d.cantidad * Euro.GetCotizacion());
        }

        /// <summary>
        /// retorna el valor en pesos de determinada cant de dolares (d)
        /// </summary>
        /// <param name="d">dolar(es) cuya cantidad sera pasada a pesos</param>
        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.cantidad * Pesos.GetCotizacion());
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        //SOBRECARGAS DE OPERADORES
        public static bool operator ==(Dolar d,Euro e)
        {
            if (d == e)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            if (d == p)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }

        public static bool operator ==(Dolar d, Dolar d2)
        {
            if (d == d2)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Dolar d, Dolar d2)
        {
            return !(d == d2);
        }

        public static Dolar operator -(Dolar d,Euro e)
        {
            Dolar aux = (Dolar)e;
            Dolar retorno = new Dolar(d.cantidad - aux.cantidad);
            return retorno;
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar aux = (Dolar)p;
            Dolar retorno = new Dolar(d.cantidad - aux.cantidad);
            return retorno;
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar aux = (Dolar)e;
            Dolar retorno = new Dolar(d.cantidad + aux.cantidad);
            return retorno;
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar aux = (Dolar)p;
            Dolar retorno = new Dolar(d.cantidad + aux.cantidad);
            return retorno;
        }
    }
}
