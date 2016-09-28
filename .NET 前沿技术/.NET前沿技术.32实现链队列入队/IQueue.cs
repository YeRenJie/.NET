using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec
{
    public interface IQueue<T>
    {
        bool EnQueue(T obj);//将数据插入队列
        T DeQueue();//删除队头元素
        T Peek();//查询队头元素
        bool IsEmpty();//判断队列是否为空
        bool IsFull();//判断队列是否为满
        int Size();//查询队列长度
    }
}
