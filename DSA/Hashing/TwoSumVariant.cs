using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Hashing;
public class TwoSumVariant
{
    // O(n^2) time complexity
    public static int[] TwoSum(int[] nums, int target)
    {
        for (int i=0; i<nums.Length; i++)
        {
            for (int j=i+1; j<nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        return new int[] { -1, -1 };
    }

    // O(n) time complexity
    public static int[] TwoSum_1(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }

            if (!map.ContainsKey(nums[i]))
            {
                map[nums[i]] = i;
            }

        }
        return new int[] { -1, -1 };
    }

    public static void TestTwoSum()
    {
        var result = TwoSum(new int[] { 2, 7, 11, 15 }, 9);
        Console.WriteLine($"[{result[0]}, {result[1]}]"); // Output: [0, 1]

        var result_1 = TwoSum_1(new int[] { 2, 7, 11, 15 }, 9);
        Console.WriteLine($"[{result_1[0]}, {result_1[1]}]"); // Output: [0, 1]
    }
}
