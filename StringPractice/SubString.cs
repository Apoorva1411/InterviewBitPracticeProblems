using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrignPractice
{
    public class SubString
    {
        public int strStr(string A, string B)
        {
            int retval = -1;
            if (!String.IsNullOrEmpty(A) && !String.IsNullOrEmpty(B))
            {
                int i = 0;
                int j = 0;
                while (i < A.Length && j < B.Length)
                {
                    if (A[i].CompareTo(B[j]) == 0)
                    {
                        if (j == 0)
                            retval = i;
                        i = i + 1;
                        j = j + 1;
                    }
                    else
                    {
                        while (j-1 >= 0 && A[i] == A[j-1])
                        {
                            j = j-1;
                        }
                        i = i + 1;
                        retval = -1;
                    }
                }
                if (j < B.Length)
                    retval = -1;
            }

            return retval;
        }
    }
}
