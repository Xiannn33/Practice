using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 给定一个长度为 n 的整数数组 arr ，它表示在 [0, n - 1] 范围内的整数的排列。
 我们将 arr 分割成若干 块 (即分区)，并对每个块单独排序。将它们连接起来后，使得连接的结果和按升序排序后的原数组相同。
 返回数组能分成的最多块数量。
*/
namespace LeetCode769
{
    public class Solution
    {
        public int MaxChunksToSorted(int[] arr)
        {
            int count = 0;
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                max = Math.Max(max, arr[i]);
                if (max == i) count++;
            }
            return count;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution so = new Solution();
            int[] arr = { 1,2,0,3};
            Console.WriteLine(so.MaxChunksToSorted(arr));
            Console.ReadKey();
        }
    }
}
