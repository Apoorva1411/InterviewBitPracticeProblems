//Problem Description
//Given an integer array A of size N.
//You can pick B elements from either left or right end of the array A to get maximum sum.
//Find and return this maximum possible sum.
//NOTE: Suppose B = 4 and array A contains 10 elements then
//You can pick first four elements or can pick last four elements or can pick 1 from front and 3 from back etc.you need to return the maximum possible sum of elements you can pick.

using System;
using System.Collections.Generic;

namespace ArraySolutions
{
    public class PickFromBothEnds
    {
        public  int solve(List<int> A, int B)
        {
            //first calculate sum of left B elements
            int leftSum = 0;
            for (int i = 0; i < B; ++i)
            {
                leftSum += A[i];
            }

            int rightSum = 0;
            int maxSum = leftSum;
            //Later Subtract one element from left
            //add one elemet to Right 
            //check if its greater than present sum
            for (int i = 0; i < B; ++i)
            {
                leftSum -= A[(B - 1) - i];
                rightSum += A[(A.Count - 1) - i];
                maxSum = Math.Max(maxSum, leftSum + rightSum);
            }

            return maxSum;
        }
    }
}
