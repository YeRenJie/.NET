using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec3
{
    public class BinaryNode<T>
    {
        private T data;//数据元素
        private BinaryNode<T> left, right;//分别指向左、右孩子
        public T Data
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }
        public BinaryNode<T> Left
        {
            get
            {
                return this.left;
            }
            set
            {
                this.left = value;
            }
        }
        public BinaryNode<T> Right
        {
            get
            {
                return this.right;
            }
            set
            {
                this.right = value;
            }
        }
        public BinaryNode()
        {
            data = default(T);
            left = right = null;
        }
        public BinaryNode(T obj)
        {
            data = obj;
            this.left = this.right = null;
        }
        public BinaryNode(T data, BinaryNode<T> left, BinaryNode<T> right)
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }

        public override string ToString()
        {
            return this.data + "";
        }
    }

}
