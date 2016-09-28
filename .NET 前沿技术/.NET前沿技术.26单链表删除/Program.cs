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
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            string str;
            int temp;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("请输入第" + (i + 1) + "个整数：");
                str = Console.ReadLine();
                temp = int.Parse(str);
                list.Add(temp);
            }
            Console.WriteLine("单链表中数据为：" + list);
            Console.WriteLine("***************************");
            Console.WriteLine("删除最后一个数据");
            list.Remove(list.Size());
            Console.WriteLine("单链表中数据为：" + list);
        }
    }
}
