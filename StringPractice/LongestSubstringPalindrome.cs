using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrignPractice
{
    public class LongestSubstringPalindrome
    {
        public string getSubString(string str, int low,
            int high)
        {
           return str.Substring(low,high - low + 1);
        }
        public string longestPalindrome(string A)
        {
            string retval = String.Empty;
            int n = A.Length;
            int[,] retmatrix = new int[n,n];
            int maxlength = 0;
            int start = Int32.MaxValue;
            for (int i = 0; i < n; i++)
            {
                retmatrix[i, i] = 1;
                if (i < n - 1 && A[i] == A[i + 1])
                {
                    start = Math.Min(i, start);
                    maxlength = 2;
                    retmatrix[i, i + 1] = 1;
                }
            }

            for (int k = 3; k <= n; k++)
            {
                for (int i = 0; i < n - k + 1; i++)
                {
                    int j = i + k - 1;
                    if (retmatrix[i + 1, j - 1] == 1 && A[i] == A[j])
                    {
                        retmatrix[i, j] = 1;
                        if (k > maxlength)
                        {
                            start = i;
                            maxlength = k;
                        }
                    }
                }
            }

            if (start == Int32.MaxValue)
                return A[0].ToString();
            else
                return getSubString(A, start, start + maxlength - 1);
        }
    }
}
