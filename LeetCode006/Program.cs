using System;
using System.Text;
/*
将一个给定字符串 s 根据给定的行数 numRows ，以从上往下、从左到右进行 Z 字形排列。
比如输入字符串为 "PAYPALISHIRING" 行数为 3 时，排列如下：
P   A   H   N
A P L S I I G
Y   I   R
之后，你的输出需要从左往右逐行读取，产生出一个新的字符串，比如："PAHNAPLSIIGYIR"。
*/
namespace LeetCode006
{
    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1 || numRows >= s.Length)
            {
                return s;
            }
            StringBuilder stringBuilder = new StringBuilder();
            int numLines = s.Length / (2 * numRows - 2) * (numRows - 1);
            numLines = s.Length % ((2 * numRows - 2)) == 0 ? numLines : numLines + (numRows - 1);
            char[,] arr = new char[numRows, numLines];
            int r = 0; int l = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                arr[r, l] = s[i];
                if (i % (2 * numRows - 2) < numRows - 1)
                {
                    ++r;
                }
                else
                {
                    --r;
                    ++l;
                }
            }
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numLines; j++)
                {
                    if (arr[i, j] != 0)
                        stringBuilder.Append(arr[i, j]);
                }
            }
            return stringBuilder.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution so = new Solution();
            string s = so.Convert("pmlirnjvgaedetokjcljsnaqzrzuacbpqnxjciekllnpedbpfoyyczqdspxstbkjqjtsuzcfkrwrxygcmfaqgttyitteudnkmgegginsbkjyksbyxdrfwkfhfylzbalqjpyrxmjzyvxknyimezramyjrxwtaxesgurxtfiudfspssxgwzzzlykevhxxgeqmahltovorbiivcfczgdatbkaytxwzdondvazjwpczxkwzraaaecthnvggteiysvcpwdausevrqrsjstjwxffkaltvrbulyyaudcqvglowdggxbpvzwalxogufhotioteryvoeicbnljkoahnxibwwhqdrhwzxsfpqadujixytijjjqziaaewjwccfyddqjuijzduhctclemwwlexnkvwizzoyctqlnzxoetyioavsorrbvoqflpqlqgluzdgoefckaatpdohtgaxdqnlcebpuhapgfxwkcaucbnrgebbmdypuoaysdnnkpesuboedrbhuqbauedghcydsabmeoboffjcgzglqjvkawmucqdlubpmbqyfhcwmhfoogxzxguhiswdwmiigjzumpuuywsnezd", 479);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
