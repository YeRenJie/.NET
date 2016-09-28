using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec1
{
    public class LinkBinaryTree<T>
    {
        private BinaryNode<T> root;

        public LinkBinaryTree()
        {
            root = null;
        }

        public LinkBinaryTree(T item)
        {
            root = new BinaryNode<T>(item);
        }

        public LinkBinaryTree(BinaryNode<T> root)
        {
            this.root = root;
        }

        // 插入左子结点
        public bool InsertLNode(T val, BinaryNode<T> pn)
        {
            if (pn == null)
                throw new Exception("操作失败");
            BinaryNode<T> temp = new BinaryNode<T>(val);
            temp.Left = pn.Left;
            pn.Left = temp;
            return true;
        }

        // 插入右子结点
        public bool InsertRNode(T val, BinaryNode<T> pn)
        {
            if (pn == null)
                throw new Exception("操作失败");
            BinaryNode<T> temp = new BinaryNode<T>(val);
            temp.Right = pn.Right;
            pn.Right = temp;
            return true;
        }
        // 先序遍历递归算法
        public void PreOrder(BinaryNode<T> p)
        {
            if (p != null)
            {
                Console.Write(p.Data + " ");
                PreOrder(p.Left);
                PreOrder(p.Right);
            }
        }

        // 先序遍历非递归算法
        public void IterPreOrder(BinaryNode<T> p)
        {
            Stack<BinaryNode<T>> stack = new Stack<BinaryNode<T>>();
            if (p != null)
            {
                stack.Push(p);
                while (stack.Count != 0)
                {
                    p = stack.Pop();
                    Console.Write(p.Data + " ");
                    if (p.Right != null)
                        stack.Push(p.Right);
                    if (p.Left != null)
                        stack.Push(p.Left);
                }
            }
        }

    }

}
