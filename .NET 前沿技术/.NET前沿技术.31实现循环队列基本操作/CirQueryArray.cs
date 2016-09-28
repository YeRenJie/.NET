using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec2
{
    public class CirQueryArray<T> : IQueue<T>
    {
        private int front;// 队头指针
        private int rear; // 队尾指针
        private int maxSize;// 队列长度
        private T[] quere;// 队列

        public CirQueryArray()
            : this(10)
        {
        }

        public CirQueryArray(int size)
        {
            if (size < 0)
                size = 10;

            maxSize = size;
            front = rear = 0;
            quere = new T[maxSize];
        }

        //出队
        public T DeQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("队列已空！");
                return default(T);
            }
            else
            {
                T temp = quere[front];
                front = (front + 1) % maxSize;
                return temp;
            }
        }

        // 入队
        public bool EnQueue(T obj)
        {
            if (IsFull())
            {
                Console.WriteLine("队列已满！");
                return false;
            }
            else
            {
                quere[rear] = obj;
                rear = (rear + 1) % maxSize;
                return true;
            }
        }

        // 判断是否为空
        public bool IsEmpty()
        {
            return rear == front;
        }

        //查询队头对象
        public T Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("队列已空！");
                return default(T);
            }
            return quere[front];
        }

        //查询队列数据个数
        public int Size()
        {
            return (rear - front + maxSize) % maxSize;
        }

        // 判断是否为满
        public bool IsFull()
        {
            return (rear + 1) % maxSize == front;
        }

        public override string ToString()
        {
            string msg = "";
            for (int i = front; i < rear; i++)
                msg += quere[i] + " ";
            return msg;
        }
    }

}
