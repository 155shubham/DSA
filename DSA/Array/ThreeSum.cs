namespace DSA.Array_Problems;
public class ThreeSum
{
    // Time Complexity: O(n^2)
    public static IList<IList<int>> FindThreeSum(int[] nums)
    {       
        
        var result = new List<IList<int>>();
        Array.Sort(nums);
        int n = nums.Length;

        for (int i = 0; i < n - 2; i++)
        {
            // Skip duplicate values for the first element
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            int left = i + 1;
            int right = n - 1;

            while (left < right)
            {
                long sum = (long)nums[i] + nums[left] + nums[right];

                if (sum == 0)
                {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });

                    int leftVal = nums[left];
                    int rightVal = nums[right];

                    // Skip duplicates for the second element
                    while (left < right && nums[left] == leftVal)
                        left++;

                    // Skip duplicates for the third element
                    while (left < right && nums[right] == rightVal)
                        right--;
                }
                else if (sum < 0)
                {
                    left++;
                }
                else // sum > 0
                {
                    right--;
                }
            }
        }

        return result;
    }




    public static void TestThreeSum()
    {
        //var result = FindThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });
        //var result = FindThreeSum(new int[] { 0, 0, 0, 0 });
        //var result = FindThreeSum(new int[] { 1, 2, -2, -1 });
        //var result = FindThreeSum(new int[] { -2, 0, 0, 2, 2 });
        var result = FindThreeSum(new int[] { -2, -1, -1, 0, 1, 2, 2 });
        foreach (var triplet in result)
        {
            Console.WriteLine("[" + string.Join(", ", triplet) + "]");
        }
    }
}

//Test Case     Input               Expected Output
//1	            [-1,0,1,2,-1,-4]    [[-1,-1,2], [-1,0,1]]
//2	            [0, 0, 0, 0]        [[0, 0, 0]]
//3	            [1, 2, -2, -1]      []
//4	            [-2,0,0,2,2]        [[-2,0,2]]
//5	            [-2,-1,-1,0,1,2,2]  [-2,0,2], [-1,-1,2], [-1,0,1]]