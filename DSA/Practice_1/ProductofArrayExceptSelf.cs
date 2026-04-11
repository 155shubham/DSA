using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Practice_1;
public class ProductofArrayExceptSelf
{
    public static int[] Find_ProductofArrayExceptSelf(int[] arr)
    {
        var result = new int[arr.Length];
        result[0] = 1;
        int left = 1;
        for (int i= 1; i < arr.Length; i++)
        {
            result[i] = result[i - 1] * arr[i-1];
        }
        int right = 1;
        for (int j = arr.Length-1; j >=0; j--)
        {
            if (j == arr.Length-1)
            {
                result[j] *= right;
                result[j] = result[j + 1] * arr[j + 1];
            }
            else
            {
                
            }
        }

        return result;

    }
}
