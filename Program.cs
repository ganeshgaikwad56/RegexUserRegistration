using RegexDemo;
using System;

namespace RegexDemo
{
    class Program

    {
        static void Main(string[] args)
        {
            Pattern registration = new Pattern();
            Console.WriteLine("Enter Your mobile Number");
            string value = Console.ReadLine();
            bool match = registration.ValidateMobileNumber(value);

            if (match)
                Console.WriteLine("Mobile Number Matched with given criteria");
            else
                Console.WriteLine("Pattern of Number not Matched with given criteria");

        }
    }
}
