using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Flip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showBackButton_Click(object sender, EventArgs e)
        {
            // Make the image of the back of the card visible.
            cardBackPictureBox.Visible = true;
            // Make the image of the face of the card invisible.
            cardFacePictureBox.Visible = false;
        }

        private void ShowFaceButton_Click(object sender, EventArgs e)
        {
            cardBackPictureBox.Visible = false; // Hide the card back
            cardFacePictureBox.Visible = true; // Show the card face
            hjjk
        }
    }
}
