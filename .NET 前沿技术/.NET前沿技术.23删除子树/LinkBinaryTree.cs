using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec2
{
    public class LinkBinaryTree<T>
    {
        private BinaryNode<T> root;// 头指针

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

        // 判断为空
        public bool IsEmpty()
        {
            return root == null;
        }

        // 判断是否是叶子结点
        public bool IsLeaf(BinaryNode<T> p)
        {
            if (p != null && p.Left == null && p.Right == null)
                return true;
            else
                return false;
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

        // 返回左子结点
        public BinaryNode<T> GetLChild(BinaryNode<T> temp)
        {
            if (IsEmpty() || temp == null)
                throw new Exception("操作失败");
            return temp.Left;
        }

        // 返回右子结点
        public BinaryNode<T> GetRChild(BinaryNode<T> temp)
        {
            if (IsEmpty() || temp == null)
                throw new Exception("操作失败");
            return temp.Right;
        }
        // 删除左子树
        public BinaryNode<T> RemoveLNode(BinaryNode<T> p)
        {
            if (IsEmpty())
                throw new Exception("操作失败");
            BinaryNode<T> temp = null;
            if (p != null && p.Left != null)
            {
                temp = p.Left;
                p.Left=null;
            }
            return temp;
        }

        // 删除右子树
        public BinaryNode<T> RemoveRNode(BinaryNode<T> p)
        {
            if (IsEmpty())
                throw new Exception("操作失败");
            BinaryNode<T> temp = null;
            if (p != null && p.Right != null)
            {
                temp = p.Right;
                p.Right=null;
            }
            return temp;
        }
        // 层次遍历
        public void FindNodeByLevel()
        {
            Queue<BinaryNode<T>> temp = new Queue<BinaryNode<T>>();
            BinaryNode<T> p = root;

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
    }

}
