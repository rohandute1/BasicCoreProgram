using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class Quotient_RemainderCalculator
    {
        public static void ComputeQuotientAndRemaider(int dividend, int divisor, out int quotient, out int remainder) 
        {
            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }
    }
}
