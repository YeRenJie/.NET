using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ary = new int[] { 63, 55, 90, 42, 58, 70, 98, 10, 45, 67, 83 };
            BinarySortTree tree = new BinarySortTree();
            for (int i = 0; i < ary.Length; i++)
                tree.InsertIntoTree(ary[i]);

            int min = tree.FindMin();
            Console.WriteLine("该树中最小值为：" + min);
            int max = tree.FindMax();
            Console.WriteLine("该树中最小值为：" + max);
        }
    }
}
