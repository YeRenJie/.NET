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
            MySeqString s1 = new MySeqString(new char[] { 'h', 'e', 'l', 'l', 'o' });
            Console.Write("s1的串值为：");
            int length = s1.Length();
            for (int i = 1; i <= length; i++)
                Console.Write(s1.CharAt(i));
            Console.WriteLine();
            Console.WriteLine("*******************");

            MySeqString s2 = new MySeqString(new char[] { 'w', 'o', 'r', 'l', 'd' });
            Console.Write("s2的串值为：");
            length = s2.Length();
            for (int i = 1; i <= length; i++)
                Console.Write(s2.CharAt(i));
            Console.WriteLine();
            Console.WriteLine("*******************");
            IString s3 = s1.Concat(s2);
            Console.Write("s1与s2联接后得到串s3，s3的串值为：");
            length = s3.Length();
            for (int i = 1; i <= length; i++)
                Console.Write(s3.CharAt(i));
        }
    }
}
