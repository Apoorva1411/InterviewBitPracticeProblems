using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StrignPractice
{
    public class CountandSay
    {
        
        public string countAndSay(int A)
        {
            string output = "1";
            int i = 1;
            while (i <= A-1)
            {
                StringBuilder temp = new StringBuilder();
                int count = 0;
                char prev = ' ';
                foreach (char ch in output)
                {
                    if (prev == ch)
                    {
                        count++;
                    }
                    else if (prev == ' ')
                    {
                        count = 1;
                        prev = ch;
                    }
                    else
                    {
                        temp.Append(count.ToString());
                        temp.Append(prev);
                        prev = ch;
                        count = 1;
                    }
                }
                temp.Append(count.ToString());
                temp.Append(prev);
                output = temp.ToString();
                i++;
            }
            return output;
        }
    }
}
