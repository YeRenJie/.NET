using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryArray<int> query = new QueryArray<int>(5);
            Random rnd = new Random();
            for (int i = 0; i <5; i++)
            {
                int temp = rnd.Next(10);
                if (query.EnQueue(temp))
                    Console.WriteLine("第" + (i + 1) + "个数据：" + temp + "-->入队");
                else
                    break;
            }
            Console.WriteLine("************************");
            Console.WriteLine("当前队列内元素为：" + query);
        }
    }
}
