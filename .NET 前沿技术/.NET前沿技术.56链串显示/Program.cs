using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个字符串（回车结束输入）：");
            char[] ary = Console.ReadLine().ToCharArray();
            MyLinkString link = new MyLinkString(ary);
            int length = link.Length();
            Console.WriteLine("您输入的信息为：");
            for (int i = 1; i <= length; i++)
                Console.Write(link.CharAt(i));
            Console.WriteLine();
            Console.WriteLine("第2个字符为："+link.CharAt(2));
        }
    }
}
