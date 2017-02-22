using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers
{
    class Person
    {
        // Fields
        private string _name;
        private string _address;
        private string _phoneNumber;

        // Constructor
        public Person()
        {
        }

        // Name property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Address property
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        // Phone number property
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
    }
}
