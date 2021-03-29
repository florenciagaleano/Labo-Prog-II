using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*i. string + (NumeroBinario, NumeroDecimal)
ii. string - (NumeroBinario, NumeroDecimal)
iii. bool == (NumeroBinario, NumeroDecimal)
iv. bool != (NumeroBinario, NumeroDecimal)*/

namespace BibliotecaConversor
{
    public class NumeroBinario
    {
        private string numero;

        public NumeroBinario(string str)
        {
            this.numero = str;
        }

        public static string operator +(NumeroBinario numBin,NumeroDecimal numDec)
        {
            int n1 = Conversor.BinarioDecimal((string)numBin);
            int res = n1 + (int) numDec;

            return Conversor.DecimalBinario(res);
        }

        public static string operator - (NumeroBinario numBin, NumeroDecimal numDec)
        {
            int n1 = Conversor.BinarioDecimal((string)numBin);
            int res = n1 - (int)numDec;

            return Conversor.DecimalBinario(res);
        }

        public static bool operator ==(NumeroBinario numBin, NumeroDecimal numDec)
        {
            int n1 = Conversor.BinarioDecimal((string)numBin);
            if(n1 == (int) numDec)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(NumeroBinario numBin, NumeroDecimal numDec)
        {
            int n1 = Conversor.BinarioDecimal((string)numBin);
            if (n1 != (int)numDec)
            {
                return true;
            }

            return false;
        }

        public static explicit operator string(NumeroBinario n)
        {
            return n.numero;
        }

        public static implicit operator NumeroBinario(string bin)
        {
            return new NumeroBinario(bin);
        }
    }
}
