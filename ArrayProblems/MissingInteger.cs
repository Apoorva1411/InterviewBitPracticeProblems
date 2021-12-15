using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySolutions
{
    public class MissingInteger
    {
        public int firstMissingPositive(List<int> A)
        {
            int retval = 0;
            int[] count = new int[A.Count];
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] > 0 && A[i] <= A.Count)
                {
                    int index = A[i] - 1;
                    count[index] = 1;
                }
            }
            int j = 0;
            for (j = 0; j < count.Length; j++)
            {
                if (count[j] == 0)
                {
                    retval = j + 1;
                    break;
                }
            }
            if (j == A.Count)
                retval = j + 1;
            return retval;
        }
    }
}
