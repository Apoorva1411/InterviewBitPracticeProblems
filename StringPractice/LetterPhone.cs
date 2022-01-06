using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StrignPractice
{
    public class LetterPhone
    {
        public Dictionary<char, string> letterMap = new Dictionary<char, string>();
        public List<string> letterCombinations(string A)
        {
            List<string> result = new List<string>();
             UpdateLetterMap(letterMap);
             ReplaceString(A,0,ref result);
             return result;

        }

        private void ReplaceString(string A, int start, ref List<string> result)
        {
            if (start >= A.Length)
            {
                result.Add(A);
                return;
            }

            string letters = letterMap[A[start]];
            int lettercount = 0;
            while (lettercount < letters.Length)
            {
                StringBuilder str = new StringBuilder();
                if (start > 0)
                {
                    str.Append(A.Substring(0, start));
                }
                str.Append(letters[lettercount]);
                str.Append(A.Substring(start + 1));
                ReplaceString(str.ToString(),start+1,ref result);
                lettercount += 1;
            }
        }

        private void UpdateLetterMap(Dictionary<char, string> letterMap)
        {
            letterMap['0'] = "0";
            letterMap['1'] = "1";
            letterMap['2'] = "abc";
            letterMap['3'] = "def";
            letterMap['4'] = "ghi";
            letterMap['5'] = "jkl";
            letterMap['6'] = "mno";
            letterMap['7'] = "pqrs";
            letterMap['8'] = "tuv";
            letterMap['9'] = "wxyz";
        }
    }
}
