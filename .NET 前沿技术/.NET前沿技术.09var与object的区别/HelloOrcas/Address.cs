using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloOrcas
{
    class Address
    {
        public string Street { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            string message = string.Empty;
            message = string.Format("{0}, {1}",Street, Country);
            return message;
        }
    }
}
