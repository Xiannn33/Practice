using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//给定一个不含重复数字的数组 nums ，返回其 所有可能的全排列 。你可以 按任意顺序 返回答案。
namespace LeetCode046
{
    public class Solution
    {
        IList<IList<int>> res = new List<IList<int>>();
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<int> s = new List<int>();
            BackTrack(nums, s);
            return res;
        }
        public void BackTrack(int[] nums,  IList<int> s)
        {
            if (s.Count == nums.Length)
            {
                res.Add(new List<int>(s));
                return;
            }
            else
            {
                for(int i = 0; i < nums.Length; i++)
                {
                    if (s.Contains(nums[i]))
                        continue;
                    s.Add(nums[i]);
                    BackTrack(nums, s);
                    s.RemoveAt(s.Count - 1);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution so = new Solution();
            int[] nums = { 1, 2, 3 };
            foreach(IList<int> i in so.Permute(nums))
            {
                foreach(int k in i)
                    Console.Write(k);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
