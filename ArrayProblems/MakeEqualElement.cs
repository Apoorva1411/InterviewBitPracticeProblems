using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySolutions
{
    public class MakeEqualElement
    {
        public int solve(List<int> A, int B)
        {
            int retval = 1;

            A = A.Distinct().ToList();
            A.Sort();
            int mid = A.Count / 2;
            for (int i = 0; i < mid; i++)
            {
                int first = i;
                int last = A.Count - (i + 1);
                if (Math.Abs(A[first] - A[mid]) == B && Math.Abs(A[first] - A[mid]) == Math.Abs(A[last] - A[mid]))
                {
                    continue;
                }
                else if (Math.Abs(A[first] - A[mid]) == 0 && Math.Abs(A[first] - A[mid]) == Math.Abs(A[last] - A[mid]))
                {
                    continue;
                }
                else
                {
                    retval = 0;
                    break;
                }
            }
            return retval;
        }
    }
}
