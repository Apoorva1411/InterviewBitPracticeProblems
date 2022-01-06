using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrignPractice
{
    public class CombinationSum
    {
        public List<List<int>> combinationSum(List<int> a, int b)
        {
            a = a.OrderBy(i => i).ToList();
            var ans = new List<List<int>>();
            var cur = new List<int>();
            f(ans, cur, a, b, 0, 0);
            return ans;
        }

        private void f(List<List<int>> ans, List<int> cur, List<int> a, int targetSum,
            int curSum, int start)
        {
            if (curSum == targetSum)
            {
                ans.Add(new List<int>(cur));
            }
            else
            {
                for (int i = start; i < a.Count; i++)
                {
                    if (i != start && a[i] == a[i - 1]) continue;

                    if (curSum + a[i] > targetSum) break;

                    cur.Add(a[i]);
                    f(ans, cur, a, targetSum, curSum + a[i], i);
                    cur.RemoveAt(cur.Count - 1);

                }
            }
        }
    }
}
