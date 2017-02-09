//Scott Goddard
//February 3, 2017 ©
//chapter 7 Assignment Problem 6

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

namespace Names_Search
{
    public partial class Form1 : Form
    {
        // Open content of files.
        StreamReader girlsFile = File.OpenText("GirlNames.txt");
        StreamReader boysFile = File.OpenText("BoyNames.txt");

        // Create a list object to hold strings.
        List<string> girlsList = new List<string>();
        List<string> boysList = new List<string>();

        public Form1()
        {
            InitializeComponent();

            // Read the file's contents.
            while (!girlsFile.EndOfStream)
            {
                // Read a line and add it to the list.
                girlsList.Add(girlsFile.ReadLine());
                boysList.Add(boysFile.ReadLine());
            }
        }

        private void popularNameButton_Click(object sender, EventArgs e)
        {
            // If the text box it empty, prompt a message.
            if ((string.IsNullOrWhiteSpace(girlsTextBox.Text)) &&
                    (string.IsNullOrWhiteSpace(boysTextBox.Text)))
            {
                answerLabel.Text = "Please add girl or boys name";
                answerLabel.ForeColor = Color.Red;
                return;
            }
            
            // Lists for girls and boys. Count to see if is 0.
            int numGirls = girlsList.Where(g => g.ToLower() == 
                girlsTextBox.Text.ToLower()).Count();
                
            int numBoys = boysList.Where(g => g.ToLower() ==
                boysTextBox.Text.ToLower()).Count();
            
            // Message for girls name. 
            string messageForUser = string.Empty;
            if (!string.IsNullOrWhiteSpace(girlsTextBox.Text))
            {
                messageForUser += "Girls name is";
                if (numGirls == 0)
                {
                    messageForUser += " not";
                }                    
                messageForUser += " popular. ";
            }
            // Message for boys name. 
            if (!string.IsNullOrWhiteSpace(boysTextBox.Text))
            {
                messageForUser += "Boys name is";
                if (numBoys == 0)
                {
                    messageForUser += " not";
                }
                messageForUser += " popular.";
            }

            // Message added to label box and colored green.
            if (!string.IsNullOrWhiteSpace(messageForUser))
            {
                answerLabel.Text = messageForUser;
                answerLabel.ForeColor = Color.Green;
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
