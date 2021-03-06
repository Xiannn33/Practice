using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
假设你正在爬楼梯。需要 n 阶你才能到达楼顶。
每次你可以爬 1 或 2 个台阶。你有多少种不同的方法可以爬到楼顶呢？
*/
namespace LeetCode070
{
    public class Solution
    {
        public int ClimbStairs(int n)
        {
            if (n <= 1) return n;
            int[] dp = new int[n+1];
            dp[1] = 1;dp[2] = 2;
            for(int i = 3; i <=n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution so = new Solution();
            Console.WriteLine(so.ClimbStairs(1));
            Console.ReadKey();
        }
    }
}
