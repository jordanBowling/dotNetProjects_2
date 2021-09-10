using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Types_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInt = 5000;
            string greeting = "sup, dude? ";
            string greeting2 = "How are you doing? ";
            bool yesOrNo = true;
            float nonWholeNumber = 1.5f;
            double numberDouble = 1.50000d;
            decimal accountBalance = -1000.84m;

            Console.WriteLine(yesOrNo);
            Console.WriteLine(nonWholeNumber);
            Console.WriteLine(numberDouble);

            Console.WriteLine(greeting + greeting2);

            int birthYear = Int32.Parse("1990");
            Console.WriteLine("I was born in {0}.", birthYear);
        }
    }
}
