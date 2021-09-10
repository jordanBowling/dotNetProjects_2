using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_conditionals_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string inputName = Console.ReadLine().ToLower();

            switch (inputName)
            {
                case "fred":
                    Console.WriteLine("Hey Fred, let's go golfing. ");
                    break;
                case "karl": 
                    Console.WriteLine("Lets hang!");
                    break;
                case "john":
                    Console.WriteLine("Sorry, I'm busy.");
                    break;
                default:
                    Console.WriteLine("Hey " + inputName + ", can i call you back in a minute?");
                    break;
            }
        }
    }
}
