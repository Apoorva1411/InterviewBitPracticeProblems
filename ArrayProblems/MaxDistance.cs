using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ArrayPractice;

namespace ArraySolutions
{
    public class MaxDistance
    {
        public int maximumGap(List<int> A)
        {
            int minIndex = Int32.MaxValue;
            int MaxGap = -1;
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < A.Count; i++)
            {
                map.Add(i, A[i]);
            }

            foreach (var item in map.OrderBy(a => a.Value))
            {
                minIndex = Math.Min(minIndex, item.Key);
                MaxGap = Math.Max(MaxGap, (item.Key - minIndex));

            }
            return MaxGap;
        }

      
    }
}
