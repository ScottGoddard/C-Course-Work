//Scott Goddard
//February 10, 2017 ©
//Chapter 9 Assignment Problem 4

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Class
{
    public partial class Form1 : Form
    {
        // List to hold employee objects.
        List<Employees> employeeList = new List<Employees>();

        public Form1()
        {
            InitializeComponent();
        }

        // GetEmployeeData method accepts a employee object
        // as an argument it assigns the data entered by the
        // user to the objects properties.
        private void GetEmployeeData(Employees employee)
        {
            // Get the employee name.
            employee.Name = nameTextBox.Text;

            // Get the employee id number.
            employee.IDNumber = int.Parse(idnumberTextBox.Text);

            // Get the employee department.
            employee.Department = departmentTextBox.Text;

            // Get the employee position.
            employee.Position = postionTextBox.Text;
         }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Create an employee object.
            Employees myemployee = new Employees();

            // Get the employee data.
            GetEmployeeData(myemployee);

            // Add the employee data to the listview.
            // Set the view to show details.
            employeePropertiesListView.View = View.Details;

            // Allow the user to rearrange columns.
            employeePropertiesListView.AllowColumnReorder = true;

            // Select the item and subitems when selection is made.
            employeePropertiesListView.FullRowSelect = true;

            // Display grid lines.
            employeePropertiesListView.GridLines = true;

            // Sort the items in the list in ascending order.
            employeePropertiesListView.Sorting = SortOrder.Ascending;

            // Create a Listview control.
            ListViewItem item1 = new ListViewItem(myemployee.Name, 0);
            item1.SubItems.Add(myemployee.IDNumber.ToString());
            item1.SubItems.Add(myemployee.Department);
            item1.SubItems.Add(myemployee.Position);
            employeePropertiesListView.Items.Add(item1);
         
            // Clear the text box controls.
            nameTextBox.Clear();
            idnumberTextBox.Clear();
            departmentTextBox.Clear();
            postionTextBox.Clear();

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
