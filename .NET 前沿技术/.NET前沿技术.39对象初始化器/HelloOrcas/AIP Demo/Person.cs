using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelloOrcas
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private Address address;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        public void SayHi()
        {
            string message = string.Empty;

            if (this.address != null)
            {
                message = string.Format(
                    "大家好，我叫 {0} {1}，今年 {2} 岁。住在 {3}",
                    this.firstName, this.lastName, this.age, this.address);
            }
            else
            {
                message = string.Format(
                    "大家好，我叫 {0} {1}，今年 {2} 岁。",
                    this.firstName, this.lastName, this.age);
            }

            MessageBox.Show(message);
        }
    }

}
