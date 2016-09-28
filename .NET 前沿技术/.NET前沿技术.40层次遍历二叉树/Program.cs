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
            BinaryNode<string> root = new BinaryNode<string>("汉献帝");
            LinkBinaryTree<string> tree = new LinkBinaryTree<string>(root);
            tree.InsertLNode("刘备", root);
            tree.InsertRNode("曹操", root);
            tree.InsertLNode("关羽", root.Left);
            tree.InsertRNode("张飞", root.Left);
            tree.InsertLNode("张辽", root.Right);
            tree.InsertRNode("许褚", root.Right);
            Console.WriteLine("按层次遍历二叉树：");
            tree.FindNodeByLevel();
        }
    }
}
