using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class HarmonicNumbers
    {
        public static double CalculateHarmonicNumber(int N) 
        {
            if (N == 0) 
            {
                Console.WriteLine("Invalid input. N should be a non-zero value.");
                return 0;
            }
            double harmonicNumber = 0;

            for (int i = 1; i<= N; i++) 
            {
                harmonicNumber += 1.0 / i;
            }
            return harmonicNumber;
        }
    }
}
