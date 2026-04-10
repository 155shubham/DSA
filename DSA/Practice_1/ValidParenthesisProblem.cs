using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Practice_1;
public class ValidParenthesisProblem
{
    public static bool IsValidString(string s)
    {
        var stck = new Stack<char>();
        var map = new Dictionary<char, char>()
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };
        foreach (char c in s)
        {
            if (map.ContainsValue(c)) //opening bracket
            {
                stck.Push(c);
            }
            else //closing bracket
            {
                if (stck.Count == 0)
                {
                    return false;
                }

                var top = stck.Pop();
                if (top != map[c])
                {
                    return false;
                }
            }
        }
        return stck.Count==0;
    }
}
