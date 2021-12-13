/*You are in an infinite 2D grid where you can move in any of the 8 directions
 (x,y) to 
    (x-1, y-1), 
    (x-1, y)  , 
    (x-1, y+1), 
    (x  , y-1),
    (x  , y+1), 
    (x+1, y-1), 
    (x+1, y)  , 
    (x+1, y+1) 
You are given a sequence of points and the order in which you need to cover the points.. Give the minimum number of steps in which you can achieve it. You start from the first point.*/

using System;
using System.Collections.Generic;

namespace ArraySolutions
{
    public class MinStepInInfiniteGrid
    {
        public int coverPoints(List<int> A, List<int> B)
        {
            int maxJump = 0;
            for (int i = 0; i < A.Count - 1; i++)
            {
                //check if xaxis is far than yaxis and calculate maxJump using it
                int xdiff = Math.Abs(A[i + 1] - A[i]);
                int ydiff = Math.Abs(B[i + 1] - B[i]);
                maxJump += Math.Max(xdiff, ydiff);
            }
            return maxJump;
        }
    }
}
