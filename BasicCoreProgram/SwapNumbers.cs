using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class SwapNumbers
    {
        public static void NumberSwapper(ref int a, ref int b) 
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}
