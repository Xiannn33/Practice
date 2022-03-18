using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
给你一个 n x n 的 方形 整数数组 matrix ，请你找出并返回通过 matrix 的下降路径 的 最小和 。
下降路径:
可以从第一行中的任何元素开始，并从每一行中选择一个元素。
在下一行选择的元素和当前行所选元素最多相隔一列（即位于正下方或者沿对角线向左或者向右的第一个元素）。
具体来说，位置 (row, col) 的下一个元素应当是 (row + 1, col - 1)、(row + 1, col) 或者 (row + 1, col + 1) 。
*/
namespace LeetCode931
{
    public class Solution
    {
        public int MinFallingPathSum(int[][] matrix)
        {
            int min = int.MaxValue;
            for (int i = matrix.Length - 2; i >= 0; i--)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    if (j - 1 < 0)
                        matrix[i][j] = matrix[i][j] + Math.Min(matrix[i + 1][j], matrix[i + 1][j + 1]);
                    else if (j + 1 > matrix.Length - 1)
                        matrix[i][j] = matrix[i][j] + Math.Min(matrix[i + 1][j - 1], matrix[i + 1][j]);
                    else
                    {
                        int tmp = matrix[i + 1][j - 1] > matrix[i + 1][j] ? matrix[i + 1][j] : matrix[i + 1][j - 1];
                        matrix[i][j] = matrix[i][j] + Math.Min(tmp, matrix[i + 1][j + 1]);
                    }
                }
            }
            for(int i = 0; i < matrix.Length; i++)
            {
                if (min > matrix[0][i])
                    min = matrix[0][i];
            }
            return min;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution so = new Solution();
            int[][] matrix = new int[3][] { new int[] { 2, 1, 3 }, new int[] { 6, 5, 4 }, new int[] { 7, 8, 9 } };
            Console.WriteLine(so.MinFallingPathSum(matrix));
            Console.ReadKey();
        }
    }
}
