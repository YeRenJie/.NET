using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec3
{
    public class MyLinkString : IString
    {
        private Node head;
        private int count;

        public MyLinkString()
        {
            head = null;
            count = 0;
        }

        public MyLinkString(char[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                AddNode(str[i]);
                count++;
            }
        }

        public Node AddNode(char obj)
        {
            Node node = new Node(obj);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.Next != null)
                    temp = temp.Next;
                temp.Next = node;
            }
            return head;
        }

        public char CharAt(int index)
        {
            if (index <= 0 || index > count)
                throw new IndexOutOfRangeException("索引超出范围");

            Node temp = head;
            for (int i = 1; i < index; i++)
                temp = temp.Next;
            return temp.Data;
        }

        public IString Concat(IString str)
        {
            return null;
        }

        public int IndexOf(IString pattern)
        {
            return 0;
        }

        public int Length()
        {
            return this.count;
        }

        public IString Substring(int begin, int length)
        {
            return null;
        }

    }

}
