using DSA.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array_Test;
public class Test_Pair_With_GIven_Sum
{
    public static void Test_1()
    {
        int[] arr = { 1, 2, 3 };
        int targetSum = 5;
        var res = Pair_With_GIven_Sum.Find_Pair_With_GIven_Sum(arr, targetSum);
        Console.WriteLine(res);
    }
    public static void Test_2()
    {
        int[] arr = { 1, 2, 3 };
        int targetSum = 7;
        var res = Pair_With_GIven_Sum.Find_Pair_With_GIven_Sum(arr, targetSum);
        Console.WriteLine(res);
    }
}
