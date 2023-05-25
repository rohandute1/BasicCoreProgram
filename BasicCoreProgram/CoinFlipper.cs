using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class CoinFlipper
    {
        public static void FlipCoin(int numFlips)
        {
            if (numFlips <= 0)
            {
                Console.WriteLine("Number of flips should be a positive integer.");
                return;
            }

            Random random = new Random();
            int headsCount = 0;
            int tailsCount = 0;

            for (int i = 0; i < numFlips; i++)
            {
                int randomValue = random.Next(1, 3);
                if (randomValue == 1)
                    headsCount++;
                else
                    tailsCount++;
            }

            double headsPercentage = (headsCount / (double)numFlips) * 100;
            double tailsPercentage = (tailsCount / (double)numFlips) * 100;

            Console.WriteLine("Percentage of Heads: " + headsPercentage.ToString("0.00") + "%");
            Console.WriteLine("Percentage of Tails: " + tailsPercentage.ToString("0.00") + "%");
        }
    }
}
