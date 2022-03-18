using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
给你一个字符串 s 和一个字符规律 p，请你来实现一个支持 '.' 和 '*' 的正则表达式匹配。
    '.' 匹配任意单个字符
    '*' 匹配零个或多个前面的那一个元素
所谓匹配，是要涵盖 整个 字符串 s的，而不是部分字符串。
*/
namespace LeetCode010
{
    public class Solution
    {
        public bool IsMatch(string s, string p)
        {
            if (s == null || p == null)
                return false;
            bool[,] dp = new bool[s.Length + 1, p.Length + 1];
            dp[0, 0] = true;
            for (int i = 1; i <= p.Length; i++)
            {
                if (p[i - 1] == '*' && dp[0, i - 2])
                    dp[0, i] = true;
            }
            for (int i = 1; i <= s.Length; i++)
            {
                for (int j = 1; j <= p.Length; j++)
                {
                    if (s[i - 1] == p[j - 1] || p[j - 1] == '.')
                        dp[i, j] = dp[i - 1, j - 1];
                    else if (p[j - 1] == '*')
                    {
                        if (dp[i, j - 2])
                            dp[i, j] = true;
                        else
                        {
                            if ((p[j - 2] == s[i - 1] || p[j - 2] == '.') && dp[i - 1, j])
                                dp[i, j] = true;
                        }
                    }
                }
            }
            return dp[s.Length, p.Length];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution so = new Solution();
            string s = "ab", p = ".*";
            Console.WriteLine(so.IsMatch(s, p));
            Console.ReadKey();
        }
    }
}
