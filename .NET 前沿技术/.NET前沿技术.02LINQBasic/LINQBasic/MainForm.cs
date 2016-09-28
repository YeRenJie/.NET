using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LINQBasic
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLinqStory_Click(object sender, EventArgs e)
        {
            WithoutLinq();
            WithLinq();
        }

        /// <summary>
        /// 传统查询方式
        /// </summary>
        private void WithoutLinq()
        {
            int[] numbers = new int[] { 6, 4, 3, 2, 9, 1, 7, 8, 5 };

            List<int> even = new List<int>();

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    even.Add(number);
                }
            }

            even.Sort();
            even.Reverse();

            Console.WriteLine("传统查询方式");
            foreach (int number in even)
            {
                Console.WriteLine(number.ToString());
            }

        }

        /// <summary>
        /// LINQ 查询方式
        /// </summary>
        private void WithLinq()
        {
            int[] numbers = new int[] { 6, 4, 3, 2, 9, 1, 7, 8, 5 };

            var even = numbers
                .Where(p => p % 2 == 0)
                .Select(p => p)
                .OrderByDescending(p => p);

            Console.WriteLine("LINQ 查询方式");
            foreach (var item in even)
            {
                Console.WriteLine(item.ToString());
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 处理字符串的委托原型
        delegate string ProcessString(string input);
        delegate int Process2Numbers(int x, int y);
        delegate void ProcessSingleNumber(int x);

        // 一个实例方法 准备映射到上面的委托 ProcessString
        private string LowerIt(string input)
        {
            return input.ToLower();
        }

        private void btnDelegateTest_Click(object sender, EventArgs e)
        {
            List<string> foxRiver8 = new List<string>{
                "Michael",
                "Lincoln",
                "Sucre",
                "Abruzzi",
                "T-Bag",
                "C-Note",
                "Tweener",
                "Charles"
            };

            // 传统委托方式
            ProcessString p = new ProcessString(LowerIt);
            foreach (string name in foxRiver8)
            {
                Console.WriteLine(p(name));
            }

            //// 匿名方法方式
            //ProcessString p = delegate(string input)
            //{
            //    return input.ToLower();
            //};
            //foreach (string name in foxRiver8)
            //{
            //    Console.WriteLine(p(name));
            //}

            // Lambda 表达式方式
            //ProcessString p = (string input) => { return input.ToLower(); };
            //ProcessString p = input => { return input.ToLower(); };
            //ProcessString p = (string input) => input.ToLower();
            //ProcessString p = input => input.ToLower();
            //foreach (string name in foxRiver8)
            //{
            //    Console.WriteLine(p(name));
            //}

        }

        private void btnLINQDataOpDemo_Click(object sender, EventArgs e)
        {
            List<string> foxRiver8 = new List<string>{
                "Michael",
                "Lincoln",
                "Sucre",
                "Abruzzi",
                "T-Bag",
                "C-Note",
                "Tweener",
                "Charles"
            };


            // 获取数据
            var q1 = foxRiver8.Select(name => name.ToLower());

            // 过滤数据
            var q2 = foxRiver8
                .Where( name => name.StartsWith("T"))
                .Select(name => name.ToLower());

            // 排序数据
            var q3 = foxRiver8
                .Where(name => name.Length >5)
                .Select(name => name.ToLower())
                .OrderBy(name => name.Substring(1,1))                ;

            foreach (var item in q3)
            {
                Console.WriteLine(item);
            }

            // 分组数据
            var q4 = foxRiver8
                .Where(name => name.Length > 5)
                .Select(name => name.ToLower())
                .GroupBy(name => name.Substring(0, 1));

            foreach (var group in q4)
            {
                Console.WriteLine(group.Key);
                Console.WriteLine("--------------------");
                foreach (var item in group)
                {
                    Console.WriteLine(item);
                }
            }


        }
    }
}
