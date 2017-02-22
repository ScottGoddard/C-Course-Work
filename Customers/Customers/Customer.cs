using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers
{
    class Customer : Person
    {
        // Fields
        private int _customerNumber;
        private bool _mailingList;

        // Constructor
        public Customer()
        {
            _customerNumber = 0;
            _mailingList = false;
        }

        // Customer ID property
        public int CustomerID
        {
            get { return _customerNumber; }
            set { _customerNumber = value; }
        }

        // Mailing List property
        public bool MailingList
        {
            get { return _mailingList; }
            set { _mailingList = value; }
        }

        // Mailing List response property
        public string MailingListResponse
        {
            get { return
                    _mailingList==false? "No" : "Yes"; }
        }
    }
}
