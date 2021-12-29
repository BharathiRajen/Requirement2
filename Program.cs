using System;
using System.Text.RegularExpressions;

namespace Requirement2
{
    class Program
    {
        public static Boolean validatePassword(string userPassword)
        {
            Regex regex = new Regex("^[A-Z][\\S][A-Za-z0-9_@#%!]{8,15}$");
            return regex.IsMatch(userPassword);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Password Validation:");
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine(); if (validatePassword(password))
            {
                Console.WriteLine("Valid Password!..");
            }
            else
            {
                Console.WriteLine("Invalid Password!..");
            }
        }
    }
}

