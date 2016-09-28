using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec1
{
    public class QueryLink<T> : IQueue<T>
    {
        private Node<T> front;// 队头指针
        private Node<T> rear; // 队尾指针
        private int count;// 队列数据个数

        public QueryLink()
        {
            front = rear = new Node<T>();
            count = 0;
        }

        // 出队
        public T DeQueue()
        {
            T temp = default(T);
            if (IsEmpty())
                Console.WriteLine("队列已空");
            else
            {
                temp = (T)front.Next.Data;
                front.Next = front.Next.Next;
                count--;
            }
            return temp;
        }

        // 入队
        public bool EnQueue(T obj)
        {
            Node<T> q = new Node<T>(obj);
            if (IsEmpty())
            {
                front.Next = q;
            }
            else
            {
                rear.Next = q;
            }
            rear = q;
            count++;
            return true;
        }

        // 判断是否为空
        public bool IsEmpty()
        {
            return count == 0;
        }

        // 查询队头对象
        public T Peek()
        {
            return default(T);
        }

        // 查询队列数据个数
        public int Size()
        {
            return 0;
        }

        // 判断是否为满
        public bool IsFull()
        {
            return false;
        }

        public override string ToString()
        {
            string msg = "";
            Node<T> temp = front;
            while (temp != rear)
            {
                msg += temp.Next.Data + " ";
                temp = temp.Next;
            }
            return msg;
        }

    }

}
