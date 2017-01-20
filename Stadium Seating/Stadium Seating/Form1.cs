using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_Seating
{
    public partial class stadiumSeatingForm : Form
    {
        // Constant fields for Class A, B and C.
        const decimal CLASSA = 15.0m;
        const decimal CLASSB = 12.0m;
        const decimal CLASSC = 9.0m;

        public stadiumSeatingForm()
        {
            InitializeComponent();
        }

        private void calculateRevenueButton_Click(object sender, EventArgs e)
        {
            // Multiply the value in text box with totalA 
            decimal totalA = int.Parse(classASeatTextBox.Text)*CLASSA;
            // Store the variable totalA in label  and convert to string currency.
            classATotalLabel.Text = totalA.ToString("c");
            // Multiply the value in text box with totalB
            decimal totalB = int.Parse(classBSeatTextBox.Text) * CLASSB;
            // Store the variable totalB in label  and convert to string currency.
            classBTotalLabel.Text = totalB.ToString("c");
            // Multiply the value in text box with totalC
            decimal totalC = int.Parse(classCSeatTextBox.Text) * CLASSC;
            // Store the variable totalC in label and convert to string currency.
            classCTotalLabel.Text = totalC.ToString("c");
            // Add totalA, totalB, totalC and store in variable total
            decimal total = totalA + totalB + totalC;
            // Store the variable total in label and convert to string currency.
            totalRevenueLabel.Text = total.ToString("c");
            

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the app
            this.Close();

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Empty label and text boxes.
            classATotalLabel.Text = string.Empty;
            classBTotalLabel.Text = string.Empty;
            classCTotalLabel.Text = string.Empty;
            totalRevenueLabel.Text = string.Empty;
            classASeatTextBox.Text = string.Empty;
            classBSeatTextBox.Text = string.Empty;
            classCSeatTextBox.Text = string.Empty;

        }
    }
}
