using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private static double cotizRespectoDolar;
        private double cantidad;


        static Euro()
        {
            Euro.cotizRespectoDolar = 1.08;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static explicit operator Dolar(Euro e)//osea si hago euro casteando a Dolar
        {
            return new Dolar(e.cantidad * Dolar.GetCotizacion());
        }

        public static explicit operator Pesos(Euro e)
        {
            return new Pesos(e.cantidad * Pesos.GetCotizacion());
        }

        public static implicit operator Euro(double e)
        {
            return new Euro(e);
        }

        //SOBRECARGAS DE OPERADORES

        public static bool operator ==(Euro e, Dolar d)
        {
            if (d == e)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(d == e);
        }

        public static bool operator ==(Euro e,Pesos p)
        {
            if (e == p)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }

        public static bool operator ==(Euro e1,Euro e2)
        {
            if (e1 == e2)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            Euro aux = (Euro)e;
            Euro retorno = new Euro(e.cantidad - aux.cantidad);
            return retorno;
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            Euro aux = (Euro)p;
            Euro retorno = new Euro(e.cantidad - aux.cantidad);
            return retorno;
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            Euro aux = (Euro)e;
            Euro retorno = new Euro(e.cantidad + aux.cantidad);
            return retorno;
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            Euro aux = (Euro)p;
            Euro retorno = new Euro(e.cantidad + aux.cantidad);
            return retorno;
        }
    }
}
