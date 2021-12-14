using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySolutions
{
    public class WaveArray
    {
        public List<int> wave(List<int> A)
        {
            if (A.Count <= 1)
            {
                return A;
            }
            else
            {
                A.Sort();
                int i = 0;
                while (i < A.Count - 1)
                {
                    int temp = A[i];
                    A[i] = A[i + 1];
                    A[i + 1] = temp;
                    i = i + 2;
                }
                return A;
            }
        }
    }
}
