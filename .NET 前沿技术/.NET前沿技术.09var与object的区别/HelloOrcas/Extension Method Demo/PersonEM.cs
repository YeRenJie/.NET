using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelloOrcas
{
    public interface ISingable
    {
        void Sing();
    }

    class PersonEM : ISingable
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

        public void Sing()
        {
            throw new NotImplementedException();
        }
    }
}
