//Scott Goddard
//February 15, 2017 ©
//Chapter 10 Assignment Problem 4

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customers
{
    public partial class Form1 : Form
    {
        // List to hold employee objects.
        List<Customer> customerList = new List<Customer>();

        public Form1()
        {
            InitializeComponent();
        }

        // GetCustomerData method accepts a Customer object
        // as an argument it assigns the data entered by the
        // user to the objects properties.
        private void GetCustomerData(Customer Customers)
        {
            // Get the Customer name.
            Customers.Name = nameTextBox.Text;

            // Get the Customer address.
            Customers.Address = addressTextBox.Text;

            // Get the Customer phone number.
            Customers.PhoneNumber = phoneNumberTextBox.Text;

            // Get the Customer ID.
            Customers.CustomerID = int.Parse(customerIDTextBox.Text);

            // Get the Customer mailing list check.
            Customers.MailingList = mailingListCheckBox.Checked;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Create an Customer object.
            Customer myCustomer = new Customer();
            
            // Get the Customer data.
            GetCustomerData(myCustomer);

            // Add the Customer data to the listview.
            // Set the view to show details.
            customerPropertiesListView.View = View.Details;

            // Allow the user to rearrange columns.
            customerPropertiesListView.AllowColumnReorder = true;

            // Select the item and subitems when selection is made.
            customerPropertiesListView.FullRowSelect = true;

            // Display grid lines.
            customerPropertiesListView.GridLines = true;

            // Sort the items in the list in ascending order.
            customerPropertiesListView.Sorting = SortOrder.Ascending;

            // Create a Listview control.
            ListViewItem item1 = new ListViewItem(myCustomer.Name, 0);
            item1.SubItems.Add(myCustomer.Address);
            item1.SubItems.Add(myCustomer.PhoneNumber);
            item1.SubItems.Add(myCustomer.CustomerID.ToString());
            item1.SubItems.Add(myCustomer.MailingListResponse);
            customerPropertiesListView.Items.Add(item1);

            // Clear the text box controls.
            nameTextBox.Clear();
            addressTextBox.Clear();
            phoneNumberTextBox.Clear();
            customerIDTextBox.Clear();
            mailingListCheckBox.Checked = false;

            // Reset the focus
            nameTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
