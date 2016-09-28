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
            BinaryNode<char> root = new BinaryNode<char>('A');
            LinkBinaryTree<char> tree = new LinkBinaryTree<char>(root);
            tree.InsertLNode('B', root);
            tree.InsertRNode('E', root);
            tree.InsertRNode('C', root.Left);
            tree.InsertLNode('D', root.Left.Right);
            Console.WriteLine("使用递归算法，进行二叉树中序遍历：");
            tree.InOrder(root);
            Console.WriteLine("\r\n*******************");
            Console.WriteLine("使用非递归算法，进行二叉树中序遍历：");
            tree.IterInOrder(root);
        }
    }
}
