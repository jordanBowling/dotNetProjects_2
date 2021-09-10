using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_loops_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 500;
            while (number <= 525)
            {
                Console.WriteLine(number);
                number = number + 1;
            }
            Console.ReadLine();

            int number1 = 100;
            for (int i = 0; i <= 100; i += 5)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
