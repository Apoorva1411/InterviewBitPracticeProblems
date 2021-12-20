using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchPracticeProblem
{
    public class RotatedSortedSearch
    {
        public int search(List<int> A, int B)
        {
            int retVal = -1;
            int pivotElement = Int32.MinValue;
            for (int i = 1; i < A.Count; i++)
            {
                if (A[i] < A[i - 1])
                {
                    pivotElement = Math.Max(i, pivotElement);
                }
            }
            if (pivotElement != Int32.MinValue && pivotElement < A.Count - 1)
            {
                retVal = BinarySearch(A, B ,0, pivotElement - 1);
                if (retVal == -1)
                    retVal = BinarySearch(A,B, pivotElement, A.Count - 1);
            }
            else if (pivotElement == A.Count - 1)
            {
                A.Reverse(0, A.Count);
                retVal = A.Count - (1 + BinarySearch(A, B, 0, pivotElement - 1));
            }
            else
            {
                retVal = BinarySearch(A, B,0, A.Count - 1);
            }
         
            return retVal;
        }

        public int BinarySearch(List<int> A, int B, int low, int high)
        {
            int retval = -1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (A[mid] == B)
                {
                    retval = mid;
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
