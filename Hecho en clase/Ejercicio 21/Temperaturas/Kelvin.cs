using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    public class Kelvin
    {
        private double cantidad;//cantidad o grados ¿?¿¿¿??

        public Kelvin(double cant)
        {
            this.cantidad = cant;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static implicit operator Kelvin(double cant)
        {
            return new Kelvin(cant);
        }

        //F = K * 9/5 – 459.67
        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit(k.GetCantidad() * 9 / 5 - 459.67);
        }

        public static explicit operator Celsius(Kelvin c)
        {
            return new Celsius(c.GetCantidad() - 273.15);
        }

        ////////////////////////////////////////////////////
        public static Kelvin operator +(Kelvin k, Fahrenheit f)
        {
            return new Kelvin(k.GetCantidad() + ((Kelvin)f).GetCantidad());
        }

        public static Kelvin operator +(Kelvin k, Celsius c)
        {
            return new Kelvin(k.GetCantidad() + ((Kelvin)c).GetCantidad());
        }

        public static Kelvin operator -(Kelvin k, Fahrenheit f)
        {
            return new Kelvin(k.GetCantidad() - ((Kelvin)f).GetCantidad());
        }

        public static Kelvin operator -(Kelvin k, Celsius c)
        {
            return new Kelvin(k.GetCantidad() - ((Kelvin)c).GetCantidad());
        }

        public static bool operator ==(Kelvin k,Fahrenheit f)
        {
            Kelvin aux = (Kelvin)f;
            if (k.GetCantidad() == aux.GetCantidad())
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            Kelvin aux = (Kelvin)f;
            if (k.GetCantidad() != aux.GetCantidad())
            {
                return true;
            }

            return false;
        }

        public static bool operator ==(Kelvin k, Celsius c)
        {
            Kelvin aux = (Kelvin)c;
            if (k.GetCantidad() == aux.GetCantidad())
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Kelvin k, Celsius c)
        {
            Kelvin aux = (Kelvin)c;
            if (k.GetCantidad() != aux.GetCantidad())
            {
                return true;
            }

            return false;
        }

    }
}
