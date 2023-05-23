using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class VowelConsonantChecker
    {
        public static bool IsVowel(char alphabet) 
        {
            char lowerAlphabet = char.ToLower(alphabet);
            return lowerAlphabet == 'a' || lowerAlphabet == 'e' || lowerAlphabet == 'i' || lowerAlphabet == 'o' || lowerAlphabet == 'u';
        }
    }
}
