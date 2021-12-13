
using System.Collections.Generic;


namespace ArrayPractice
{
    public class SortArray
    {

        public List<int> solve(List<int> A)
        {
            List<int> postivite = new List<int>();
            List<int> negative = new List<int>();
            List<int> retVal = new List<int>();

            for (int i = 0; i < A.Count; i++)
            {
                //collect squares of negative number in one list
                if (A[i] < 0)
                {
                    negative.Insert(0,A[i] * A[i]);
                }
                //collect squares of positive number in one list
                else
                {
                    postivite.Add(A[i] * A[i]);
                }
            }
            //merge both list to get final answer
            retVal = Merge(postivite, negative);
            return retVal;
        }

        private List<int> Merge(List<int> postivite, List<int> negative)
        {
            List<int> retVal = new List<int>();
            int i = 0, j = 0;

            while (i < postivite.Count && j < negative.Count)
            {
                if (postivite[i] <= negative[j])
                {
                    retVal.Add(postivite[i]);
                    i = i + 1;
                }
                else
                {
                    retVal.Add(negative[j]);
                    j = j + 1;
                }
            }

            if (i < postivite.Count)
            {
                while (i < postivite.Count)
                {
                    retVal.Add(postivite[i]);
                    i++;
                }
            }
            if (j < negative.Count)
            {
                while (j < negative.Count)
                {
                    retVal.Add(negative[j]);
                    j++;
                }
            }
            return retVal;
        }
    }
}