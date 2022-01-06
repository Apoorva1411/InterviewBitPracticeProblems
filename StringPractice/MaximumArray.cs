using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrignPractice
{
    public class MaximumArray
    {
        public string solve(string A, int B)
        {
           findMaximumNum(A.ToCharArray(),B,ref A);
           return A;
        }

        void findMaximumNum(char[] str,int k,ref string max)
        {
            if (k == 0)
                return;

            int n = str.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (str[i] < str[j])
                    {
                        char t = str[i];
                        str[i] = str[j];
                        str[j] = t;

                        if (string.Join("", str).CompareTo(max) > 0)
                            max = String.Join("", str);

                        findMaximumNum(str,k - 1,ref max);

                        char c = str[i];
                        str[i] = str[j];
                        str[j] = c;
                    }
                }
            }
        }
    }
}

