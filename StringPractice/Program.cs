using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrignPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            LetterPhone wc = new LetterPhone();
            Console.WriteLine(wc.letterCombinations("78875"));
        }
    }
}
