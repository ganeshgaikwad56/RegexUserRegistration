using RegexDemo;
using System;

namespace RegexDemo
{
    class Program

    {
        static void Main(string[] args)
        {
            UserLastName registration = new UserLastName();
            Console.WriteLine("Enter Your Last Name");
            string value = Console.ReadLine();
            bool match = registration.validateLastName(value);

            if (match)
                Console.WriteLine("Last Name Matched with given criteria");
            else
                Console.WriteLine("Pattern not Matched with given criteria,should Last name start with Capital and has min 3 charecters.");

        }
    }
}
