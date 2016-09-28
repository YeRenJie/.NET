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
        // 统计树的深度
        public int Height(BinaryNode<T> root)
        {
            if (root == null)
                return 0;
            else
            {
                if (Height(root.Left) > Height(root.Right))
                    return Height(root.Left) + 1;
                else
                    return Height(root.Right) + 1;
            }
        }
        private int numLeaf = 0;
        public int NumLeaf
        {
            get { return this.numLeaf; }
        }

        // 统计叶子结点的个数
        public void Leaf(BinaryNode<T> root)
        {
            if (root == null)
                return;
            else
            {
                if (root.Left == null && root.Right == null)
                    numLeaf = numLeaf + 1;
                Leaf(root.Left);
                Leaf(root.Right);
            }
        }


    }

}
