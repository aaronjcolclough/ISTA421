using System;
using System.Collections.Generic;
using System.Text;

namespace BaseNumberConversion
{
    class ToBinary
    {
        public static string DecToBin(int num)
        {
            string binnum = "";            
            while (num != 0)
            {
                binnum = string.Format($"{num % 2}{binnum}");
                num = num / 2;
            }
            return binnum;
        }
        public static string OctToBin(int octnum)
        {
            string binnum = "";
            while (octnum != 0)
            {
                int octnum2 = octnum % 10;
                for (int i = 0; i < 3; i++)
                {
                    binnum = string.Format($"{octnum2 % 2}{binnum}");
                    octnum2 = octnum2 / 2;
                }
                octnum = octnum / 10;                
            }
            return binnum;
        }
    }
}
