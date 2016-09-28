using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuyChickenThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j,k;
		    for(i=0;i<=100;i++)
			    for(j=0;j<=100;j++){
				    k=100-i-j;
				    if(k%3==0 && 5*i+3*j+k/3==100)
					    Console.WriteLine("母鸡："+i+"只，公鸡："+j+"只，小鸡"+k+"只");
			}
        }
    }
}
