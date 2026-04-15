using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Practice_1;
public class MaximumSubArray
{
    public static int Find_MaximumSubArray(int[] arr)
    {
        int maxSum = int.MinValue;
        int currentSum = 0;
        foreach (var item in arr)
        {
            currentSum = Math.Max(item, currentSum + item);
            maxSum = Math.Max(maxSum, currentSum);
        }
        return maxSum;
    }
}
