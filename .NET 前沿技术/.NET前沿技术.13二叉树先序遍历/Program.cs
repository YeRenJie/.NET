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
            BinaryNode<char> root = new BinaryNode<char>('A');
            LinkBinaryTree<char> tree = new LinkBinaryTree<char>(root);
            tree.InsertLNode('B', root);
            tree.InsertRNode('E', root);
            tree.InsertRNode('C', root.Left);
            tree.InsertRNode('F', root.Right);
            tree.InsertLNode('G', root.Right.Right);
            Console.WriteLine("使用递归算法，进行二叉树先序遍历：");
            tree.PreOrder(root);
            Console.WriteLine("\r\n*******************");
            Console.WriteLine("使用非递归算法，进行二叉树先序遍历：");
            tree.IterPreOrder(root);
        }
    }
}
