using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchPracticeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() {8,7,5,4,3};
            int B = 4;
            RotatedSortedSearch rotate = new RotatedSortedSearch();
            rotate.slidingMaximum(numbers, B);


        }
    }
}
