using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec1
{
    class Program
    {
        static void Main(string[] args)
        {
            RecLinkedList<int> list = new RecLinkedList<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("请输入第" + (i + 1) + "个数据：");
                string str = Console.ReadLine();
                int temp = int.Parse(str);
                list.Add(temp);
            }
            Console.WriteLine("循环链表中保存的数据为：" + list);
        }
    }
}
