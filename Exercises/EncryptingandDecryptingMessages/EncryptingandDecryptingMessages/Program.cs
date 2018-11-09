using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EncryptingandDecryptingMessages
{
    class Program
    {
        public static StringBuilder cleantext = new StringBuilder();
        public static StringBuilder cleankey = new StringBuilder();
        public static StringBuilder encoded = new StringBuilder();
        public static StringBuilder decoded = new StringBuilder();
        public static bool key;
        public static int userchoice;

        static void Main(string[] args)
        {
            START:

            Menu();

            key = false;
            Console.WriteLine("Enter message to encrypt/decrypt:");
            Clean(Console.ReadLine());
           
            Console.WriteLine("Enter encryption key:");
            key = true;
            Clean(Console.ReadLine());
            
            if (userchoice == 1 || userchoice == 3 || userchoice == 5)
                Console.WriteLine($"Encrypted message: {Encrypt()}");
            else
                Console.WriteLine($"Decoded message: {Decode()}");

            goto START;
        }

        private static string Decode()
        {
            if (userchoice == 6)
            {
                cleankey.Append(cleantext);
            }

            for (int i = 0; i < cleantext.Length; i++)
            {
                char cc = (char)(cleantext[i] - (cleankey[i % cleankey.Length] - 64));
                if (cc < 65)
                    cc = (char)(cc + 26);
                decoded.Append(cc);
            }
            return decoded.ToString();
        }

        private static string Encrypt()
        {            
            if (userchoice == 5)
            {
                cleankey.Append(cleantext);
            }

            for (int i = 0; i < cleantext.Length; i++)
            {
                char cc = (char)(cleantext[i] + (cleankey[i % cleankey.Length] - 64));
                if (cc > 90)
                    cc = (char)(cc - 26);
                encoded.Append(cc);
            }
            return encoded.ToString();
        }

        private static void Clean(string v)
        {
            foreach (char c in v)
            {
                if ((int)c > 96 && (int)c < 123)
                {
                    if (key == true)
                    {
                        cleankey.Append((char)(c - 32));
                    }
                    else
                        cleantext.Append((char)(c - 32));
                }
                else if (c > 64 && c < 91)
                {
                    if (key == true)
                    {
                        cleankey.Append(c);
                    }
                    else
                        cleantext.Append(c);
                }
                else
                    continue;
            }
        }

        private static void Menu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1- Single character encyrption");
            Console.WriteLine("2- Single character decyrption");
            Console.WriteLine("3- Multi character encyrption");
            Console.WriteLine("4- Multi character decyrption");
            Console.WriteLine("5- Continuous character encyrption");
            Console.WriteLine("6- Continuous character decyrption");

            userchoice = int.Parse(Console.ReadLine());
        }

    }
}
