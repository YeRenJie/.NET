using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec
{
    public class QueryArray<T> : IQueue<T>
    {
        private int front;// 队头指针
        private int rear; // 队尾指针
        private int maxSize;// 队列长度
        private T[] quere;// 队列

        public QueryArray()
            : this(10)
        {
        }

        public QueryArray(int size)
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
            return default(T);
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
                rear += 1;
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
            return default(T);
        }

        //查询队列数据个数
        public int Size()
        {
            return 0;
        }

        // 判断是否为满
        public bool IsFull()
        {
            return rear == maxSize;
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
