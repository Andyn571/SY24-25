using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryBoi
{
    public partial class Form1 : Form
    {
        int Total = 0;
        int TotalA = 0;
        int TotalB = 0;

        int[] bits = new int[8];
        int[] Bbits = new int[8];
        int[] bitts = new int[8];
        public Form1()
        {
            InitializeComponent();
        }
        private void calculateValue()
        {

            Total = 0;

            if (Bit1.Text == "1") bits[0] = 1;
            else bits[0] = 0;
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

            for (int i = 0; i < bits.Length; i++) { if (bits[i] != 0) Total += (int)Math.Pow(2, i); }

            label1.Text=Total.ToString();
        }

        private void calculateValue2()
        {
            TotalA = 0;

            if (bBit1.Text == "1") Bbits[0] = 1;
            else Bbits[0] = 0;
            //bit1
            if (bBit2.Text == "1") Bbits[1] = 1;
            else Bbits[1] = 0;
            //bit2
            if (bBit3.Text == "1") Bbits[2] = 1;
            else Bbits[2] = 0;
            //bit3
            if (bBit4.Text == "1") Bbits[3] = 1;
            else Bbits[3] = 0;
            //bit4
            if (bBit5.Text == "1") Bbits[4] = 1;
            else Bbits[4] = 0;
            //bit5
            if (bBit6.Text == "1") Bbits[5] = 1;
            else Bbits[5] = 0;
            //bit6
            if (bBit7.Text == "1") Bbits[6] = 1;
            else Bbits[6] = 0;
            //bit7
            if (bBit8.Text == "1") Bbits[7] = 1;
            else Bbits[7] = 0;
            //bit8

            for (int i = 0; i < Bbits.Length; i++) { if (Bbits[i] != 0) TotalA += (int)Math.Pow(2, i); }

            label2.Text = TotalA.ToString();
        }
        private void calculateValue3()
        {
            TotalB = 0;

           

            if (Bitt1.Text == "1") bitts[0] = 1;
            else bitts[0] = 0;
            //bit1
            if (Bitt2.Text == "1") bitts[1] = 1;
            else bitts[1] = 0;
            //bit2
            if (Bitt3.Text == "1") bitts[2] = 1;
            else bitts[2] = 0;
            //bit3
            if (Bitt4.Text == "1") bitts[3] = 1;
            else bitts[3] = 0;
            //bit4
            if (Bitt5.Text == "1") bitts[4] = 1;
            else bitts[4] = 0;
            //bit5
            if (Bitt6.Text == "1") bitts[5] = 1;
            else bitts[5] = 0;
            //bit6
            if (Bitt7.Text == "1") bitts[6] = 1;
            else bitts[6] = 0;
            //bit7
            if (Bitt8.Text == "1") bitts[7] = 1;
            else bitts[7] = 0;
            //bit8

            for (int i = 0; i < bitts.Length; i++) { if (bitts[i] != 0) TotalB += (int)Math.Pow(2, i); }

            label3.Text = TotalB.ToString();
        }
        private void Bit8_MouseDown(object sender, MouseEventArgs e)
        {
            if (((TextBox) sender).Text == "0") ((TextBox) sender).Text = "1";
            else ((TextBox)sender).Text = "0";

            calculateValue();
            calculateValue2();
            calculateValue3();

            Update();   
        }
        private void Update()
        {
            //Row 1
            Bit1.Text = (bits[0]==1 ? "1" : "0");
            Bit2.Text = (bits[1] == 1 ? "1" : "0");
            Bit3.Text = (bits[2] == 1 ? "1" : "0");
            Bit4.Text = (bits[3] == 1 ? "1" : "0");
            Bit5.Text = (bits[4] == 1 ? "1" : "0");
            Bit6.Text = (bits[5] == 1 ? "1" : "0");
            Bit7.Text = (bits[6] == 1 ? "1" : "0");
            Bit8.Text = (bits[7] == 1 ? "1" : "0");
            //Row 2
            bBit1.Text = (Bbits[0] == 1 ? "1" : "0");
            bBit2.Text = (Bbits[1] == 1 ? "1" : "0");
            bBit3.Text = (Bbits[2] == 1 ? "1" : "0");
            bBit4.Text = (Bbits[3] == 1 ? "1" : "0");
            bBit5.Text = (Bbits[4] == 1 ? "1" : "0");
            bBit6.Text = (Bbits[5] == 1 ? "1" : "0");
            bBit7.Text = (Bbits[6] == 1 ? "1" : "0");
            bBit8.Text = (Bbits[7] == 1 ? "1" : "0");
            //Row 3
            Bitt1.Text = (bitts[0] == 1 ? "1" : "0");
            Bitt2.Text = (bitts[1] == 1 ? "1" : "0");
            Bitt3.Text = (bitts[2] == 1 ? "1" : "0");
            Bitt4.Text = (bitts[3] == 1 ? "1" : "0");
            Bitt5.Text = (bitts[4] == 1 ? "1" : "0");
            Bitt6.Text = (bitts[5] == 1 ? "1" : "0");
            Bitt7.Text = (bitts[6] == 1 ? "1" : "0");
            Bitt8.Text = (bitts[7] == 1 ? "1" : "0");
            calculateValue();
            calculateValue2();
            calculateValue3();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //shift right
            for (int i = 0; i < bits.Length - 1; i++)
            {
                //if (bits[7] == 1) { bits[7] = 0; bits[7 - 1] = 1; }

                bits[i] = bits[i + 1];
            }
            bits[7] = 0;
            for (int i = 0; i < Bbits.Length - 1; i++)
            {
                //if (Bbits[7] == 1) { Bbits[7] = 0; Bbits[7 - 1] = 1; }

                Bbits[i] = Bbits[i + 1];
            }
            Bbits[7] = 0;
            for (int i = 0; i < bitts.Length - 1; i++)
            {
                //if (bitts[7] == 1) { bitts[7] = 0; bitts[7 - 1] = 1; }

                bitts[i] = bitts[i + 1];
            }
            bitts[7] = 0;
            Update();

        }

        private void ClearA_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++) { bits[i] = 0; Update(); }

        }
        private void ClearB_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Bbits.Length; i++) { Bbits[i] = 0; Update(); }

        }
        private void ClearC_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bitts.Length; i++) { bitts[i] = 0; Update(); }

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++) { bits[i] = 0; Update(); }
            for (int i = 0; i < Bbits.Length; i++) { Bbits[i] = 0; Update(); }
            for (int i = 0; i < bitts.Length; i++) { bitts[i] = 0; Update(); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //And
            for (int i=0; i<bits.Length; i++)
            {
                if (bits[i] * Bbits[i]==1) bitts[i] = 1; 
                if (bits[i] * Bbits[i]==0) bitts[i] = 0;
                Update();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Xor
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == 1 || Bbits[i] == 1) bitts[i] = 0;
                if (bits[i] == 0 || Bbits[i] == 0) bitts[i] = 0;
                if (bits[i] == 1 && Bbits[i] == 0) bitts[i] = 1;
                if (bits[i] == 0 && Bbits[i] == 1) bitts[i] = 1;
                Update();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //OR
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == 0 || Bbits[i] == 1) bitts[i] = 1;
                if (bits[i] == 1 || Bbits[i] == 0) bitts[i] = 1;
                if (bits[i] == 0 || Bbits[i] == 0) bitts[i] = 0;
                if (bits[i] == 1 || Bbits[i] == 1) bitts[i] = 1;
                Update();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Subtract
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Add
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == 1 && Bbits[i] != 1) bitts[i] = 1;
                if (bits[i] != 1 && Bbits[i] == 1) bitts[i] = 1;
                if (bits[i] == 1 && Bbits[i] == 1) bitts[i + 1] = 1;
                Update();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Shift Left
            for (int i = bits.Length - 1; i > 0; i--)
            {
                bits[i] = bits[i - 1];
            }
            bits[0] = 0;
            for (int i = Bbits.Length - 1; i > 0; i--)
            {
                Bbits[i] = Bbits[i - 1];
            }
            Bbits[0] = 0;
            for (int i = bitts.Length - 1; i > 0; i--)
            {
                bitts[i] = bitts[i - 1];
            }
            bitts[0] = 0;
            Update();
        }
    }
}
