using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec1
{
    public class SingleLinkedList<T> : ILinearList<T>
    {

        private Node<T> head; // 头指针
        private int length; // 单链表中数据元素个数

        public SingleLinkedList()
        {
            head = new Node<T>();
            length = 0;
        }

        public bool Add(T element)
        {
            return this.Insert(this.length + 1, element);
        }

        // 插入
        public bool Insert(int index, T element)
        {
            Node<T> node = new Node<T>(element);

            if (index < 1 || index > this.length + 1)
                throw new IndexOutOfRangeException("位置不正确");
            if (index == 1)
            {
                node.Next = this.head.Next;
                this.head.Next = node;
            }
            else if (index == this.length + 1)
            {
                Node<T> temp = head;
                while (null != temp.Next)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            else
            {
                Node<T> temp = head;
                for (int i = 1; i < index; i++)
                {
                    temp = temp.Next;
                }
                node.Next = temp.Next;
                temp.Next = node;
            }
            this.length++;
            return true;
        }

        public bool IsEmpty()
        {
            return this.length == 0;
        }

        public int Size()
        {
            return this.length;
        }

        public bool Remove(int index)
        {
            return true;
        }

        public void Set(int index, T element)
        {
        }

        public void Clear()
        {
        }

        public int Contains(T element)
        {
            return 0;
        }

        public T Get(int index)
        {
            return default(T);
        }

        public override string ToString()
        {
            string str = "";
            Node<T> temp = head;
            while (null != temp.Next)
            {
                str += " " + temp.Next.Data;
                temp = temp.Next;
            }
            return str;
        }
    }

}
