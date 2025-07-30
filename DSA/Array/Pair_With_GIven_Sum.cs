using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array;
public class Pair_With_GIven_Sum
{
    //[10,5,7], 17
    //[1,2,3], 5
    public static bool Find_Pair_With_GIven_Sum(int[] arr, int targetSum)
    {
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    for (int j = 0; j < arr.Length; j++) {
        //        if(i != j && arr[i] + arr[j] == targetSum) return true;
        //    }
        //}
        HashSet<int> seen = new HashSet<int>();
        for (int i = 0; i < arr.Length; i++) { 
            int compliment = targetSum- arr[i];
            if (seen.Contains(compliment))
                return true;
            seen.Add(arr[i]);
        }

        return false;
    }
}
