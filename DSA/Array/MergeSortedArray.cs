using System;

namespace DSA.Array_Problems;
public class MergeSortedArray
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int itr = (m + n) - 1;
        int j = 0;
        for (int i = m; i <= itr; i++)
        {
            nums1[i] = nums2[j];
            j++;
        }
        // Fix: Use System.Array.Sort, not DSA.Array.Sort
        System.Array.Sort(nums1);
    }
}
