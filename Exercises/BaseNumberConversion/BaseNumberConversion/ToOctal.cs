using System;
using System.Collections.Generic;
using System.Text;

namespace BaseNumberConversion
{
    class ToOctal
    {
        public static string DecToOct(int num)
        {
            string octnum = "";
            while (num != 0)
            {
                octnum = string.Format($"{num % 8}{octnum}");
                num = num / 8;
            }
            return octnum;
        }
        
        public static string BinToOct(int binnum)
        {
            string octnum = "";
            while (binnum != 0)
            {
                int binnum2 = binnum % 1000;
                int tmp = 0;
                for (int i = 0; i < 3; i++)
                {
                    tmp += binnum2 % 10 * (int)Math.Pow(2, i);                    
                    binnum2 = binnum2 / 10;
                }
                octnum = string.Format($"{tmp}{octnum}");
                binnum = binnum / 1000;
            }            
            return octnum;
        }
        
    }
}
