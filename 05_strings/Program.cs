using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "The cars we sell are ";
            string second = "BMW, Lexus, and Mercedes.";
            Console.WriteLine(first + second);

            string firstName = "Jordan";
            string lastName = "Bowling";

            Console.WriteLine("My name is {0} {1}.", firstName, lastName);

            string herFirstName = "Robin";
            string herLastName = "Holler";

            Console.WriteLine($"Her name is {herFirstName} {herLastName}.");
        }
    }
}
