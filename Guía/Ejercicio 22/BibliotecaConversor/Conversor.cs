using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaConversor
{
    public class Conversor
    {
        public static string DecimalBinario(int num)
        {
            string bin = "";
            int res;

            while (num > 0)
            {
                res = num % 2;
                num = num / 2;
                bin = Convert.ToString(res) + "" + bin;
            }
            return bin;
        }

        public static int BinarioDecimal(string bin)
        {
            int num = 0;
            double numASumar = 0;

            for (int i = 0; i < bin.Length; i++)
            {

                if (bin[i] == '1')
                {
                    int len = bin.Length - 1 - i;
                    numASumar += Math.Pow(2, len);//los voy sumando here
                }
            }

            num = (int)numASumar;

            return num;
        }
    }
}
