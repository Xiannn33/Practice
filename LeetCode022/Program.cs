using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//数字 n 代表生成括号的对数，请你设计一个函数，用于能够生成所有可能的并且 有效的 括号组合。
namespace LeetCode022
{
    public class Solution
    {
        IList<string> arr = new List<string>();
        public IList<string> GenerateParenthesis(int n)
        {
            if (n <= 0)
            {
                return arr;
            }
            StringBuilder s = new StringBuilder();
            getParenthesis(s, n, n);
            return arr;
        }
        private void getParenthesis(StringBuilder str, int left, int right)
        {
            if (left == 0 && right == 0)
            {
                arr.Add(str.ToString());
                return;
            }
            if (left == right)
            {
                str.Append("(");
                getParenthesis(str, left - 1, right);
                str.Remove(str.Length - 1, 1);
            }
            else if (left < right)
            {
                if (left > 0)
                {
                    str.Append("(");
                    getParenthesis(str, left - 1, right);
                    str.Remove(str.Length - 1, 1);
                }
                str.Append(")");
                getParenthesis(str, left, right - 1);
                str.Remove(str.Length - 1, 1);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution so = new Solution();
            IList<string> s = so.GenerateParenthesis(2);
            foreach(string i in s)
                Console.Write(i);
            Console.ReadKey();
        }
    }
}
