using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec4
{
    class Program
    {
        static void Main(string[] args)
        {
  		int[] numbers = new int[10];
		BinarySortTree tree = new BinarySortTree();
		for (int i = 0; i <6; i++) {
			Console.WriteLine("请输入第" + (i + 1) + "个整数");
            string str=Console.ReadLine();
			numbers[i] = int.Parse(str);
			tree.InsertIntoTree(numbers[i]);
		}
	
		Console.WriteLine("根据输入序列构成二叉排序树");
        Console.WriteLine("该树的中序遍历序列为：");
		tree.InOrder(tree.Root);

        }
    }
}
