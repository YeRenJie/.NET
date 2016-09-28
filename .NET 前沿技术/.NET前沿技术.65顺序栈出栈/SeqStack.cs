using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec2
{
    public class SeqStack<T> : IStack<T>
    {
        private T[] items; // 声明堆栈数组
        private int top = -1;

        public SeqStack(int maxsize)
        {
            if (maxsize <= 0)
                this.items = new T[10];
            else
                this.items = new T[maxsize];
            this.top = -1;
        }

        public SeqStack()
            : this(10)
        {
        }

        //判断为空
        public bool IsEmpty()
        {
            return top == -1;
        }

        //判断为满
        public bool IsFull()
        {
            return top == items.Length - 1;
        }

        //获取栈顶元素
        public T Peek()
        {
            return default(T);
        }

        //出栈
        public T Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("此栈为空");
                return default(T);
            }
            else
            {
                T temp = items[top];
                top--;
                return temp;
            }
        }

        //入栈
        public bool Push(T element)
        {
            if (IsFull())
            {
                Console.WriteLine("此栈已满");
                return false;
            }
            else
            {
                top++;
                items[top] = element;
                return true;
            }
        }

        //取栈中数据个数
        public int Size()
        {
            return 0;
        }

        public override string ToString()
        {
            string msg = "";
            for (int i = 0; i <= top; i++)
                msg += items[i] + " ";
            return msg;
        }
    }

}
