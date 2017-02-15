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
        private int _phoneNumber;

        // Constructor
        public Person(string name, string address, int phoneNumber)
        {
            _name = name;
            _address = address;
            _phoneNumber = phoneNumber;
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
        public int PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

    }
}
