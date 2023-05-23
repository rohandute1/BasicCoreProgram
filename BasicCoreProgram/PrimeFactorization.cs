using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class PrimeFactorization
    {
        public static void FindPrimeFactors(int N) 
        {
            if (N<= 1) 
            {
                Console.WriteLine("Invalid input. N should be a positive integer greater than 1.");
                return;
            }
            Console.WriteLine("Prime factors of " + N + ": ");

            for (int i = 2; i * i <= N; i++) 
            {
                while (N % i == 0) 
                {
                    Console.Write(i + " ");
                    N /= i;
                }
            }

            if (N > 1) 
            {
                Console.Write(N); 
            }

            Console.WriteLine();
        }
    }
}
