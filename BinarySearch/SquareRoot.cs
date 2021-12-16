using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchPracticeProblem
{
    public class SquareRoot
    {
        public int sqrt(int A)
        {
            int retval = 0;
            if (A == 1) return 1;
            else if (A == 0) return 0;
            ulong roots = (ulong)A/2;
            while (roots > 0)
            {
                ulong square = roots * roots;
                if (square == (ulong)A)
                {
                    retval = (int)roots;
                    break;
                }
                else if (square > (ulong)A)
                {
                    roots = roots / 2;
                }
                else
                {
                    while ((roots + 1) * (roots + 1) <= (ulong)A)
                    {
                        roots++;
                    }
                    retval = (int)roots;
                    break;
                }
            }
            return retval;
        }
    }
}
