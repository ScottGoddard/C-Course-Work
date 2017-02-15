//Scott Goddard
//Feb 09, 2017 ©
//Chapter 8 Assignment Problem 10

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

namespace Morse_Code_Converter
{
    // Structure with character with morse code.
    struct CharatertoMorseCode
    {
        public char character;
        public string morseCode;
    }

    public partial class Form1 : Form
    {
        // Field to hold a list of Morse Code.
        private List<CharatertoMorseCode> morseCodeConversion = new List<CharatertoMorseCode>();
        
        public Form1()
        {
            InitializeComponent();
            ReadFile();
        }

        // Read contents of the morse code file.
        private void ReadFile()
        {
            try
            {
                StreamReader inputFile;     // To read the file.
                string line;                // To hold a line from the file.

                // Create an instance of the CharacterMorseCode.
                CharatertoMorseCode entry = new CharatertoMorseCode();

                // Create a delimiter array against the comma.
                char[] delim = { '*' };

                // Open the file morseCode.txt
                inputFile = File.OpenText("morseCode.txt");
                
                // Read the lines from the file.
                while (!inputFile.EndOfStream)
                {
                    // Read a line from the file.
                    line = inputFile.ReadLine();
                    
                    if (line.Trim() != string.Empty)
                    {
                        // Tokenize the line.
                        string[] tokens = line.Split(delim);

                        // Store the tokens in the entry object.
                        entry.character = char.Parse(tokens[0].Trim());
                        entry.morseCode = tokens[1].Trim();

                        // Add the entry object to the list.
                        morseCodeConversion.Add(entry);
                    }

                }
            }
            catch (Exception ex)
            {
                /// Display an error message
                MessageBox.Show(ex.Message);
            }
                    
            }

        private void convertButton_Click(object sender, EventArgs e)
        {
            // Store string in the variable.
            string stringtext = stringTextBox.Text;
            // Initiate variable.
            string convertedString = string.Empty;

            // Loop through each character in text box string.
            foreach(var character in stringtext.ToUpper())
            {
                if (character != ' ')
                {
                    // For a particular character find the morse code.
                    convertedString += morseCodeConversion.Single(c =>
                        c.character == character).morseCode;
                }
                // Add a space between words.
                convertedString += " ";
                
            }
            // Put morse code string into label.
            convertedMorseLabel.Text = convertedString;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }


    }

