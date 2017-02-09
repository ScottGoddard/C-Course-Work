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
        public string character;
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
                //morseCodeConversion = new List<CharatertoMorseCode>();
                //morseCodeConversion.Add(new CharatertoMorseCode());

                // Create a delimiter array against the comma.
                char[] delim = { ',' };

                // Open the file morseCode.txt
                inputFile = File.OpenText("morseCode.txt");

                // Read the lines from the file.
                while (!inputFile.EndOfStream)
                {
                    // Read a line from the file.
                    line = inputFile.ReadLine();

                    // Tokenize the line.
                    string[] tokens = line.Split(delim);

                    // Store the tokens in the entry object.
                    entry.character= tokens[0];
                    entry.morseCode = tokens[1];

                    // Add the entry object to the list.
                    morseCodeConversion.Add(entry);
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
            foreach (CharatertoMorseCode entry in morseCodeConversion)
            {
                listBox1.Items.Add(entry.character + "," + entry.morseCode);
                string stringtext = stringTextBox.Text;
                stringtext = stringtext.ToLower();
                string convertChartoMorse;
                for (int index = 0; index < stringtext.Length; index++)
                {
                    convertedMorseLabel.Text = stringtext;


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

