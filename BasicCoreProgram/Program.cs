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
            Console.WriteLine("Please choose any one program.");
            Console.WriteLine(" 1.Coin flipper\n 2.Leap year\n 3.Power of 2\n 4.Harmonic numbers\n 5.Prime factorization\n 6.Q & R Calculator");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CoinFlipper flipper = new CoinFlipper();
                    CoinFlipper.FlipCoin(100);
                    break;
                case 2:
                    Console.WriteLine("Please enter the year:");
                    LeapYear checker = new LeapYear();
                    int year = Convert.ToInt32(Console.ReadLine()); //Example: Year to check
                    if (LeapYear.IsLeapYear(year))
                    {
                        Console.WriteLine(year + " is a leap year.");
                    }
                    else
                    {
                        Console.WriteLine(year + " is not a leap year.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Please enter the number:");
                    PowerOf2 table = new PowerOf2();
                    int N = Convert.ToInt32(Console.ReadLine());
                    PowerOf2.PrintPowerOfTwoTable(N);
                    break;

                case 4:
                    Console.WriteLine("Please enter the number:");
                    HarmonicNumbers harmonic = new HarmonicNumbers();
                    int X = Convert.ToInt32(Console.ReadLine());
                    double result = HarmonicNumbers.CalculateHarmonicNumber(X);
                    Console.WriteLine("Nth Harmonic Value: " + result);
                    break;

                case 5:
                    Console.WriteLine("Please enter the number:");
                    PrimeFactorization factorization = new PrimeFactorization();
                    int x = Convert.ToInt32(Console.ReadLine());
                    PrimeFactorization.FindPrimeFactors(x);
                    break;

                case 6:
                    Console.WriteLine("Pleaae enter Dividend");
                    int dividend = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter Divisor");
                    int divisor = Convert.ToInt32(Console.ReadLine());
                    int quotient, remainder;
                    Quotient_RemainderCalculator calculator = new Quotient_RemainderCalculator();
                    Quotient_RemainderCalculator.ComputeQuotientAndRemaider(dividend, divisor, out quotient, out remainder);
                    Console.WriteLine("Quotient: " + quotient);
                    Console.WriteLine("Remainder: " + remainder);
                    break; 
            }
            Console.ReadLine();
        } 
    }
}
