using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec2
{
    public class Node<T>
    {

        private T data;

        private Node<T> next;

        public Node()
        {
            data = default(T);
            next = null;
        }

        public Node(T item)
        {
            data = item;
            next = null;
        }

        // 构造结点，指定数据元素和后继结点
        public Node(T item, Node<T> next)
        {
            this.data = item;
            this.next = next;
        }

        public T Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public Node<T> Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

    }

}
