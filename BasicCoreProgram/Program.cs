using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Programs");

            CoinFlipper flipper = new CoinFlipper();
            CoinFlipper.FlipCoin(100);

            LeapYear checker = new LeapYear();
            int year = 2016; //Example: Year to check
            if (LeapYear.IsLeapYear(year)) 
            {
                Console.WriteLine(year + " is a leap year.");
            }
            else 
            {
                Console.WriteLine(year + " is not a leap year.");
            }

            PowerOf2 table = new PowerOf2();
            int N = 5;
            PowerOf2.PrintPowerOfTwoTable(N);
            Console.ReadLine();

        }
    }
}
