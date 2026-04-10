using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Practice_1;
public class TwoSum
{
    public static void FindTwoSum(int[] arr, int tgt)
    {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < arr.Length; i++) 
        { 
            var complement = tgt - arr[i];
            if (dict.ContainsKey(complement))
            {
                Console.WriteLine($"Pair found: {i} and {dict[complement]}");
                return;
            }
            dict[arr[i]] = i;
        }
    }

    // Better approach: Using TryGetValue to avoid double lookup in dictionary
    public static int[] FindTwoSum_1(int[] arr, int tgt)
    {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < arr.Length; i++)
        {
            var complement = tgt - arr[i];
            if (dict.TryGetValue(complement, out int index))
            {
                return new int[] {index, i};
            }
            dict[arr[i]] = i;
        }

        return Array.Empty<int>();
    }
}
