using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchPracticeProblem
{

    public class RotatedSortedSearch
    {
        public List<int> slidingMaximum(List<int> nums, int k)
        {
            var result = new int[nums.Count - k + 1];
            if (nums == null || nums.Count == 0)
                return result.ToList();

            List<int> deque = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                if (deque.Count > 0 && deque[0] == i - k)
                    deque.RemoveAt(0);

                while (deque.Count > 0 && nums[deque[deque.Count - 1]] < nums[i])
                {
                    deque.RemoveAt(deque.Count - 1);
                }

                deque.Add(i);

                if (i + 1 >= k)
                    result[i + 1 - k] = nums[deque[0]];
            }

            return result.ToList();
        }
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
