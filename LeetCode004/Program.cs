using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
