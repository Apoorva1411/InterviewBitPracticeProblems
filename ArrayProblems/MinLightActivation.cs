using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    public class MinLightActivation
    {
        public int solve(List<int> A, int B)
        {
            int n = A.Count;
            int MinBulb = 0;
            int i = 0;
            //loop through the array to find light
            while (i < n-1)
            {
                //Jump B units from given position
                int j = Math.Min(i + (B - 1), A.Count - 1);
                //if we can turn on bulb then jump ahead
                if (A[j] == 1)
                {
                    MinBulb++;
                    i = Math.Min(j + (B - 1)+1, n - 1);
                }
                else
                {
                    //else check leftmost of active bulb
                    int k = 0;
                    var previous = Math.Max(0, i - (B - 1));
                    for (k = j-1; k >= previous; k--)
                    {
                        if (A[k] == 1)
                        {
                            MinBulb++;
                            i = Math.Min(k + (B - 1) + 1, n - 1);
                            break;
                        }
                    }

                    if (k <= previous)
                    {
                        MinBulb = -1;
                        break;
                    }
                }
            }
            return MinBulb;
        }
    }
}
