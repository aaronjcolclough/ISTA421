using System;
using System.Linq;
using System.Collections;

namespace StatisticalFunctions
{
    class Program
    {
        public static Random rnd = new Random();

        static void Main(string[] args)
        {
            int[] nums = new int[rnd.Next(10, 1001)];
            FillArr(nums);
                
            double mean = Math.Round(Mean(nums), 2);
            Console.WriteLine($"Mean:{mean}");

            double median = Math.Round(Median(nums), 2);
            Console.WriteLine($"Median:{median}");

            double sd = Math.Round(StanDev(nums, mean), 2);
            Console.WriteLine($"Standard Deviation:{sd}");

            double mad = Math.Round(MedAb(nums, median), 2);
            Console.WriteLine($"Median Absolute Deviation:{mad}");

            double skew = Math.Round(Skew(nums, mean, sd), 2);
            Console.WriteLine($"Skewness:{skew}");

            double kurt = Math.Round(Kurt(nums, mean, sd), 2);
            Console.WriteLine($"Kurtosis:{kurt}");
        }

        private static double Kurt(int[] nums, double mean, double sd)
        {
            return (Math.Pow(nums.Sum(x => x - mean), 4) / Math.Pow(sd, 4)) / (nums.Length - 3);
        }

        private static double Skew(int[] nums, double mean, double sd)
        {
            return (Math.Pow(nums.Sum(x => x - mean), 3) / Math.Pow(sd, 3)) / nums.Length;
        }

        private static double MedAb(int[] nums, double median)
        {
            int[] tmp = (nums.Select(x => (int)Math.Abs(x - median)).ToArray());
            Array.Sort(tmp);            
            return Median(tmp);
        }

        private static double StanDev(int[] nums, double mean)
        {
            return Math.Sqrt(Math.Pow(nums.Sum(x => x - mean), 2) / nums.Length);
        }

        private static double Median(int[] nums)
        {
            int m = nums.Length / 2;
            return (nums[(1 + m) - 1] + nums[(nums.Length - m) - 1]) / 2.0;
        }

        private static double Mean(int[] nums)
        {
            return nums.Sum() / nums.Length; 
        }

        private static void FillArr(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(0, 1001);
            }
            Array.Sort(nums);
        }
    }
}
