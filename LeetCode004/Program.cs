using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
给定两个大小分别为 m 和 n 的正序（从小到大）数组 nums1 和 nums2。请你找出并返回这两个正序数组的 中位数 。
算法的时间复杂度应该为 O(log (m+n)) 。
*/
namespace LeetCode004
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] nums = new int[nums1.Length + nums2.Length];
            nums1.CopyTo(nums, 0);
            nums2.CopyTo(nums, nums1.Length);
            Array.Sort(nums);
            int index = nums.Length / 2;
            if (nums.Length % 2 != 0)
            {
                return nums[index];
            }
            else
            {
                return (nums[index - 1] + nums[index]) / 2.0d;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 2 };
            int[] nums2 = new int[] { 3, 4 };
            Solution so = new Solution();
            Console.WriteLine(so.FindMedianSortedArrays(nums1, nums2));
            Console.ReadKey();
        }
    }
}