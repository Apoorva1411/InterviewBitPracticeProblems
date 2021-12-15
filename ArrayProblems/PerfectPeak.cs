using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ArraySolutions
{
    public class PerfectPeak
    {
        public int perfectPeak(List<int> A)
        {
            int ret = 0;
            int[] leftArray = new int[A.Count];
            int[] rightArray = new int[A.Count];
            int max = A.Count - 1;
            for (int i = 0; i < max; i++)
            {
                if (i != 0 && A[i] > A[i - 1] )
                {
                    int j = i - 1;
                    while (j >= 0 && A[j] < A[i])
                    {
                        if (leftArray[j] == 1)
                        {
                            leftArray[i] = 1;
                            break;
                        }
                        j--;
                    }

                    if (j < 0)
                    {
                        leftArray[i] = 1;
                    }
                }
                else
                {
                    leftArray[i] = 0;
                }
                int k = max - (i+1);
                if (A[k] < A[k + 1])
                {
                    int j = k + 1;
                    while (j < A.Count - 1 && A[j] > A[k])
                    {
                        if (rightArray[j] == 1)
                        {
                            rightArray[k] = 1;
                            break;
                        }
                        j++;
                    }
                    if (j == A.Count - 1)
                        rightArray[k] = 1;
                }
                else
                {
                    rightArray[k] = 0;
                }
            }

            for (int p = 0; p < rightArray.Length; p++)
            {
                if (leftArray[p] == 1 && rightArray[p] == leftArray[p])
                {
                    ret = 1;
                    break;
                }
            }
            return ret;
        }
        
    }
}
