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
        //查找指定结点
        public bool Contains(int n, BinaryNode<int> root)
        {
            if (root == null)
            {
                return false;
            }
            int compare = n.CompareTo(root.Data);
            if (compare > 0)
            {
                if (root.Right != null)
                {
                    return Contains(n, root.Right);
                }
                else
                {
                    return false;
                }
            }
            else if (compare < 0)
            {
                if (root.Left != null)
                {
                    return Contains(n, root.Left);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
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
        public bool Remove(int number)
        {
            root = Remove(number, this.root);
            if (root != null)
            {
                return true;
            }
            return false;
        }

        private BinaryNode<int> Remove(int name, BinaryNode<int> root)
        {
            int compare = root.Data.CompareTo(name);
            if (compare == 0)
            {
                if (root.Frequency > 1)
                {
                    root.Frequency--;
                }
                else
                {
                    if (root.Left == null && root.Right == null)
                    {
                        root = null;
                    }
                    else if (root.Left != null && root.Right == null)
                    {
                        root = root.Left;
                    }
                    else if (root.Left == null && root.Right != null)
                    {
                        root = root.Right;
                    }
                    else
                    {
                        BinaryNode<int> newRoot = root.Left;
                        while (newRoot.Left != null)
                        {
                            newRoot = newRoot.Left;// 找到左子树的最大节点
                        }
                        root.Data = newRoot.Data;
                        root.Left = Remove(root.Data, root.Left);
                    }
                }
            }
            else if (compare > 0)
            {
                if (root.Left != null)
                {
                    root.Left = Remove(name, root.Left);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                if (root.Right != null)
                {
                    root.Right = Remove(name, root.Right);
                }
                else
                {
                    return null;
                }
            }
            return root;
        }
    }

}
