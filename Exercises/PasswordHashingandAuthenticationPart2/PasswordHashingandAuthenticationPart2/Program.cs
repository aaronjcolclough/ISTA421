using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace PasswordHashingandAuthenticationPart2
{
    class Program
    {
        public static Dictionary<string, string> userInfo = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            int userchoice = 9; 

            while (userchoice != 0)
            {
                if (userchoice == 1)
                {
                    Util.setNewUser();
                    userchoice = Util.printUI();
                }
                else if (userchoice == 2)
                {
                    Console.WriteLine(Util.getUser());
                    userchoice = Util.printUI();
                }
                else if (userchoice == 3)
                {
                    Util.printUsers();
                    userchoice = Util.printUI();
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again.");
                    userchoice = Util.printUI();
                }
            }
            Environment.Exit(0);
        }
    }
}
