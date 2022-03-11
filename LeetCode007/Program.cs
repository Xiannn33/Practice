using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
给你一个 32 位的有符号整数 x ，返回将 x 中的数字部分反转后的结果。
如果反转后整数超过 32 位的有符号整数的范围 [−2^31,  2^31 − 1] ，就返回 0。
假设环境不允许存储 64 位整数（有符号或无符号）。
*/
namespace LeetCode007
{
    public class Solution
    {
        public int Reverse(int x)
        {
            int sum = 0;
            while (x != 0)
            {
                if (sum > int.MaxValue / 10 || sum < int.MinValue / 10)
                {
                    return 0;
                }
                sum = sum * 10 + x % 10;
                x = x / 10;
            }
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution so = new Solution();
            Console.WriteLine(so.Reverse(-2147483412));
            Console.ReadKey();
        }
    }
}
