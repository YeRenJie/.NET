using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec2
{
    public class MySeqString : IString
    {
        private char[] items; // 用字符数组表示串
        private int count;// 记载串的长度

        public MySeqString()
            : this(20)
        {
        }

        public MySeqString(int maxSize)
        {
            if (maxSize < 0)
                maxSize = 20;

            items = new char[maxSize];
            count = 0;
        }

        public MySeqString(char[] str)
            : this(str.Length * 2)
        {
            for (int i = 0; i < str.Length; i++)
                this.items[i] = str[i];
            count = str.Length;
        }

        // 返回串中序号为index的字符
        public char CharAt(int index)
        {
            if (index <= 0 || index > count)
                throw new IndexOutOfRangeException("索引超出范围");

            return items[index - 1];
        }

        // 返回当前串与str串连接生成新串
        public IString Concat(IString str)
        {
            if (str == null)
                throw new NullReferenceException();
            int newLen = str.Length() + count;
            char[] nitems = new char[newLen];
            for (int i = 0; i < count; i++)
                nitems[i] = items[i];
            for (int i = 1; i <= str.Length(); i++)
                nitems[i + count - 1] = str.CharAt(i);
            MySeqString newStr = new MySeqString(nitems);
            return newStr;
        }

        // 返回pattern串在主串中的第一次匹配位置
        public int IndexOf(IString pattern)
        {
            int nc = pattern.Length();
            char[] nitems = new char[nc];
            for (int i = 1; i <= nc; i++)
                nitems[i - 1] = pattern.CharAt(i);

            int t = 0;
            for (; t <= count - nc; t++)
            {
                int j = 0;
                while (j < nc && this.items[t + j] == nitems[j])
                    j++;

                if (j == nc)
                    return t + 1;
            }
            return -1;
        }

        // 返回串的长度
        public int Length()
        {
            return this.count;
        }

        // 返回串中字符序号从begin开始长度为length的子串
        public IString Substring(int begin, int length)
        {
            MySeqString newStr = null;
            if (begin > 0 && length > 0 && begin + length <= this.count)
            {
                char[] nitems = new char[length];
                int j = 0;
                while (j < length)
                {
                    nitems[j] = this.items[j + begin - 1];
                    j++;
                }
                newStr = new MySeqString(nitems);
            }
            return newStr;
        }

    }

}
