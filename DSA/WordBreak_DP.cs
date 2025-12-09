using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src;
public class WordBreak_DP
{
    public bool WordBreak(string s, IList<string> wordDict)
    {
        if (s == null) return false;
        int n = s.Length;
        if (n == 0) return true;

        // Build hashset for O(1) lookup and compute min/max word lengths
        var dict = new HashSet<string>(wordDict ?? new List<string>());
        if (dict.Count == 0) return false;

        int minLen = int.MaxValue, maxLen = 0;
        foreach (var w in dict)
        {
            if (w == null) continue;
            minLen = Math.Min(minLen, w.Length);
            maxLen = Math.Max(maxLen, w.Length);
        }

        // dp[i] = can form prefix s[0..i-1]
        var dp = new bool[n + 1];
        dp[0] = true;

        for (int i = 1; i <= n; i++)
        {
            // only consider word lengths within [minLen, maxLen]
            int start = Math.Max(0, i - maxLen);
            int stop = i - minLen; // inclusive
            for (int j = start; j <= stop; j++)
            {
                if (!dp[j]) continue;                       // prefix must be doable
                int len = i - j;
                // substring s[j..i-1]
                string sub = s.Substring(j, len);
                if (dict.Contains(sub))
                {
                    dp[i] = true;
                    break;
                }
            }
        }

        return dp[n];
    }

    public static void Test_WordBreak_DP()
    {
        var solver = new WordBreak_DP();
        var result1 = solver.WordBreak("leetcode", new List<string> { "leet", "code" });
        Console.WriteLine(result1); // True
        var result2 = solver.WordBreak("applepenapple", new List<string> { "apple", "pen" });
        Console.WriteLine(result2); // True
        var result3 = solver.WordBreak("catsandog", new List<string> { "cats", "dog", "sand", "and", "cat" });
        Console.WriteLine(result3); // False
    }
}
