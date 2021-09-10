using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal Bill = 54.23m;
            decimal Tip = 12m;

            decimal percentage = Tip / Bill;
            Console.WriteLine(percentage);
            Console.WriteLine(Math.Round(percentage, 2));
            Console.ReadLine();
        }
    }
}
