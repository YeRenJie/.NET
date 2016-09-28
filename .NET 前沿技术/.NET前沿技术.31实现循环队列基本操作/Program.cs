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
            CirQueryArray<int> query = new CirQueryArray<int>(5);
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                int temp = rnd.Next(10);
                if (query.EnQueue(temp))
                    Console.WriteLine("第" + (i + 1) + "个数据：" + temp + "-->入队");
                else
                    break;
            }
            Console.WriteLine("*******************");
            int number = query.Size();
            int t = 1;
            while (number > 0)
            {
                Console.WriteLine("第" + t + "个数据：" + query.DeQueue() + "-->出队");
                number--;
                t++;
            }
        }
    }
}
