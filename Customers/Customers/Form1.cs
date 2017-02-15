using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customers
{
    public partial class Form1 : Form
    {
        // List to hold employee objects.
        List<Customers> customerList = new List<Customers>();

        public Form1()
        {
            InitializeComponent();
        }


    }
}
