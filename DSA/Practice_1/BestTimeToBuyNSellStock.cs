using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Practice_1;
public class BestTimeToBuyNSellStock
{
    // o(n^2) time complexity and o(1) space complexity
    public static int MaxProfit(int[] prices)
    {
        if (prices == null)
        {
            return 0;
        }
        int maxProfit1 = 0;
        for(int i=0; i<prices.Length;i++)
        {
            int j = i+1;
            int maxProfit2 = 0;
            while (j < prices.Length)
            {
                var profit = prices[j] - prices[i];
                if (profit > maxProfit2)
                {
                    maxProfit2 = profit;
                }
                j++;
            }
            if (maxProfit2 > maxProfit1)
            {
                maxProfit1 = maxProfit2;
            }
        }
        return maxProfit1;
    }

    // O(n) time complexity and o(1) space complexity
    public static int MaxProfit_With_BetterApproach(int[] prices)
    {
        if (prices == null)
        {
            return 0;
        }
        int maxProfit = 0;
        int minPrice = int.MaxValue;
        foreach (var price in prices)
        {
            if (price < minPrice)
            {
                minPrice = price;
            }
            else
            {
                var profit = price - minPrice;
                if (profit > maxProfit)
                {
                    maxProfit = profit;
                }
            }
        }
        return maxProfit;
    }

}
