using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrignPractice
{
    public class WordsCount
    {
        public string solve(string A)
        {
            var array = A.Trim().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                sb.Append(array[i]);
                sb.Append(" ");
            }
            return sb.ToString().Trim();
        }

    }
}
