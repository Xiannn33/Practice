using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//给定一个仅包含数字 2-9 的字符串，返回所有它能表示的字母组合。答案可以按 任意顺序 返回。
namespace LeetCode017
{
    public class Solution
    {
        IList<string> res = new List<string>();
        public IList<string> LetterCombinations(string digits)
        {
            string[] s = { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            BackTrack(new StringBuilder(), digits, s, 0);
            if (res[0] == "")
                res.Clear();
            return res;

        }
        public void BackTrack(StringBuilder str,string digits, string[] s,int index)
        {
            if (index == digits.Length)
            {
                res.Add(str.ToString());
                return;
            }
            else
            {
                int k = int.Parse(digits[index].ToString());
                string s1 = s[k];
                for(int i = 0; i < s1.Length; i++)
                {
                    str.Append(s1[i]);
                    BackTrack(str, digits, s, index + 1);
                    str.Remove(str.Length - 1, 1);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution so = new Solution();
            IList<string> res = so.LetterCombinations("23");
            foreach(string i in res)
                Console.Write(i);
            Console.ReadKey();
        }
    }
}
