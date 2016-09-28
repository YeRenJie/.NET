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
            BinaryNode<string> root = new BinaryNode<string>("汉献帝");
            LinkBinaryTree<string> tree = new LinkBinaryTree<string>(root);
            tree.InsertLNode("刘备", root);
            tree.InsertRNode("曹操", root);
            Console.WriteLine("根结点的左子结点为："+tree.GetLChild(root));
        }
    }
}
