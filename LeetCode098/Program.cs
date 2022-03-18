using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
给你一个二叉树的根节点 root ，判断其是否是一个有效的二叉搜索树。
有效 二叉搜索树定义如下：
    节点的左子树只包含 小于 当前节点的数。
    节点的右子树只包含 大于 当前节点的数。
    所有左子树和右子树自身必须也是二叉搜索树。
 */
namespace LeetCode098
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
    public class Solution1
    {
        public bool IsValidBST(TreeNode root)
        {
            if (root == null) return true;
            List<int> list = new List<int>();
            InorderTraversal(root, list);
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] >= list[i + 1])
                    return false;
            }
            return true;
        }
        public void InorderTraversal(TreeNode root, List<int> list)
        {
            if (root == null) return;
            InorderTraversal(root.left, list);
            list.Add(root.val);
            InorderTraversal(root.right, list);
        }
    }

    public class Solution
    {
        long pre = long.MinValue;
        public bool IsValidBST(TreeNode root)
        {
            if (root == null) return true;
            if (!IsValidBST(root.left))
                return false;
            if (root.val <= pre)
                return false;
            pre = root.val;
            return IsValidBST(root.right);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode t = new TreeNode(2);
            t.left = new TreeNode(1);
            t.right = new TreeNode(3);
            t.right.left = new TreeNode(3);
            t.right.right = new TreeNode(6);
            Solution1 so = new Solution1();
            Console.WriteLine(so.IsValidBST(t));
            Console.ReadKey();
        }
    }
}
