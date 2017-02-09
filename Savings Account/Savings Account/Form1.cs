//Scott Goddard
//January 26, 2017 ©
//Chapter 6 Assignment Problem 7

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Savings_Account
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // The InputIsValid method converts the user input and stores
        // it in the arguments (passed by reference). If the conversion 
        // is successful, the method returns true. Otherwise it returns 
        // false.
        private bool InputIsValid(ref decimal future, ref decimal interest, ref decimal years)
        {
            // Flag variable to indicate whether the input is good.
            bool inputGood = false;

            // Try to convert both inputs to decimal.
            if (decimal.TryParse(futureValueTextbox.Text, out future))
            {
                if (decimal.TryParse(annualInterestTextBox.Text, out interest))
                {
                    if (decimal.TryParse(numYearsTextBox.Text, out years))
                    {
                        // All three inputs are good.
                        inputGood = true;
                    }
                    else
                    {
                        // Display an error message for years.
                        MessageBox.Show("Years are invalid");
                    }
                }
                else
                {
                    // Display an error message for interest.
                    MessageBox.Show("Interest value is invalid");
                }
            }
            else
            {
                // Display an error message for future value.
                MessageBox.Show("Future value is invalid");
            }

            // Convert percentage to decimal.
            interest = interest / 100;

            // Return the result.
            return inputGood;
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Variables for future, interest, years and present value.
            decimal future = 0m, interest = 0m, years = 0m, present = 0m;
                    
            if (InputIsValid(ref future, ref interest, ref years))
            {
                // Calculate the present value.
                present = future / (decimal)Math.Pow((double)(1 + interest), (double)years);

                //  Display the present value.
                presentValueLabel.Text = present.ToString("c");
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
 }

