using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec4
{
    public class BinarySortTree
    {
        private BinaryNode<int> root;
        public BinaryNode<int> Root
        {
            get { return this.root; }
        }
        public BinarySortTree()
        {
            root = null;
        }

        public BinarySortTree(int item)
        {
            root = new BinaryNode<int>(item);
        }

        public BinarySortTree(BinaryNode<int> root)
        {
            this.root = root;
        }

        // 先序遍历递归算法
        public void PreOrder(BinaryNode<int> p)
        {
            if (p != null)
            {
                Console.Write(p.Data + " ");
                PreOrder(p.Left);
                PreOrder(p.Right);
            }
        }

        // 中序遍历递归算法
        public void InOrder(BinaryNode<int> p)
        {
            if (p != null)
            {
                InOrder(p.Left);
                Console.Write(p.Data + " ");
                InOrder(p.Right);
            }
        }
        // 层次遍历
        public void FindNodeByLevel()
        {
            Queue<BinaryNode<int>> temp = new Queue<BinaryNode<int>>();
            BinaryNode<int> p = root;

            while (p != null)
            {
                Console.Write(p + " ");
                if (p.Left != null)
                    temp.Enqueue(p.Left);
                if (p.Right != null)
                    temp.Enqueue(p.Right);
                if (temp.Count == 0)
                    break;
                p = temp.Dequeue();
            }
        }
        //插入结点构成二叉排序树
        public void InsertIntoTree(int data)
        {
            BinaryNode<int> newNode = new BinaryNode<int>(data);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                BinaryNode<int> currentNode = root;
                BinaryNode<int> parentNode = root;
                while (currentNode != null)
                {
                    if (data < currentNode.Data)
                    {
                        parentNode = currentNode;
                        currentNode = currentNode.Left;
                        if (currentNode == null)
                            parentNode.Left = newNode;
                    }
                    else
                    {
                        parentNode = currentNode;
                        currentNode = currentNode.Right;
                        if (currentNode == null)
                            parentNode.Right = newNode;
                    }
                }
            }
        }

    }

}
