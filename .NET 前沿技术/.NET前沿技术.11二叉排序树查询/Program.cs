using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ary = new int[] { 5, 3, 8, 2, 4, 7, 9, 1 };
            BinarySortTree tree = new BinarySortTree();
            for (int i = 0; i < ary.Length; i++)
                tree.InsertIntoTree(ary[i]);
            if (tree.Contains(6, tree.Root))
                Console.WriteLine("该二叉树中包含数字6");
            else
                Console.WriteLine("该二叉树中不包含6");
        }
    }
}
