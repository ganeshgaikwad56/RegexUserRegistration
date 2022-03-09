using RegexDemo;
using System;

namespace RegexDemo
{
    class Program

    {
        static void Main(string[] args)
        {
            UserRegistration registration = new UserRegistration();
            Console.WriteLine("Enter Your Name");
            string value = Console.ReadLine();
            bool match = registration.ValidateName(value);

            if (match)
                Console.WriteLine("Name Matched with given criteria");
            else
                Console.WriteLine("Pattern not Matched with given criteria should first name start with Capital and has min 3 charecters.");

        }
    }
}
