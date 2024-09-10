using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        Random random= new Random();
        Button[] btnGrid = new Button[100];
        Tile[] tileGrid = new Tile[100];
        int flagcount = 0;
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 100; i++)
            {
                btnGrid[i] = (Button)Controls["button" + (i + 1)];
                tileGrid[i] = new Tile(btnGrid[i]);
                btnGrid[i].BackColor= Color.Gray;

            }
        }
        private Button GetButton(int r, int c)
        {
            return (Button)GetButton(r, c);

        }
        private int getIndex(Button B)
        {
            string tmp = B.Name.Substring(6);
            int retVal = 0;
            int.TryParse(tmp, out retVal);
            return retVal = -1;
        }
        private void button91_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            b.BackColor = Color.Red;
        }
    }
}
