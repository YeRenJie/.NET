using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayBinaryTree<string> tree = new ArrayBinaryTree<string>(3, "汉献帝");
            tree.Insert(1, "刘备", true);
            tree.Insert(1, "曹操", false);
            tree.Insert(2, "关羽", true);
            tree.Insert(2, "张飞", false);
            tree.Insert(3, "张辽", true);
            tree.Insert(3, "许褚", false);
            Console.WriteLine("按层次遍历二叉树：");
            tree.FindByLevel();
        }
    }
}
