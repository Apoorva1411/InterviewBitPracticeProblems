using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StrignPractice
{
    public class KthPermutation
    {
        public string getPermutation(int A, int B)
        {
            StringBuilder str = new StringBuilder();
            List<int> num = new List<int>();
            for (int i = 1; i <= A; i++)
            {
                num.Add(i);
            }
            while (B > 1)
            {
                num = nextPermutation(num);
                B--;
            }

            foreach (int n in num)
            {
                str.Append(n);
            }

            return str.ToString();
        }

        public List<int> nextPermutation(List<int> A)
        {
            int i = Int32.MinValue, j = Int32.MinValue;
            int n = A.Count - 1;
            for (int k = 0; k < A.Count - 1; k++)
            {
                if (A[k] < A[k + 1])
                {
                    i = Math.Max(i, k);
                }
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
