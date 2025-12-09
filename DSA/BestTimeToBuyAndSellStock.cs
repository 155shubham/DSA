using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src;
public class BestTimeToBuyAndSellStock
{
    // O(n^2) time complexity
    public static int MaxProfit(int[] prices)
    {
        var currentProfit = 0;
        for (int i =0; i< prices.Length; i++)
        {
            for (int j=i+1; j<prices.Length; j++)
            {
                var diff = prices[j] - prices[i];
                
                if (diff > currentProfit)
                {
                    currentProfit = diff;
                }
            }
        }
        return currentProfit;
    }

    // O(n) time complexity
    public static int MaxProfit_1(int[] prices)
    {
        var minPrice = int.MaxValue;
        var maxProfit = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
                minPrice = prices[i];

            if (prices[i] - minPrice > maxProfit)
                maxProfit = prices[i] - minPrice;

        }
        return maxProfit;
    }

    public static void TestMaxProfit()
    {
        var result = MaxProfit(new int[] { 7,1,5,6,3,4 });
        Console.WriteLine($"{result}");
    }
}
