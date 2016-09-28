using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec2
{
    public interface IString
    {
        int Length();                     //返回串的长度
        char CharAt(int index);           //返回串中序号为index的字符
        IString Concat(IString str);      //返回当前串与str串连接生成新串
        IString Substring(int begin, int length);
        //返回串中字符序号从begin开始长度为length的子串
        int IndexOf(IString pattern);
        //返回pattern串在主串中的第一次匹配位置
    }


}
