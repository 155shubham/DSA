using System.Security.AccessControl;
using System.Text;

namespace DSA;

// will not work for all cases
public class LongestSubstringWithoutRepeatingCharacters
{
    public static int LengthOfLongestSubstring(string s)
    {
        StringBuilder sb = new StringBuilder();
        int maxLength = 0;
        int substringLength = 0;
        for (int i =0; i< s.Length; i++)
        {
            if (!sb.ToString().Contains(s[i]))
            {
                sb.Append(s[i]);
                substringLength++;
            }
            else
            {
                if (substringLength > maxLength)
                {
                    maxLength = substringLength;
                }
                substringLength = 0;
                sb.Clear();
                sb.Append(s[i]);
                substringLength++;
            }
        }
        return maxLength;
    }
    public static int LengthOfLongestSubstring_1(string s)
    {
        if (string.IsNullOrEmpty(s))
            return 0;

        Dictionary<char, int> lastindex = new Dictionary<char, int>();
        int maxLength = 0;
        int left = 0;

        for (int right =0; right< s.Length; right++)
        {
            char c = s[right];

            if (lastindex.ContainsKey(c) && lastindex[c] >= left)
                left = lastindex[c]+1;
            lastindex[c] = right;

            int windowLength = right-left + 1;

            if (windowLength > maxLength)
                maxLength = windowLength;

        }
        return maxLength;
    }

    public static void TestLengthOfLongestSubstring()
    {
        //int res = LengthOfLongestSubstring_1("abcabcda"); //4
        int res = LengthOfLongestSubstring_1("abcb");
        //int res = LengthOfLongestSubstring_1("dvdf");
        //int res = LengthOfLongestSubstring_1("abcd");
        Console.WriteLine(res);
    }
}
