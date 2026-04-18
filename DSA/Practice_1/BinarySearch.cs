namespace src.Practice_1;

public class BinarySearch
{
    public static int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        var mid = (((right - left) + 1) / 2);
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            if (nums[mid] > target)
            {
                right = mid - 1;
                mid = left + (((right - left) + 1) / 2);
            }
            else if (nums[mid] < target && ((right - left) + 1) % 2 == 0)
            {
                left = mid;
                mid = left + (((right - left) + 1) / 2);
            }
            else if (nums[mid] < target && ((right - left) + 1) % 2 != 0)
            {
                left = mid + 1;
                mid = left + (((right - left) + 1) / 2);
            }
            else if (nums[mid] == target)
            {
                return mid;
            }

        }
        return -1;

    }
}