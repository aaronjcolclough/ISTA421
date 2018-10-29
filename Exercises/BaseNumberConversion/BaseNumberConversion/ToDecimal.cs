using System;
using System.Collections.Generic;
using System.Text;

namespace BaseNumberConversion
{
    class ToDecimal
    {
        public static string BinToDec(int binnum)
        {
            int tmp = 0;
            for (int i = 0; binnum != 0; i++)
            {
                tmp += binnum % 10 * (int)Math.Pow(2, i);
                binnum = binnum / 10;
            }
            return tmp.ToString();
        }
        public static string OctToDec(int octnum)
        {
            int tmp = 0;
            for (int i = 0; octnum != 0; i++)
            {
                tmp += octnum % 10 * (int)Math.Pow(8, i);
                octnum = octnum / 10;
            }
            return tmp.ToString();
        }
    }
}
