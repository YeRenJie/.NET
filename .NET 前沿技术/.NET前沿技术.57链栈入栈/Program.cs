using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec4
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkStack<int> stack = new LinkStack<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("请输入第" + (i + 1) + "个整数：");
                string input = Console.ReadLine();
                int temp = int.Parse(input);
                stack.Push(temp);
            }
            Console.WriteLine("当前链栈中数据为：" + stack);

        }
    }
}
