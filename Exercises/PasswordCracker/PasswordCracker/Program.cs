using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace PasswordCracker
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrFill();
            Console.WriteLine("Please enter a 5 character password for your profile:");
            pass = Console.ReadLine();
            Stopwatch clock = new Stopwatch();
            clock.Start();
            Cracker(pass);
            clock.Stop();
            Console.WriteLine(clock.Elapsed);
        }
        public static string pass;
        public static string[] chars = new string[95];

        private static void ArrFill()
        {
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = ((char)(i + 32)).ToString();
            }            
        }        
             
        private static void Cracker(string pass)
        {
            Parallel.For(0, chars.Length, w =>
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    for (int k = 0; k < chars.Length; k++)
                    {
                        for (int l = 0; l < chars.Length; l++)
                        {
                            for (int m = 0; m < chars.Length; m++)
                            {
                                //string tmp = chars[w] + chars[j] + chars[k] + chars[l] + chars[m];
                                if (chars[w] + chars[j] + chars[k] + chars[l] + chars[m] == pass)
                                {
                                    Console.WriteLine($"Password is {chars[w] + chars[j] + chars[k] + chars[l] + chars[m]}");
                                    break;
                                }
                            }
                        }
                    }
                }
            });
        }
    }
}
