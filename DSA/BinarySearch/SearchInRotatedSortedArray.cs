namespace src.BinarySearch;
public class SearchInRotatedSortedArray
{
    //public static int Get_SearchInRotatedSortedArray(int[] nums, int target)
    //{
    //    Array.Sort(nums);
    //    int startIndex = 0;
    //    int endIndex = nums.Length-1;
    //    int totalLength = nums.Length;

    //    while(startIndex < endIndex)
    //    {
    //        if (totalLength % 2 == 0) 
    //        {
    //            if (target == nums[(totalLength / 2)-1]) return (totalLength / 2) - 1;
    //            if (target == nums[(totalLength / 2)]) return (totalLength / 2);
    //            if (target > nums[(totalLength / 2)]) startIndex = (totalLength / 2);
    //            else endIndex = (totalLength / 2)-1;
    //        }
    //        else
    //        {
    //            if (target == nums[(totalLength / 2)]) return (totalLength / 2);
    //            else if (target > nums[(totalLength / 2)]) startIndex = (totalLength / 2)+1;
    //            else endIndex = totalLength / 2;
    //        }
    //        totalLength = totalLength / 2;
    //    }
    //    return -1;
    //}
    public static int Get_SearchInRotatedSortedArray(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }

            if (nums[left] <= nums[mid])
            {
                if (target >= nums[left] && target < nums[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            else
            {
                if(target > nums[mid] && target <= nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
               
            }
        }
        return -1;
    }

    public static void TestSearchInRotatedSortedArray()
    {
        //var res = Get_SearchInRotatedSortedArray(new int[] { 8,9,10,11,7 }, 8);
        var res = Get_SearchInRotatedSortedArray(new int[] { 9,10,11,7,8 }, 8);
        Console.WriteLine(res);
    }
}
// 3,4,5,6,7,9
// 0,1,2,3,4,5

//1 2 3 4 5 6 7 8 9 10
//0 1 2 3 4 5 6 7 8 9

//1 2 3 4
//0 1 2 3




