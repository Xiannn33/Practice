using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

//给你一个字符串 s，找到 s 中最长的回文子串。

namespace LeetCode005
{
    //中心扩散
    public class Solution
    {
        public string LongestPalindrome(string s)
        {

            string result = "";
            int end = 2 * s.Length - 1;
            for (int i = (end - 1) / 2, j = -1; i < end; i += j, j = -(Math.Abs(j) + 1) * (j / Math.Abs(j)))
            {
                double mid = i / 2.0d;
                int p = (int)(Math.Floor(mid));
                int q = (int)(Math.Ceiling(mid));
                while (p >= 0 && q < s.Length)
                {
                    if (s[p] != s[q]) break;
                    if (p == 0)
                    {
                        return result.Length > q - p + 1 ? result : s.Substring(p, q - p + 1);
                    }
                    p--; q++;
                }
                int len = q - p - 1;
                if (len > result.Length)
                    result = s.Substring(p + 1, len);
            }
            return result;
        }
    }

    //动态规划
    public class Solution1
    {
        public string LongestPalindrome(string s)
        {
            if (s.Length < 2)
                return s;
            int begin = 0;
            int maxLength = 0;
            bool[,] dp = new bool[s.Length, s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                dp[i, i] = true;
            }
            for (int L = 2; L <= s.Length; L++)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    int j = L + i - 1;
                    if (j >= s.Length)
                        break;
                    if (s[i] != s[j])
                        dp[i, j] = false;
                    else
                    {
                        if (j - i < 3)
                            dp[i, j] = true;
                        else
                        {
                            dp[i, j] = dp[i + 1, j - 1];
                        }
                    }
                    if (dp[i, j] && j - i + 1 > maxLength)
                    {
                        maxLength = j - i + 1;
                        begin = i;
                    }
                }
            }
            return s.Substring(begin, maxLength);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string s = "babac";
            Solution1 so = new Solution1();
            Console.WriteLine(so.LongestPalindrome(s));
            Console.ReadKey();
        }
    }
}