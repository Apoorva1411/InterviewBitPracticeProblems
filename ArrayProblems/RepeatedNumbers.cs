using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySolutions
{
    public class RepeatedNumbers
    {
        public int repeatedNumber(List<int> A)
        {
            int retval = -1;
            HashSet<int> numbers = new HashSet<int>();
            foreach (int num in A)
            {
                bool _add = numbers.Add(num);
                if (!_add)
                {
                    retval = num;
                    break;
                }
            }
            return retval;
        }
    }
}
