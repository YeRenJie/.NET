using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuyChickenOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            for (i = 0; i <= 100; i++)
                for (j = 0; j <= 100; j++)
                    for (k = 0; k <= 100; k++)
                    {
                        if (k % 3 == 0 && i + j + k == 100 && 5 * i + 3 * j + k / 3 == 100)
                            Console.WriteLine("母鸡：" + i + "只，公鸡：" + j + "只，小鸡" + k + "只");
                    }
        }
    }
}
