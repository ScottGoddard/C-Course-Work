using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Class
{
    class Employees
    {
        // Fields
        private string _name;       // Employee name.
        private int _idnumber;      // Employee ID number.
        private string _department; // Employee department.
        private string _position;   // Employee position.

        // Constructor
        public Employees()
        {
            _name = "";
            _idnumber = 0;
            _department = "";
            _position = "";
        }

        // Name property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // ID number property
        public int IDNumber
        {
            get { return _idnumber; }
            set { _idnumber = value; }
        }

        // Department property
        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }

        // Position property
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
    }
}
