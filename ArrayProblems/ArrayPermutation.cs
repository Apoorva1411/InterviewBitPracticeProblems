using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace PermutationsOfInteger
{
    public class Program

    {
        public List<int> nextPermutation(List<int> A)
        {
            int i = Int32.MinValue, j = Int32.MinValue;
            int n = A.Count - 1;
            for (int k = 0; k < A.Count-1; k++)
            {
                if (A[k] < A[k + 1])
                {
                    i = Math.Max(i, k);
                }
            }

            if (i == Int32.MinValue)
            {
                A.Sort();
                return A;
            }
            for (int k = i; k < A.Count; k++)
            {
                if (A[k] > A[i])
                {
                    j = Math.Max(i, k);
                }
            }

            Swap(A, i, j);
            Reverse(ref A, i + 1);
            return A;
        }

        private void Reverse(ref List<int> A, int i)
        {
            int last = A.Count - 1;
            for (int j = i; j < A.Count - 1; j++)
            {
                if (j < last)
                {
                    int temp = A[j];
                    A[j] = A[last];
                    A[last] = temp;
                    last--;
                }
            }
        }

        private void Swap(List<int> A, int i, int j)
        {
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }
    }
}
