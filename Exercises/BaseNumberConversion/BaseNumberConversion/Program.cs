using System;
using System.Linq;

namespace BaseNumberConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you would like to convert:");            
            if(!int.TryParse(Console.ReadLine(), out int input))
            {
                Console.WriteLine("Invalid input, try again!");
                Main(args);
            }
            
            Console.WriteLine("What type of number is this? Binary, Octal, or Decimal?");
            string type = Console.ReadLine();

            if (type.ToLower() == "binary")
            {
                Console.WriteLine($"The octal number is {ToOctal.BinToOct(input)}");
                Console.WriteLine($"The decimal number is {ToDecimal.BinToDec(input)}");
            }
            else if (type.ToLower() == "octal")
            {
                Console.WriteLine($"The binary number is {ToBinary.OctToBin(input)}");
                Console.WriteLine($"The decimal number is {ToDecimal.OctToDec(input)}");
            }
            else if (type.ToLower() == "decimal")
            {
                Console.WriteLine($"The binary number is {ToBinary.DecToBin(input)}");
                Console.WriteLine($"The octal number is {ToOctal.DecToOct(input)}");
            }
            else
            {
                Console.WriteLine("Invalid input, try again!");
                Main(args);
            }
            Main(args);
        }
    }
}
