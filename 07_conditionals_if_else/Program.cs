using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_conditionals_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("How are you feeling today from 1-5?");
            string feelingNumber = Console.ReadLine();

            //2
            if (feelingNumber == "5")
            {
                Console.WriteLine("That's great to hear!");
            }
            //3
            else if (feelingNumber == "4")
            {
                Console.WriteLine("Good stuff");
            }
            else if (feelingNumber == "3")
            {
                Console.WriteLine("Hope things get better!");
            }
            else if (feelingNumber == "2")
            {
                Console.WriteLine("Oh. Sorry to hear that.");
            }
            else if (feelingNumber == "1")
            {
                Console.WriteLine("Dang. we hope your day gets better!");
            }
            //4
            else
            {
                Console.WriteLine("Sorry, we don't understand. Come back later.");
            }

            Console.ReadLine();
        }
    }
}
