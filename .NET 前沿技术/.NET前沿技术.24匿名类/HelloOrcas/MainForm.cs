using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelloOrcas
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObjectInitializerTest_Click(object sender, EventArgs e)
        {
            //传统的对象赋值方式
            Person lincoln = new Person();
            lincoln.FirstName = "Lincoln";
            lincoln.LastName = "Burrows";
            lincoln.Age = 30;

            lincoln.SayHi();

            //使用对象初始化器的对象赋值方式
            Person scofield = new Person
            {
                FirstName = "Michael",
                LastName = "Scofield",
                Age = 20
            };

            scofield.SayHi();

            //可嵌套的对象初始化器
            Person tbag = new Person
            {
                FirstName = "Theodore ",
                LastName = "Bagwell",
                Age = 32,
                Address = new Address
                {
                    Street = "Prison SONA",
                    Country = "Panama"
                }
            };

            tbag.SayHi();
        }

        private void btnCollectionInitializerTest_Click(object sender, EventArgs e)
        {
            ////传统的集合初始化方式
            //List<string> foxRiver8 = new List<string>();
            //foxRiver8.Add("Michael Scofield");
            //foxRiver8.Add("Lincoln Burrows");
            //foxRiver8.Add("Fernando Sucre");
            //foxRiver8.Add("John Abruzzi");
            //foxRiver8.Add("Theodore \"T-Bag\" Bagwell");
            //foxRiver8.Add("Benjamin Miles \"C-Note\" Franklin");
            //foxRiver8.Add("David \"Tweener\" Apolskis");
            //foxRiver8.Add("Charles \"Haywire\" Patoshik");

            ////传统的集合初始化方式
            //List<string> foxRiver8 = new List<string>();
            //foxRiver8.Add("Michael");
            //foxRiver8.Add("Lincoln");
            //foxRiver8.Add("Sucre");
            //foxRiver8.Add("Abruzzi");
            //foxRiver8.Add("T-Bag");
            //foxRiver8.Add("C-Note");
            //foxRiver8.Add("Tweener");
            //foxRiver8.Add("Charles");

            //使用集合初始化器的集合初始化方式
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

            foreach (var item in foxRiver8)
            {
                Console.WriteLine(item);
            }

        }

        private void btnExtensionMethodTest_Click(object sender, EventArgs e)
        {
            string greeting = "welcome to beijing";
            greeting.SayHi();
        }

        private void btnExtensionMethodTestv1_Click(object sender, EventArgs e)
        {
            string greeting = "welcome to beijing";
            greeting.SayHi("Beijing 2008");
        }

        private void btnVarTest_Click(object sender, EventArgs e)
        {
            WithVar();
            WithoutVar();
        }
        private static void WithVar()
        {
            var i = 2008;
            var s = "ACCP";
            var d = 5.0;
            var numbers = new int[] { 1, 2, 3 };
            var students = new Dictionary<int, Person>();

            Console.WriteLine(i.ToString());
            Console.WriteLine(s);
            Console.WriteLine(d.ToString());
            foreach (var item in numbers)
            {
                Console.WriteLine(item.ToString());
            }

        }

        private void WithoutVar()
        {
            int i = 2008;
            string s = "ACCP";
            double d = 5.0;
            int[] numbers = new int[] { 1, 2, 3 };
            Dictionary<int, Person> students =
                new Dictionary<int, Person>();

            Console.WriteLine(i.ToString());
            Console.WriteLine(s);
            Console.WriteLine(d.ToString());
            foreach (var item in numbers)
            {
                Console.WriteLine(item.ToString());
            }

        }

        private void btmVarAndObject_Click(object sender, EventArgs e)
        {
            //var name = "Beijing";
            //name = 2008;

            object name = "Beijing";
            name = 2008;

            var x = new int[] { 1, 2, 3 };
            //var y = { 1, 2, 3 };
        }

        private void btnAnonymousTypeTest_Click(object sender, EventArgs e)
        {
            var p = new
            {
                Name = "Tin Tin",
                Age = 20,
                Gender = "male"
            };

            MessageBox.Show(string.Format(p.Name));
        }


    }
}
