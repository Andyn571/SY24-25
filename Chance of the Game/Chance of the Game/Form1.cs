using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chance_of_the_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Random random = new Random();
            int num = random.Next(1, 101);
            textBox1.Text = num.ToString();
            if (textBox1.Text == textBox2.Text)
            {
                label2.Visible = true;
                label2.Text = "You wiM";
            }
            else if (textBox1.Text != textBox2.Text)
            {
                label1.Visible = true;
                label1.Text = "You LOSE";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
