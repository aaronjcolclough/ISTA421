using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace PasswordHashingandAuthenticationPart2
{
    class Util
    {
        public static int printUI()
        {
            Console.WriteLine("PASSWORD AUTHENTICATION SYSTEM");
            Console.WriteLine("Select an option:");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Enter new user and password");
            Console.WriteLine("2 - Authenticate user and password");
            Console.WriteLine("3 - Print all users");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static void setNewUser()
        {
            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();
            if (Program.userInfo.ContainsKey(username))
            {
                Console.WriteLine("Username not avaiable, try again.");
                setNewUser();
            }
            else
            {
                Console.WriteLine("Enter password:");
                string hashpass = HashPass(Console.ReadLine());
                Program.userInfo.Add(username, hashpass);
            }
        }
        private static string HashPass(string plainpass)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] hashValue = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(plainpass));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashValue.Length; i++)
                {
                    builder.Append(hashValue[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public static string getUser()
        {
            Console.WriteLine("Enter username:");
            string usercheck = Console.ReadLine();
            
            if (!Program.userInfo.ContainsKey(usercheck))
            {
                Console.WriteLine("Username not found, try again.");
                getUser();
            }
            else
            {
                Console.WriteLine("Enter password:");
                string passcheck = HashPass(Console.ReadLine());
                string tmp = "";
                Program.userInfo.TryGetValue(usercheck, out tmp);
                if (!passcheck.Equals(tmp))
                {
                    Console.WriteLine("Invalid password, try again.");
                    getUser();
                }
            }
            return "User Authenticated";
        }
        public static void printUsers()
        {
            foreach (KeyValuePair<string, string> user in Program.userInfo)
            {
                Console.WriteLine(user);
            }
        }
    }
}
