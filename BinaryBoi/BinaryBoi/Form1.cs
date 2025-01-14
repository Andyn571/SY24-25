﻿using System;
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
        int[] bits = new int[8];
        public Form1()
        {
            InitializeComponent();
        }
        private void calculateValue()
        {
            Total = 0;

            if (bits[0] != 0) Total += 1;
            if (bits[1] != 0) Total += 2;
            if (bits[2] != 0) Total += 4;
            if (bits[3] != 0) Total += 8;
            if (bits[4] != 0) Total += 16;
            if (bits[5] != 0) Total += 32;
            if (bits[6] != 0) Total += 64;
            if (bits[7] != 0) Total += 128;
           
            label1.Text=Total.ToString();
        }
        private void Bit1_TextChanged(object sender, EventArgs e)
        {
            if (Bit1.Text == "1") bits[0] = 1;
            else  bits[0] = 0;
            //bit1
            if (Bit2.Text == "1") bits[1] = 1;
            else bits[1] = 0;
            //bit2
            if (Bit3.Text == "1") bits[2] = 1;
            else bits[2] = 0;
            //bit3
            if (Bit4.Text == "1") bits[3] = 1;
            else bits[3] = 0;
            //bit4
            if (Bit5.Text == "1") bits[4] = 1;
            else bits[4] = 0;
            //bit5
            if (Bit6.Text == "1") bits[5] = 1;
            else bits[5] = 0;
            //bit6
            if (Bit7.Text == "1") bits[6] = 1;
            else bits[6] = 0;
            //bit7
            if (Bit8.Text == "1") bits[7] = 1;
            else bits[7] = 0;
            //bit8

            calculateValue();
        }
    }
}
