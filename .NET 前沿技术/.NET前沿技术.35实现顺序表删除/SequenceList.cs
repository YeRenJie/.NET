using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SequenceList_Update
{
    public class SequenceList<T> : ILinearList<T>
    {

        private T[] sList;// 对象数组
        private int length;// 顺序表长度

        public SequenceList(int capacity)
        {
            if (capacity <= 0)
                this.sList = new T[10];
            else
                this.sList = new T[capacity];
            this.length = 0;
        }

        public SequenceList()
            : this(10)
        {
        }

        public bool IsEmpty()
        {
            return length == 0;
        }

        public int Size()
        {
            return length;
        }

        public T Get(int index)
        {
            return default(T);
        }

        public void Set(int index, T element)
        {
        }

        public bool Insert(int index, T element)
        {
            if (index > length + 1 || index < 1)
                throw new IndexOutOfRangeException("索引超出范围");
            if (length == sList.Length)
            {
                T[] temp = sList;
                this.sList = new T[temp.Length * 2];// 重新申请一个容量更大的数组
                for (int i = 0; i < temp.Length; i++)
                    // 复制数组元素
                    this.sList[i] = temp[i];
            }
            for (int j = length - 1; j >= index - 1; j--)
                // 元素后移
                sList[j + 1] = sList[j];
            sList[index - 1] = element;
            length++;
            return true;
        }

        public bool Add(T element)
        {
            return Insert(length + 1, element);
        }

        public bool Remove(int index)
        {
            if (index > length || index < 1)
                throw new IndexOutOfRangeException("索引超出范围");
            for (int j = index - 1; j < length - 1; j++)
                sList[j] = sList[j + 1];
            sList[--length] = default(T);
            return true;
        }

        public void Clear()
        {
            if (length != 0)
            {
                for (int i = 0; i < length; i++)
                    this.sList[i] = default(T);
                length = 0;
            }
        }


        public override string ToString()
        {
            string temp = "";
            for (int i = 0; i < length; i++)
                temp += " " +sList[i];
            return temp;
        }

        public int Contains(T element)
        {
            return -1;
        }
    }

}
