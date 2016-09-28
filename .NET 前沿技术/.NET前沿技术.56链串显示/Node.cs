using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec3
{
    public class Node
    {
        private char data;

        private Node next;

        public Node()
        {
            next = null;
        }

        public Node(char item)
        {
            data = item;
            next = null;
        }

        // 构造结点，指定数据元素和后继结点
        public Node(char item, Node next)
        {
            this.data = item;
            this.next = next;
        }

        public char Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }
    }

}
