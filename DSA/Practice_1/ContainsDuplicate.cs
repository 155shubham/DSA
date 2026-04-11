using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Practice_1;
public class ContainsDuplicate
{
    // O(n)
    public static bool ContainsDuplicateMethod(int[] nums)
    {
        var hashSet = new HashSet<int>();
        foreach (var num in nums)
        {
            if(hashSet.Contains(num))
            {
                return true;
            }
            hashSet.Add(num);
        }
        return false;
    }

    // This is also O(n) but it is more cleaner
    public static bool ContainsDuplicateMethod_MoreCleaner(int[] nums)
    {
        var hashSet = new HashSet<int>();
        foreach (var num in nums)
        {
            if (!hashSet.Add(num))
            {
                return true;
            }
        }
        return false;
    }
}
