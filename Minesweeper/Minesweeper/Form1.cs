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
        Random random = new Random();
        Button[] btnGrid = new Button[100];
        Tile[] tileGrid = new Tile[100];
        int flagcount = 0;
        public Form1()
        {
            InitializeComponent();
            Reset();
        }
        private Button GetButton(int r, int c)
        {
            return (Button)GetButton(r, c);
        }
        private int getIndex(Button b)
        {
            string tmp = b.Name.Substring(6);
            int retVal = 0;
            int.TryParse(tmp, out retVal);
            return retVal - 1;
        }
        private void button91_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            Tile t = tileGrid[getIndex(b)];
            t.setFlag(true);

        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }
        void Reset()
        {
            for (int i = 0; i < 100; i++)
            {
                btnGrid[i] = (Button)Controls["button" + (i + 1)];
                tileGrid[i] = new Tile(btnGrid[i]);
                tileGrid[i].setflagIMG(FlagBox.Image);
                tileGrid[i].setMineIMG(MineBox.Image);
                tileGrid[i].setFlag(true);
                tileGrid[i].setMine(false);
            }
        }

    }
}
