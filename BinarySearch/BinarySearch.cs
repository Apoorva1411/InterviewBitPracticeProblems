using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchPracticeProblem
{
    public class BinarySearch
    {
        public int findCount(List<int> A, int B)
        {
            int retval = 0;
            int low = 0;
            int high = A.Count;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (A[mid] == B)
                {
                    int temp = mid;
                    while (temp < A.Count && A[temp] == B)
                    {
                        retval++;
                        temp++;
                    }

                    temp = mid - 1;
                    while (temp >= 0 && A[temp] == B)
                    {
                        retval++;
                        temp--;
                    }

                    break;
                }
                else if (B < A[mid])
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            return retval;
        }
    }
}
