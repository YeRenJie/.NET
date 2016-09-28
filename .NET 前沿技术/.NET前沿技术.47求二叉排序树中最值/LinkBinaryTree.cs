using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec2
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
        public int FindMin()
        {
            BinaryNode<int> current = root;
            while (current.Left != null)
                current = current.Left;
            return current.Data;
        }
        public int FindMax()
        {
            BinaryNode<int> current = root;
            while (current.Right != null)
                current = current.Right;
            return current.Data;
        }

    }

}
