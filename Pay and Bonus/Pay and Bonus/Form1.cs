//Scott Goddard
//January 26, 2017 ©
//chapter 6 Tutorial 6-5

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pay_and_Bonus
{
    public partial class Form1 : Form
    {
        // Constant field for the contribution rate.
        private const decimal CONTRIB_RATE = 0.5m;

        public Form1()
        {
            InitializeComponent();
        }

        // The InputIsValid metheod converts the user input and stores
        // it in the arguments (passed by reference). If the conversion
        // is successful, the method returns true. Otherwise it returns
        // false.
        private bool InputIsValid(ref decimal pay, ref decimal bonus)
        {
            // Flag variable to indicate whether the input is good.
            bool inputGood = false;

            // Try to convert both inputs to decimal.
            if (decimal.TryParse(grossPayTextBox.Text, out pay))
            {
                if (decimal.TryParse(bonusTextBox.Text, out bonus))
                {
                    // Both inputs are good.
                    inputGood = true;
                }
                else
                {
                    // Display an error message for the bonus.
                    MessageBox.Show("Bonus amount is invalid.");
                }
            }
            else
            {
                // Display an error message for gross pay.
                MessageBox.Show("Gross pay is invalid.");
            }
            // Return the result.
            return inputGood;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Variables for gross pay, bonus, and contributions.
            decimal grossPay = 0m, bonus = 0m, contributions = 0m;

            if (InputIsValid(ref grossPay, ref bonus))
            {
                // Calculate the amount of contribution.
                contributions = (grossPay + bonus) * CONTRIB_RATE;

                // Display the contribution.
                contributionLabel.Text = contributions.ToString("c");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {

        }
        private int plusIt(int x)
        {
            return (x + 3);
        }
        private int minusIt(int y)
        {
            return (y - 1);
        }
        MessageBox.Show((plusIt(5) * minusIt(3)).ToString());

        {
    }
    } 
}

