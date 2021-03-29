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
        private int numero;

         public NumeroDecimal(int num)
        {
            this.numero = num;
        }

        public static explicit operator int(NumeroDecimal n)
        {
            return n.numero;
        }

        public static implicit operator NumeroDecimal(int num)//me ahorro el new I guess
        {
            return new NumeroDecimal(num);
        }

        public static int operator +(NumeroDecimal numD,NumeroBinario numB)
        {
            int binPasado = Conversor.BinarioDecimal((string)numB);
            return (int)numD + binPasado;
        }

        public static int operator -(NumeroDecimal numD, NumeroBinario numB)
        {
            int binPasado = Conversor.BinarioDecimal((string)numB);
            return (int)numD - binPasado;
        }

        public static bool operator ==(NumeroDecimal numD, NumeroBinario numB)
        {
            int binPasado = Conversor.BinarioDecimal((string)numB);
            if(binPasado == (int) numD)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(NumeroDecimal numD, NumeroBinario numB)
        {
            int binPasado = Conversor.BinarioDecimal((string)numB);
            if (binPasado != (int)numD)
            {
                return true;
            }

            return false;
        }
    }
}
