using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 给你两个 非空 的链表，表示两个非负的整数。它们每位数字都是按照 逆序 的方式存储的，并且每个节点只能存储 一位 数字。

请你将两个数相加，并以相同形式返回一个表示和的链表。

你可以假设除了数字 0 之外，这两个数都不会以 0 开头。
*/
namespace LeetCode002
{
    namespace LeetCode_0002
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public class Program
        {
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                int val = 0;
                ListNode preNode = new ListNode(0);
                ListNode lastNode = preNode;
                while (l1 != null || l2 != null || val != 0)
                {
                    val = val + (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val);
                    lastNode.next = new ListNode(val % 10);
                    lastNode = lastNode.next;
                    val = val / 10;
                    l1 = l1?.next;
                    l2 = l2?.next;
                }
                return preNode.next;
            }
        }

        class Test
        {
            static ListNode GenerateList(int[] vals)
            {
                ListNode res = null;
                ListNode last = null;
                foreach (var val in vals)
                {
                    if (res == null)
                    {
                        res = new ListNode(val);
                        last = res;
                    }
                    else
                    {
                        last.next = new ListNode(val);
                        last = last.next;
                    }
                }
                return res;
            }

            static void PrintList(ListNode l)
            {
                while (l != null)
                {
                    Console.Write($"{l.val}, ");
                    l = l.next;
                }
                Console.WriteLine("");
            }

            static void Main()
            {
                var l1 = GenerateList(new int[] { 1, 5, 7 });
                var l2 = GenerateList(new int[] { 9, 8, 2, 9 });
                PrintList(l1);
                PrintList(l2);
                Program s = new Program();
                var sum = s.AddTwoNumbers(l1, l2);
                PrintList(sum);
                Console.ReadKey();
            }
        }
    }
}
