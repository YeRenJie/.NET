using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ary = new int[] { 8, 5, 14, 10, 35 };
            BinarySortTree tree = new BinarySortTree();
            for (int i = 0; i < ary.Length; i++)
                tree.InsertIntoTree(ary[i]);
            Console.WriteLine("该二叉树先序遍历序列为：");
            tree.PreOrder(tree.Root);
            Console.WriteLine("\r\n***************");
            Console.WriteLine("该二叉树中序遍历序列为：");
            tree.InOrder(tree.Root);
            Console.WriteLine("\r\n***************");
            if (tree.Contains(14, tree.Root))
            {
                Console.WriteLine("该树中包含14");
                if (tree.Remove(14))
                {
                    Console.WriteLine("删除14后，该二叉树的先序遍历序列为：");
                    tree.PreOrder(tree.Root);
                    Console.WriteLine("\r\n***************");
                    Console.WriteLine("该二叉树中序遍历序列为：");
                    tree.InOrder(tree.Root);
                }
            }
            else
                Console.WriteLine("该树中不包含14");
        }
    }
}
