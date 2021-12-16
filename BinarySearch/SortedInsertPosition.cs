using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchPracticeProblem
{
    public class SortedInsertPosition
    {
        /*   int Solution::searchInsert(vector<int> &A, int B)
           {
               int index = 0;
               int low = 0;
               int high = A.size() - 1;
   
               while (low <= high)
               {
                   int mid = (low + high) / 2;
                   if (A[mid] == B)
                   {
                       index = mid;
                       break;
                   }
                   else if (B > A[mid])
                   {
                       if (mid == A.size() - 1 || mid + 1 < A.size() && A[mid + 1] > B)
                       {
                           index = mid + 1;
                           break;
                       }
                       else
                       {
                           low = mid + 1;
                       }
                   }
                   else
                   {
                       if (mid - 1 >= 0 && A[mid - 1] < B)
                       {
                           index = mid;
                           break;
                       }
                       else
                       {
                           high = mid - 1;
                       }
                   }
               }
               return index;
           }
   
       }*/
    }
}
