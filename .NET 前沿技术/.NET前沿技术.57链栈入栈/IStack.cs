using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec4
{
    public interface IStack<T>
    {
         bool Push(T element);     //将数据插入堆栈
         T Pop();                  //删除栈顶元素
         T Peek();                 //获取栈顶元素
         bool IsEmpty();           //判断是否为空栈
         bool IsFull();            //判断是否为满
         int Size();               //统计有效数据个数
    }

}
