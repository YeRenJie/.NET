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

            MessageBox.Show("使用传统方法初始化的对象");
            lincoln.SayHi();

            //使用对象初始化器的对象赋值方式
            Person scofield = new Person
            {
                FirstName = "Michael",
                LastName = "Scofield",
                Age = 20
            };
            MessageBox.Show("使用对象初始化器初始化的对象");
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
            MessageBox.Show("使用可嵌套的对象初始化器初始化的对象");
            tbag.SayHi();
        }
    }
}
