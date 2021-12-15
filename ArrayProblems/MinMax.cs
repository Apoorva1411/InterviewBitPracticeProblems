using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySolutions
{
    public class MinMax
    {
        public int solve(List<int> A)
        {
            int minVal = Int32.MaxValue;
            int maxVal = Int32.MinValue;
            foreach (int number in A)
            {
                minVal = Math.Min(minVal, number);
                maxVal = Math.Max(maxVal, number);
            }

            return minVal + maxVal;
        }
    }
}
