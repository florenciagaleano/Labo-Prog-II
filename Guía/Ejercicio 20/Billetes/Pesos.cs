using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        private static double cotizRespectoDolar;
        private double cantidad;

        static Pesos()
        {
            Pesos.cotizRespectoDolar = 66;
        }
        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public static double GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.cantidad * Dolar.GetCotizacion());
        }

        public static explicit operator Euro(Pesos p)
        {
            return new Euro(p.cantidad * Euro.GetCotizacion());
        }

        public static implicit operator Pesos(double p)
        {
            return new Pesos(p);
        }

        //SOBRECARGAS DE OPERADORES
        public static bool operator ==(Pesos p, Dolar d)
        {
            if (p == d)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            if (p == e)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return !(e == p);
        }

        public static bool operator ==(Pesos p1,Pesos p2)
        {
            if (p1 == p2)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            Pesos aux = (Pesos)d;
            Pesos retorno = new Pesos(p.cantidad - aux.cantidad);
            return retorno;
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            Pesos aux = (Pesos)e;
            Pesos retorno = new Pesos(p.cantidad - aux.cantidad);
            return retorno;
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            Pesos aux = (Pesos)d;
            Pesos retorno = new Pesos(p.cantidad + aux.cantidad);
            return retorno;
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            Pesos aux = (Pesos)e;
            Pesos retorno = new Pesos(p.cantidad + aux.cantidad);
            return retorno;
        }
    }
}
