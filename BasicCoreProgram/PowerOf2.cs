using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class PowerOf2
    {
        public static void PrintPowerOfTwoTable(int N) 
        {
            if (N < 0 || N >= 31) 
            {
                Console.WriteLine("Invalid input. N should be between 0 and 30.");
                return;
            }
            int power = 1;
            for (int i = 0; i <= N; i++) 
            {
                Console.WriteLine("2^" + i + " = " + power);
                power *= 2;
            }
        }
    }
}
