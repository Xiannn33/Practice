using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode094
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class Solution
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            Fun(root, list);
            return list;
        }
        public void Fun(TreeNode root, List<int> list)
        {
            if (root == null)
            {
                return;
            }
            Fun(root.left, list);
            list.Add(root.val);
            Fun(root.right, list);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode t = new TreeNode(1);
            t.right = new TreeNode(2);
            t.right.left = new TreeNode(3);
            t.right.right = new TreeNode(4);
            Solution so = new Solution();
            foreach (int i in so.InorderTraversal(t))
                Console.Write(i);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
