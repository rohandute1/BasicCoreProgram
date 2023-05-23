using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class LargestNumberFinder
    {
        public static int FindLargestNumber(int number1, int number2, int number3) 
        {
            int largestNumber = number1;
            if (number2 > largestNumber) 
            {
                largestNumber = number2;
            }
            if (number3 > largestNumber) 
            {
                largestNumber = number3;
            }
                return largestNumber;
        }
    }
}
