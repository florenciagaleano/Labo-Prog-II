using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    public class Celsius
    {
        private double cantidad;//cantidad o grados ¿?¿¿¿??

        public Celsius(double cant)
        {
            this.cantidad = cant;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static implicit operator Celsius(double cant)
        {
            return new Celsius(cant);
        }

        //F = C* (9/5) + 32
        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit(c.GetCantidad() * (9 / 5) + 32);
        }

        //K = C + 273.15
        public static explicit operator Kelvin(Celsius c)
        {
            return new Kelvin(c.GetCantidad() + 273.15);
        }

        public static Celsius operator +(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.GetCantidad() + ((Celsius)f).GetCantidad());
        }

        public static Celsius operator +(Celsius c, Kelvin k)
        {
            return new Celsius(c.GetCantidad() + ((Celsius)k).GetCantidad());
        }

        public static Celsius operator -(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.GetCantidad() - ((Celsius)f).GetCantidad());
        }

        public static Celsius operator -(Celsius c, Kelvin k)
        {
            return new Celsius(c.GetCantidad() - ((Celsius)k).GetCantidad());
        }

        public static bool operator ==(Celsius c,Fahrenheit f)
        {
            Celsius aux = (Celsius)f;
            if (c.GetCantidad() == aux.GetCantidad())
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            Celsius aux = (Celsius)f;
            if (c.GetCantidad() != aux.GetCantidad())
            {
                return true;
            }

            return false;
        }

        public static bool operator ==(Celsius c, Kelvin k)
        {
            Celsius aux = (Celsius)k;
            if (c.GetCantidad() == aux.GetCantidad())
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Celsius c, Kelvin k)
        {
            Celsius aux = (Celsius)k;
            if (c.GetCantidad() != aux.GetCantidad())
            {
                return true;
            }

            return false;
        }
    }
}
