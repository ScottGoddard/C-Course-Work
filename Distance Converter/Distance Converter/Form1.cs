using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Converter
{
    public partial class Form1 : Form
    {
        // Constant fields.
        const double FEET = 12;
        const double YARDS = 3;


        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if ((fromListBox.SelectedIndex != -1) || (toListBox.SelectedIndex != -1))
            {
                //Get from distance
                // Variables
                double fromDistance = double.Parse(inputTextbox.Text);
                double convertedDistance = 0;
                
                // Get the from selected item.
                string fromList=fromListBox.SelectedItem.ToString();
                string toList = toListBox.SelectedItem.ToString();

                if (fromList == toList)
                {
                    convertedDistance = fromDistance;
                }
                else
                {
                    //Switch
                    switch (fromList)
                    {
                        case "Inches":

                            if(toList == "Feet")
                                convertedDistance = (fromDistance / FEET);
                            else if(toList == "Yards")
                                convertedDistance = ((fromDistance / FEET) / YARDS);

                            switch (toList)
                            {
                                case "Feet":
                                    convertedDistance = (fromDistance / FEET);
                                    break;
                                case "Yards":
                                    convertedDistance = ((fromDistance / FEET) / YARDS);
                                    break;
                            }
                            break;


                        case "Feet":
                            switch (toList)
                            {
                                case "Inches":
                                    convertedDistance = (fromDistance * FEET);
                                    break;
                                case "Yards":
                                    convertedDistance = (fromDistance / YARDS);
                                    break;
                            }

                            break;
                        case "Yards":
                            switch (toList)
                            {
                                case "Inches":
                                    convertedDistance = (fromDistance * YARDS * FEET);
                                    break;
                                case "Feet":
                                    convertedDistance = (fromDistance * YARDS);
                                    break;
                            }

                            break;
                    }
                
                }

                convertedDistanceLabel.Text = convertedDistance.ToString("n");
            }


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the app
            this.Close();
        }
    }
}
