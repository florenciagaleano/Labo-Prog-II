using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*i. double + (NumeroDecimal, NumeroBinario)
ii. double - (NumeroDecimal, NumeroBinario)
iii. bool == (NumeroDecimal, NumeroBinario)
iv. bool != (NumeroDecimal, NumeroBinario)*/

namespace BibliotecaConversor
{
    public class NumeroDecimal
    {
        private double numero;

         public NumeroDecimal(double num)
        {
            this.numero = num;
        }

        public static explicit operator double(NumeroDecimal n)
        {
            return n.numero;
        }

        public static implicit operator NumeroDecimal(double num)//me ahorro el new I guess
        {
            return new NumeroDecimal(num);
        }

        public static double operator +(NumeroDecimal numD,NumeroBinario numB)
        {
            double binPasado = Conversor.BinarioDecimal((string)numB);
            return (double)numD + binPasado;
        }

        public static double operator -(NumeroDecimal numD, NumeroBinario numB)
        {
            double binPasado = Conversor.BinarioDecimal((string)numB);
            return (double)numD - binPasado;
        }

        public static bool operator ==(NumeroDecimal numD, NumeroBinario numB)
        {
            double binPasado = Conversor.BinarioDecimal((string)numB);
            if(binPasado == (double) numD)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(NumeroDecimal numD, NumeroBinario numB)
        {
            double binPasado = Conversor.BinarioDecimal((string)numB);
            if (binPasado != (double)numD)
            {
                return true;
            }

            return false;
        }
    }
}
