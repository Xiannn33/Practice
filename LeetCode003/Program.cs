using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//给定一个字符串 s ，请你找出其中不含有重复字符的 最长子串 的长度。
namespace LeetCode003
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int max = 0;
            Queue<char> q = new Queue<char>();
            foreach(var i in s)
            {
                while (q.Contains(i))
                    q.Dequeue();
                q.Enqueue(i);
                if (q.Count > max)
                    max = q.Count;
            }
            return max;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Solution so = new Solution();
            string s1 = "abcabcbb";
            Console.WriteLine(s1+" "+so.LengthOfLongestSubstring(s1).ToString());
            string s2 = "pwwkew";
            Console.WriteLine(s2 + " " + so.LengthOfLongestSubstring(s2).ToString());
            Console.ReadKey();
        }
    }
}
