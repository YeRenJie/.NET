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
            MySeqString s1 = new MySeqString(new char[] { 'h', 'e', 'l', 'l', 'o' });
            Console.Write("s1的串值为：");
            int length = s1.Length();
            for (int i = 1; i <= length; i++)
                Console.Write(s1.CharAt(i));
            Console.WriteLine();
            Console.WriteLine("第2个字符为：" + s1.CharAt(2));
        }
    }
}
