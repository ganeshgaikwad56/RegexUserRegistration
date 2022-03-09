using RegexDemo;
using System;

namespace RegexDemo
{
    class Program

    {
        static void Main(string[] args)
        {
            PasswordRules registration = new PasswordRules();
            Console.WriteLine("Enter Your password");
            string value = Console.ReadLine();
            bool match = registration.ValidatePass(value);

            if (match)
                Console.WriteLine("Password Matched with given criteria");
            else
                Console.WriteLine("Pattern of Password not Matched with given criteria");

        }
    }
}
