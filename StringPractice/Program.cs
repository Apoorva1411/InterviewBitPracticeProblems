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
            WordsCount wc = new WordsCount();
            Console.WriteLine(wc.solve("apoorva raju is good girl"));
        }
    }
}
