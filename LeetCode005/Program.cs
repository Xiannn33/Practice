using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

//给你一个字符串 s，找到 s 中最长的回文子串。
//中心扩散
namespace LeetCode005
{
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
    class Program
    {
        static void Main(string[] args)
        {
            string s = "babad";
            Solution so = new Solution();
            Console.WriteLine(so.LongestPalindrome(s));
            Console.ReadKey();
        }
    }
}