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
            BinaryNode<char> l1=new BinaryNode<char>('F');
		BinaryNode<char> l2=new BinaryNode<char>('E',null,l1);
		
		BinaryNode<char> r1=new BinaryNode<char>('G');
		BinaryNode<char> r2=new BinaryNode<char>('D',r1,null);
		BinaryNode<char> r3=new BinaryNode<char>('C',null,r2);
		
		BinaryNode<char> t1=new BinaryNode<char>('B',l2,r3);
		
		BinaryNode<char> root=new BinaryNode<char>('A',t1,null);
		LinkBinaryTree<char> tree=new LinkBinaryTree<char>(root);

		Console.WriteLine("该二叉树的深度为："+tree.Height(root));
		tree.Leaf(root);
        Console.WriteLine("该二叉树的叶子结点的个数为：" + tree.NumLeaf);
        }
    }
}
