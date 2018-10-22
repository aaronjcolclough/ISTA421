using System;
using System.Text;
using System.Security.Cryptography;

namespace PasswordHashingandAuthentication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter password:");
            string plainpass = Console.ReadLine();
            string hashpass = HashPass(plainpass);
            Console.WriteLine($"Your password {plainpass} is {hashpass} when hashed.");
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
    }
}

