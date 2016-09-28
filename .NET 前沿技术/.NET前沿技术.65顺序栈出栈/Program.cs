using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec2
{
    class Program
    {
        static void Main(string[] args)
        {
            SeqStack<int> stack = new SeqStack<int>(8);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("请输入第" + (i + 1) + "个整数：");
                string input = Console.ReadLine();
                int temp = int.Parse(input);
                if (stack.Push(temp))
                    Console.WriteLine("数据" + temp + "-->入栈");
                else
                    break;
            }
            Console.WriteLine("当前顺序栈中数据为：" + stack);
            Console.WriteLine("***********************");
            Console.WriteLine("栈内数据出栈");
            for (int t= 0; t < 5; t++)
                Console.WriteLine("数据" + stack.Pop() + "-->出栈");
        }
    }
}
