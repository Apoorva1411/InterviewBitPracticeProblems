using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySolutions
{
    public class LargestNumber
    {
        public string largestNumber(List<int> A)
        {
            string retVal = string.Empty;
            List<string> numberList = A.ConvertAll<string>(
                delegate (int i) { return i.ToString(); });
            numberList.Sort(SortFunction);
            retVal = string.Join("",numberList.ToArray());
            if (numberList.TrueForAll(x=>x == "0"))
            {
                retVal = "0";
            }
            return retVal;
        }

        public  static int SortFunction(string A, string B)
        {
            string AB = A + B;
            string BA = B + A;

            return CompareNumbers(BA,AB );
        }

        public static int CompareNumbers(string x, string y)
        {
            if (x.Length > y.Length) y = y.PadLeft(x.Length, '0');
            else if (y.Length > x.Length) x = x.PadLeft(y.Length, '0');

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < y[i]) return -1;
                if (x[i] > y[i]) return 1;
            }
            return 0;
        }
    }
}
