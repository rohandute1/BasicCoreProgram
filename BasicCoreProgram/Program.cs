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
            Console.WriteLine(" 1.Coin flipper\n 2.Leap year\n 3.Power of 2\n 4.Harmonic numbers\n 5.Prime factorization\n 6.Q & R Calculator\n 7.Number Swapper\n 8.Even Odd Checker\n 9.Vowel Consonant Checker\n 10.Find largest among three numbers");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CoinFlipper.FlipCoin(100);
                    break;
                case 2:
                    Console.WriteLine("Please enter the year:");
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
                    int N = Convert.ToInt32(Console.ReadLine());
                    PowerOf2.PrintPowerOfTwoTable(N);
                    break;

                case 4:
                    Console.WriteLine("Please enter the number:");
                    int X = Convert.ToInt32(Console.ReadLine());
                    double result = HarmonicNumbers.CalculateHarmonicNumber(X);
                    Console.WriteLine("Nth Harmonic Value: " + result);
                    break;

                case 5:
                    Console.WriteLine("Please enter the number:");
                    int x = Convert.ToInt32(Console.ReadLine());
                    PrimeFactorization.FindPrimeFactors(x);
                    break;

                case 6:
                    Console.WriteLine("Pleaae enter Dividend");
                    int dividend = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter Divisor");
                    int divisor = Convert.ToInt32(Console.ReadLine());
                    int quotient, remainder;
                    Quotient_RemainderCalculator.ComputeQuotientAndRemaider(dividend, divisor, out quotient, out remainder);
                    Console.WriteLine("Quotient: " + quotient);
                    Console.WriteLine("Remainder: " + remainder);
                    break; 

                case 7:
                    Console.WriteLine("Please enter first number:");
                    int numb1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter second number:");
                    int numb2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Before swapping:");
                    Console.WriteLine("Number 1: " + numb1);
                    Console.WriteLine("Number 1: " + numb2);
                    SwapNumbers.NumberSwapper(ref numb1, ref numb2);
                    Console.WriteLine("After swapping:");
                    Console.WriteLine("Number 1: " + numb1);
                    Console.WriteLine("Number 1: " + numb2);
                    break;

                case 8:
                    EvenOrOddChecker checker1 = new EvenOrOddChecker();
                    Console.WriteLine("Please enter any number to check weather it is even or odd:");
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (checker1.Equals(number)) 
                    {
                        Console.WriteLine(number + " is even.");
                    }
                    else 
                    {
                        Console.WriteLine(number + " is odd.");
                    }
                    break;

                case 9:
                    VowelConsonantChecker check = new VowelConsonantChecker();
                    Console.WriteLine("Please enter any Alphabet to check it is Vowel or Consonant:");
                    char alphabet = Convert.ToChar(Console.ReadLine());

                    if (check.Equals(alphabet)) 
                    {
                        Console.WriteLine(alphabet + " is a vowel.");
                    }
                    else 
                    {
                        Console.WriteLine(alphabet + " is a consonant.");
                    }
                    break;

                    case 10:
                    LargestNumberFinder finder = new LargestNumberFinder();
                    Console.WriteLine("Please enter first number");
                    int first = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter second number");
                    int second = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter third number");
                    int third = Convert.ToInt32(Console.ReadLine());

                    int largestNumber = LargestNumberFinder.FindLargestNumber(first, second, third);
                    Console.WriteLine("The largest number among " + first + ", " + second + ", and " + third + " is: " + largestNumber);
                    break;
            }
            Console.ReadLine();
        } 
    }
}
