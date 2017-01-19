using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double test1;   // to hold test score #1
                double test2;   // to hold test score #2
                double test3;   // to hold test score #3
                double average; // to hold the average test score

                //get the three test scores
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                //calculate the average test score.
                average = (test1 + test2 + test3) / 3.0;

                //display the average test score, with
                //the output rounded to 1 decimal point.
                averageLabel.Text = average.ToString("n1");

            }
            catch (Exception ex)
            {
                //Display the default error mesage.
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the input and output controls.
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
