using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
给你一个整数 x ，如果 x 是一个回文整数，返回 true ；否则，返回 false 。
回文数是指正序（从左向右）和倒序（从右向左）读都是一样的整数。
*/
namespace LeetCode009
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            int sum = 0;
            int tmp = x;
            while (tmp != 0)
            {
                sum = sum * 10 + tmp % 10;
                tmp = tmp / 10;
            }
            return x == sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution so = new Solution();
            Console.WriteLine(so.IsPalindrome(-121));
            Console.ReadKey();
        }
    }
}
