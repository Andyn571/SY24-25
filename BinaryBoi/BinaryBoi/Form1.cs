using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryBoi
{
    public partial class Form1 : Form
    {
        int Total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Bit5_TextChanged(object sender, EventArgs e)
        {
            Total = 0;
            if (Bit1.Text == "1")
            {
                Total += 1;
            }
            if (Bit2.Text == "1") 
            {
                Total += 2;
            }
            if (Bit3.Text == "1")
            {
                Total += 4;
            }
            if (Bit4.Text == "1")
            {
                Total += 8;
            }
            if (Bit5.Text == "1")
            {
                Total += 16;
            }
            label1.Text = Total.ToString();
        }
    }
}
