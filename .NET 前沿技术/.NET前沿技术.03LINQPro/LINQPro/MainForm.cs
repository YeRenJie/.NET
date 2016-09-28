﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace LINQPro
{
    public partial class MainForm : Form
    {
        private List<Person> GetFoxRiver8()
        {
            return (
                new List<Person> {
                    new Person{FirstName = "Michael", LasName="Scofield", Age=25},
                    new Person{FirstName = "Lincoln", LasName="Burrows", Age=30},
                    new Person{FirstName = "Fernando", LasName="Sucre", Age=25},
                    new Person{FirstName = "John", LasName="Abruzzi", Age=37},
                    new Person{FirstName = "Theodore", LasName="Bagwell", Age=32},
                    new Person{FirstName = "Benjamin", LasName="Franklin", Age=31},
                    new Person{FirstName = "David", LasName="Apolskis", Age=19},
                    new Person{FirstName = "Charles", LasName="Patoshik", Age=25},
                }
            );

        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQueryExpressionDemo1_Click(object sender, EventArgs e)
        {
            QEvsQM();
        }

        private void QEvsQM()
        {
            int[] numbers = new int[] { 6, 4, 3, 2, 9, 1, 7, 8, 5 };

            ////查询方法方式
            //var even = numbers
            //    .Where(p => p % 2 == 0)
            //    .OrderByDescending(p => p)
            //    .Select(p => p);

            //查询语句方式
            var even = from number in numbers
                       where number % 2 == 0
                       orderby number descending
                       select number;

            Console.WriteLine("LINQ 查询方式");
            foreach (var item in even)
            {
                Console.WriteLine(item.ToString());
            }


        }

        private void btnQueryExpressionDemo2_Click(object sender, EventArgs e)
        {
            List<Person> foxRiver8 = GetFoxRiver8();
            var q = from p in foxRiver8
                    where p.Age <= 30 && p.FirstName.Length == 7
                    orderby p.Age descending
                    select new{
                        Name = p.FirstName + " " + p.LasName, 
                        Age = p.Age};
                    
            foreach (var item in q)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
        }

        private void btnCountDemo_Click(object sender, EventArgs e)
        {
            List<Person> foxRiver8 = GetFoxRiver8();

            // 查询方法模式
            int count = foxRiver8
                .Where(p => p.Age <= 30)
                .Count();

            //// 混合模式
            //int count = (from p in foxRiver8
            //             where p.Age <= 30
            //             select p).Count();

            Console.WriteLine(count.ToString());

            var q = from p in foxRiver8
                    where p.Age <= 30
                    select p;

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }

        private void btnMaxDemo_Click(object sender, EventArgs e)
        {
            List<Person> foxRiver8 = GetFoxRiver8();

            // 查询方法模式
            int maxAge = foxRiver8
                .Select(p => p.Age)
                .Max();

            //// 混合模式
            //int maxAge = (from p in foxRiver8
            //              select p.Age).Max();

            Console.WriteLine(maxAge.ToString());

            var q = from p in foxRiver8
                    select p;

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

        }

        private void btnAverageDemo_Click(object sender, EventArgs e)
        {

            List<Person> foxRiver8 = GetFoxRiver8();

            // 查询方法模式
            double averageAge = foxRiver8
                .Select(p => p.Age)
                .Average();

            //// 混合模式
            //double averageAge = (from p in foxRiver8
            //              select p.Age).Average();

            Console.WriteLine(averageAge.ToString());

            var q = from p in foxRiver8
                    select p;

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }

        private void btnDistinctDemo_Click(object sender, EventArgs e)
        {
            int[] factorsOf300 = { 2, 2, 3, 5, 5 };

            var uniqueFactors = factorsOf300.Distinct();

            foreach (var item in uniqueFactors)
            {
                Console.WriteLine(item);
            }

        }

        private void btnQueryStepsDemo_Click(object sender, EventArgs e)
        {

            // 获取数据源
            int[] numbers = new int[] 
                { 6, 4, 3, 2, 9, 1, 7, 8, 5 };

            // 定义查询
            var even = numbers
                .Where(p => p % 2 == 0)
                .Select(p =>
                {
                    Console.WriteLine("Hi! " + p.ToString());
                    return p;
                });

            foreach (var item in even) { }

            //// 定义查询时就强制执行查询的技巧
            //var even = numbers
            //    .Where(p => p % 2 == 0)
            //    .Select(p =>
            //    {
            //        Console.WriteLine("Hi! " + p.ToString());
            //        return p;
            //    }).Count();


        }

        private void btnMinDemo_Click(object sender, EventArgs e)
        {
            List<Person> foxRiver8 = GetFoxRiver8();

            // 查询方法模式
            int minAge = foxRiver8
                .Select(p => p.Age)
                .Min();

            //// 混合模式
            //int minAge = (from p in foxRiver8
            //              select p.Age).Min();

            Console.WriteLine(minAge.ToString());

            var q = from p in foxRiver8
                    select p;

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }

        private void btnThenByDemo_Click(object sender, EventArgs e)
        {
            List<Person> foxRiver8 = GetFoxRiver8();

            // 添加几个 怪人 以看出多重排序效果
            foxRiver8.Add(new Person
            {
                FirstName = "Michael",
                LasName = "Copy",
                Age = 25
            });

            foxRiver8.Add(new Person
            {
                FirstName = "Michael",
                LasName = "Copy",
                Age = 15
            });

            // 查询方法模式
            var q = foxRiver8
                .OrderBy(p => p.FirstName)
                .ThenBy(p => p.LasName)
                .ThenBy(p => p.Age);

            // 查询语句模式
            //var q = from p in foxRiver8
            //        orderby p.FirstName, p.LasName, p.Age
            //        select p;

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

        }

        private void btnSkipTakeDemo_Click(object sender, EventArgs e)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var q = numbers.Skip(1).Take(3);
            //var q = numbers.Skip(1).Take(3).Skip(1).Take(2);

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

        }


        private void btnSkipWhileTakeWhileDemo_Click(object sender, EventArgs e)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var q = numbers.SkipWhile(i => i % 3 != 0)
                .TakeWhile(i => i % 2 != 0); 
            
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }

        private void btnRangeDemo_Click(object sender, EventArgs e)
        {
            var numbers = Enumerable.Range(1, 10);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        private void btnRepeatDemo_Click(object sender, EventArgs e)
        {
            var numbers = Enumerable.Repeat("Beijing 2008", 10);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

        }

        private void btnSumDemo_Click(object sender, EventArgs e)
        {
            List<Person> foxRiver8 = GetFoxRiver8();

            // 查询方法模式
            int sumAge = foxRiver8
                .Select(p => p.Age)
                .Sum();

            //// 混合模式
            //int sumAge = (from p in foxRiver8
            //              select p.Age).Sum();

            Console.WriteLine(sumAge.ToString());

            var q = from p in foxRiver8
                    select p;

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }




    }
}
