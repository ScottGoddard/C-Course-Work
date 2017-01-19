using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator_3_5
{
    public partial class Form1 : Form

        // Constant fields
        const decimal FIVE_CENTS_VALUE = 0.05m;
        const decimal TEN_CENTS_VALUE = 0.10m;
        const decimal TWENTY_FIVE_CENTS_VALUE = 0.25m;
        const decimal FIFTY_CENTS_VALUE = 0.50m;

        // Field variable to hold the total,
        // initialized with 0.
        private decimal total = 0m;

    private void fiveCentsPictureBox_Click(object sender, EventArgs e)
    {

    }

    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
