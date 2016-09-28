using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec2
{
    public interface ILinearList<T>
    {
        bool IsEmpty();// 判断线性表是否为空

        int Size();// 返回线性表长度

        T Get(int index);// 返回索引为index的对象

        void Set(int index, T element);// 用指定元素替换线性表中指定位置的元素

        bool Insert(int index, T element);// 在线性表的指定位置插入指定元素

        bool Add(T element);// 向线性表的尾部添加指定的元素

        bool Remove(int index);// 移除线性表中指定位置的元素

        void Clear();// 从线性表中移除所有元素

        int Contains(T element);//查找线性表中数据元素的位置
    }

}
