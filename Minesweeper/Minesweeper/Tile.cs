using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    internal class Tile
    {
        private Image m_flagIMG;
        private Image m_mineIMG;
        private Boolean m_flag;
        private Boolean m_mine;
        private Boolean m_dug;
        private int m_nearby;
        private Button m_b;
        public Tile(Button b)
        {
            m_b = b;
            m_b.BackColor = Color.Gray;
        }
        public void setNearBy(int n) {  m_nearby = n; }
        public void setflagIMG(Image flagIMG) { m_flagIMG = flagIMG; }
        public void setMineIMG(Image mineIMG) { m_mineIMG = mineIMG; }
        public void setDug(Boolean b) { m_dug = b; }
        public void setMine(Boolean b) 
        {
            m_mine = b;
            m_b.BackgroundImage = m_mineIMG;
        }
        public void setFlag(Boolean b)
        {
            m_flag = b;
            m_b.BackgroundImage = m_flagIMG;
        }

    }
}
