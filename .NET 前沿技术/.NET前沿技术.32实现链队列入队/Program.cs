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
            QueryLink<int> query = new QueryLink<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("请输入第" + (i + 1) + "个整数：");
                string number = Console.ReadLine();
                int temp = int.Parse(number);

                if (query.EnQueue(temp))
                    Console.WriteLine("第" + (i + 1) + "个数据：" + temp + "-->入队");
            }
            Console.WriteLine("*******************");
            Console.WriteLine("队列中现存数据为：" + query);
        }
    }
}
