using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear contents
            startingBalTextBox.Text = String.Empty;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the app.
            this.Close();
        }
    }
}
