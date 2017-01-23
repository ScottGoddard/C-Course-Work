using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//Scott Goddard
//January 21, 2017 ©
//chapter 5 Assignment Problem 13

namespace Random_Number_File_Writer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Get number out of text box and validate it.
            int totalNumbers;
            // If the character placed in the textbox isn't an integer, return.
            if (!int.TryParse(rangeTextBox.Text, out totalNumbers))
            {
                // Messsage box.
                MessageBox.Show("You must enter a whole number.");
                return;
            }
            // Bring up save dialog box and get filename.
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Generate random numbers range
                int lowerRange = 1;
                int upperRange = 100;

                // Get filename property saveFileDialog1
                string filename = saveFileDialog1.FileName;

                // Initiate random number generator.
                Random rand = new Random();
                int number = 0;

                using (StreamWriter writer = new StreamWriter(filename, false, Encoding.UTF8))
                {
                    string uiOutput = string.Empty;

                    for (int i = 1; i <= totalNumbers; i++)
                    {
                        // iterate over each random number.
                        number = rand.Next(lowerRange, upperRange);
                        // Write numbers to file with a comma between integers.
                        writer.Write(number + ", ");
                        // output for UI label.
                        uiOutput += number + ", ";
                    }
                    writer.Flush();
                    writer.Close();
                    //UI Label output
                    listRandomNumbersLabel.Text = uiOutput.ToString();
                    //MessageBox.Show(number.ToString());
                    // Close the form.
                    //this.Close();
                }
                
            }

        }
    private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
    