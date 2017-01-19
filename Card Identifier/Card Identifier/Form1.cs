using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Identifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cardPictureBox1_Click(object sender, EventArgs e)
        {
            cardLabel.Text = "Eight of Diamonds";
        }

        private void cardPictureBox2_Click(object sender, EventArgs e)
        {
            cardLabel.Text = "Two of Clubs";
        }

        private void cardPictureBox3_Click(object sender, EventArgs e)
        {
            cardLabel.Text = "King of Spades";
        }

        private void cardPictureBox4_Click(object sender, EventArgs e)
        {
            cardLabel.Text = "Ace of Spades";
        }

        private void cardPictureBox5_Click(object sender, EventArgs e)
        {
            cardLabel.Text = "Joker";
        }
    }
}
