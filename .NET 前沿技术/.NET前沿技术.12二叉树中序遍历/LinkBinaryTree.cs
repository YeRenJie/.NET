﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec2
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

        // 中序遍历递归算法
        public void InOrder(BinaryNode<T> p)
        {
            if (p != null)
            {
                InOrder(p.Left);
                Console.Write(p.Data + " ");
                InOrder(p.Right);
            }
        }

        // 中序遍历非递归算法
        public void IterInOrder(BinaryNode<T> p)
        {
            Stack<BinaryNode<T>> s1 = new Stack<BinaryNode<T>>();
            while (p != null || s1.Count != 0)
            {
                if (p != null)
                {
                    s1.Push(p);
                    p = p.Left;
                }
                else
                { // p为空且栈非空时
                    p = s1.Pop();
                    Console.Write(p.Data + " ");
                    p = p.Right;
                }
            }
        }

    }

}
