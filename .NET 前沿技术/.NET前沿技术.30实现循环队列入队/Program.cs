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
            CirQueryArray<int> query = new CirQueryArray<int>(10);
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int temp = rnd.Next(10);
                if (query.EnQueue(temp))
                    Console.WriteLine("第" + (i + 1) + "个数据：" + temp + "-->入队");
                else
                    break;
            }
            Console.WriteLine("当前队列内数据为："+query);
           
        }
    }
}
