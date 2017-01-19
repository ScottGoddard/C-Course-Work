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
        // Constant fields
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
            classATotalLabel.Text = totalA.ToString("c");
            decimal totalB = int.Parse(classBSeatTextBox.Text) * CLASSB;
            classBTotalLabel.Text = totalB.ToString("c");
            decimal totalC = int.Parse(classCSeatTextBox.Text) * CLASSC;
            classCTotalLabel.Text = totalC.ToString("c");
            decimal total = totalA + totalB + totalC;
            totalRevenueLabel.Text = total.ToString("c");

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
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
