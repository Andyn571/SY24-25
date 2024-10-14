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
        Random Random = new Random();
        Button[] btnGrid = new Button[100];
        Tile[] tileGrid = new Tile[100];
        public Form1()
        {
            InitializeComponent();
            Reset();
        }
        private Button GetButton(int r, int c)
        {
            int idx = (r-1) * 10 + (c-1);
            return btnGrid[idx];
        }
        private int getIndex(Button b)
        {
            string tmp = b.Name.Substring(6);
            int retVal = 0;
            int.TryParse(tmp, out retVal);
            return retVal - 1;
        }
        private void getRC(Button b, out int r, out int c)
        {
            int i = getIndex(b);
            r = i / 10 + 1;
            c = i % 10 + 1;
        }
        private void SetCounts()
        {
            //for every tile on the board
            for (int r = 1; r < 11; r++)
            {
                for (int c = 1; c < 11; c++)
                {
                    GetButton(r, c).BackColor=Color.BlanchedAlmond;
                }
            }
            //add 1 for each adjacent mine
            //set count into tile
        }
        private int countAdj(int r, int c)
        {
            int count = 0;
            if (r > 1 && c > 1)
            {
                if (tileGrid[getIndex(GetButton(r - 1, c - 1))].GetMine()) count++;
            }
            if (r > 1)
            {
                if (tileGrid[getIndex(GetButton(r - 1, c))].GetMine()) count++;
            }
            if (r > 1 && c < 10)
            {
                if (tileGrid[getIndex(GetButton(r - 1, c + 1))].GetMine()) count++;
            }
            if (c > 1)
            {
                if (tileGrid[getIndex(GetButton(r, c - 1))].GetMine()) count++;
            }
            if (c < 10)
            {
                if (tileGrid[getIndex(GetButton(r, c + 1))].GetMine()) count++;
            }
            if (r < 10 && c > 1)
            {
                if (tileGrid[getIndex(GetButton(r + 1, c - 1))].GetMine()) count++;
            }
            if (r < 10)
            {
                if (tileGrid[getIndex(GetButton(r + 1, c))].GetMine()) count++;
            }
            if (r < 10 && c < 10)
            {
                if (tileGrid[getIndex(GetButton(r + 1, c + 1))].GetMine()) count++;
            }

            return count;
        }
        private int countAdjFlag(int r, int c)
        {
            int flagcount = 0;
            if (r > 1 && c > 1)
            {
                if (tileGrid[getIndex(GetButton(r - 1, c - 1))].GetFlag()) flagcount++;
            }
            if (r > 1)
            {
                if (tileGrid[getIndex(GetButton(r - 1, c))].GetFlag()) flagcount++;
            }
            if (r > 1 && c < 10)
            {
                if (tileGrid[getIndex(GetButton(r - 1, c + 1))].GetFlag()) flagcount++;
            }
            if (c > 1)
            {
                if (tileGrid[getIndex(GetButton(r, c - 1))].GetFlag()) flagcount++;
            }
            if (c < 10)
            {
                if (tileGrid[getIndex(GetButton(r, c + 1))].GetFlag()) flagcount++;
            }
            if (r < 10 && c > 1)
            {
                if (tileGrid[getIndex(GetButton(r + 1, c - 1))].GetFlag()) flagcount++;
            }
            if (r < 10)
            {
                if (tileGrid[getIndex(GetButton(r + 1, c))].GetFlag()) flagcount++;
            }
            if (r < 10 && c < 10)
            {
                if (tileGrid[getIndex(GetButton(r + 1, c + 1))].GetFlag()) flagcount++;
            }

            return flagcount;
        }
        private void DuffBooze(int r, int c)
        {
            
            if (r > 1 && c > 1)
            {
                tileGrid[getIndex(GetButton(r - 1, c - 1))].SetDug();
            }
            if (r > 1)
            {
                tileGrid[getIndex(GetButton(r - 1, c))].SetDug();
            }
            if (r > 1 && c < 10)
            {
               tileGrid[getIndex(GetButton(r - 1, c + 1))].SetDug();
            }
            if (c > 1)
            {
               tileGrid[getIndex(GetButton(r, c - 1))].SetDug();
            }
            if (c < 10)
            {
                tileGrid[getIndex(GetButton(r, c + 1))].SetDug();
            }
            if (r < 10 && c > 1)
            {
                tileGrid[getIndex(GetButton(r + 1, c - 1))].SetDug();
            }
            if (r < 10)
            {
               tileGrid[getIndex(GetButton(r + 1, c))].SetDug();
            }
            if (r < 10 && c < 10)
            {
                tileGrid[getIndex(GetButton(r + 1, c + 1))].SetDug();
            }
            if (r < 10 && c < 10)
            {
                tileGrid[getIndex(GetButton(r, c ))].SetDug();
            }
        }
        private void button91_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            Tile t = tileGrid[getIndex(b)];
            if (e.Button == MouseButtons.Right)
                t.setFlag();
            if (e.Button == MouseButtons.Left)
                t.SetDug();
            if (e.Button==MouseButtons.Left && t.GetMine())
                this.Close();
               
            
           if (e.Button == MouseButtons.Middle) 
           { 
            int r = 0;
            int c = 0;
            getRC(b, out r, out c);
                if (countAdj(r, c) == countAdjFlag(r, c))
                {
                    DuffBooze(r, c);
                }
            }
            
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            Reset();
           
        }
        private void Reset()
        {
            Reset(); 
            void Reset()
            {
                for (int i = 0; i < 100; i++)
                {
                    btnGrid[i] = (Button)Controls["button" + (i + 1)];
                    tileGrid[i] = new Tile(btnGrid[i]);
                    tileGrid[i].setflagIMG(FlagBox.Image);
                    tileGrid[i].setMineIMG(MineBox.Image);
                    
                    
                }
                CreateMines(10);
                //countAdj(5, 5);
                for (int r = 1; r < 11; r++)
                {
                    for (int c = 1; c < 11; c++)
                    {
                        tileGrid[getIndex(GetButton(r, c))].setNearBy(countAdj(r, c));
                    }
                }
            }
        }
       
        private void CreateMines(int numMines)
        {
            int MineCount = 0;
            //until enough mines
            while (MineCount < numMines) 
            {
                //generate num 1-100
                int rNum = Random.Next(0, 100);
                if (tileGrid[rNum].GetMine()==false)
                {
                    MineCount++;
                    tileGrid[rNum].setMine(true);
                }
            }
        }
    }
}
