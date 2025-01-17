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
        int[] bits = new int[8];
        int[] Bbits = new int[8];
        int[] bitts = new int[8];
        int Total3 = 0;
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

            label1.Text=Total.ToString();
        }

        private void calculateValue2()
        {
            Total = 0;

            if (Bbits[0] != 0) Total += 1;
            if (Bbits[1] != 0) Total += 2;
            if (Bbits[2] != 0) Total += 4;
            if (Bbits[3] != 0) Total += 8;
            if (Bbits[4] != 0) Total += 16;
            if (Bbits[5] != 0) Total += 32;
            if (Bbits[6] != 0) Total += 64;
            if (Bbits[7] != 0) Total += 128;

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

            label2.Text = Total.ToString();
        }
        private void calculateValue3()
        {
            Total = 0;

            if (bitts[0] != 0) Total += 1;
            if (bitts[1] != 0) Total += 2;
            if (bitts[2] != 0) Total += 4;
            if (bitts[3] != 0) Total += 8;
            if (bitts[4] != 0) Total += 16;
            if (bitts[5] != 0) Total += 32;
            if (bitts[6] != 0) Total += 64;
            if (bitts[7] != 0) Total += 128;

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

            label3.Text = Total.ToString();
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
            if (Bit2.Text == "1") { Bit1.Text = "1"; Bit2.Text = "0"; }
            if (Bit3.Text == "1") { Bit2.Text = "1"; Bit3.Text = "0"; }
            if (Bit4.Text == "1") { Bit3.Text = "1"; Bit4.Text = "0"; }
            if (Bit5.Text == "1") { Bit4.Text = "1"; Bit5.Text = "0"; }
            if (Bit6.Text == "1") { Bit5.Text = "1"; Bit6.Text = "0"; }
            if (Bit7.Text == "1") { Bit6.Text = "1"; Bit7.Text = "0"; }
            if (Bit8.Text == "1") { Bit7.Text = "1"; Bit8.Text = "0"; }
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
    }
}
