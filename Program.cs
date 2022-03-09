using RegexDemo;
using System;

namespace RegexDemo
{
    class Program

    {
        static void Main(string[] args)
        {
            EmailID registration = new EmailID();
            Console.WriteLine("Enter Your EmailID");
            string value = Console.ReadLine();
            bool match = registration.ValidateEmail(value);

            if (match)
                Console.WriteLine("EmailID Matched with given criteria");
            else
                Console.WriteLine("Pattern not Matched with given criteria.Retry");

        }
    }
}
