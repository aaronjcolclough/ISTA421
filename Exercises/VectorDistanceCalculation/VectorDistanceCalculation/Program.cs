using System;

namespace VectorDistanceCalculation
{
    class Program
    {
        public static double[] shortest = { 0, 0, double.PositiveInfinity };
        public static Random rnd = new Random();
        public static int[,] vectors = new int[1000, 3];

        static void Main(string[] args)
        {
            fillarr();
            dist(vectors);
            Console.WriteLine($"The shortest distance is between Point {shortest[0]} " +
                $"and Point {shortest[1]} with a Distance of {shortest[2]}");
        }

        private static void fillarr()
        {
            for (int i = 0; i < vectors.GetLength(0); i++)
            {
                for (int j = 0; j < vectors.GetLength(1); j++)
                {
                    vectors[i, j] = rnd.Next(1, 1001);
                }
            }
        }

        private static void dist(int[ , ] vectors)
        {
            for (int i = 0; i < vectors.GetLength(0) - 1; i++)
            {
                for (int j = i + 1; j < vectors.GetLength(0); j++)
                {
                    int x = (int)Math.Pow(vectors[i, 0] - vectors[j, 0], 2);
                    int y = (int)Math.Pow(vectors[i, 1] - vectors[j, 1], 2);
                    int z = (int)Math.Pow(vectors[i, 2] - vectors[j, 2], 2);
                    double Distance = Math.Sqrt(x + y + z);
                    //Console.WriteLine($"distance between {i} and {j} is {Distance}");
                    
                    if (Distance < shortest[2])
                    {
                        shortest[0] = i;
                        shortest[1] = j;
                        shortest[2] = Distance;
                    }
                    else
                        continue;
                }
            }
        }
    }
}
