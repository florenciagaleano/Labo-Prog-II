using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaConversor
{
    public class Conversor
    {
        public static string DecimalBinario(double num)
        {
            string bin = "";
            double res;

            while (num > 0)
            {
                res = num % 2;
                num = num / 2;
                bin = Convert.ToString(res) + "" + bin;
            }
            return bin;
        }

        public static double BinarioDecimal(string bin)
        {
            double num = 0;
            double numASumar = 0;

            for (int i = 0; i < bin.Length; i++)
            {

                if (bin[i] == '1')
                {
                    double len = bin.Length - 1 - i;
                    numASumar += Math.Pow(2, len);//los voy sumando here
                }
            }

            num = (double)numASumar;

            return num;
        }
    }
}
