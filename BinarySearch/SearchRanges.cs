using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchPracticeProblem
{
    public class SearchRanges
    {
        public List<int> searchRange(List<int> A, int B)
        {
            int low = 0;
            int high = A.Count - 1;
            List<int> retval = new List<int>();
            retval.Add(-1);
            retval.Add(-1);
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (A[mid] == B)
                {
                    int first = mid;
                    int last = mid;
                    while (last + 1 < A.Count && A[last + 1] == B)
                    {
                        last++;
                    }
                    while (first - 1 >= 0 && A[first - 1] == B)
                    {
                        first--;
                    }
                    retval[0] = first;
                    retval[1] = last;
                    break;
                }
                else if (B > A[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return retval;
        }

    }
}
