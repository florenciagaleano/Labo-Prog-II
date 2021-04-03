using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Temperaturas
{
    public class Fahrenheit
    {
        private double cantidad;//cantidad o grados ¿?¿¿¿??

        public Fahrenheit(double cant)
        {
            this.cantidad = cant;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static implicit operator Fahrenheit(double cant)
        {
            return new Fahrenheit(cant);
        }

        //C = (F-32) * 5/9
        public static explicit operator Celsius(Fahrenheit cant)
        {
            return new Celsius((cant.GetCantidad() - 32) * 5 / 9);
        }

        //K = (F + 459.67) * 5/9
        public static explicit operator Kelvin(Fahrenheit cant)
        {
            return new Kelvin((cant.GetCantidad() + 459.67) * 5 / 9);
        }

        public static Fahrenheit operator +(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(f.GetCantidad() + ((Fahrenheit)c).GetCantidad());
        }

        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.GetCantidad() + ((Fahrenheit)k).GetCantidad());
        }

        public static Fahrenheit operator -(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(f.GetCantidad() - ((Fahrenheit)c).GetCantidad());
        }

        public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.GetCantidad() - ((Fahrenheit)k).GetCantidad());
        }

        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            Fahrenheit aux = (Fahrenheit)c;
            if(f.GetCantidad() == aux.GetCantidad())
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            Fahrenheit aux =(Fahrenheit) c;
            if (f.GetCantidad() != aux.GetCantidad())
            {
                return true;
            }

            return false;
        }

        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            Fahrenheit aux = (Fahrenheit) k;
            if (f.GetCantidad() == aux.GetCantidad())
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            Fahrenheit aux = (Fahrenheit)k;
            if (f.GetCantidad() != aux.GetCantidad())
            {
                return true;
            }

            return false;
        }
    }
}
