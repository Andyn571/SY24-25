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
        Button m_b;
        public Tile(Button b)
        {
            m_b = b;
            m_b.BackColor = Color.Gray;
        }
        public void setNearBy(int n) 
        {  
            m_nearby = n; 
           

        }
        public void setflagIMG(Image flagIMG) { m_flagIMG = flagIMG; }
        public void setMineIMG(Image mineIMG) { m_mineIMG = mineIMG; }
        public void setDug(Boolean b) { m_dug = b; }
        public void setMine(Boolean b) 
        {
            m_mine = b;
        }
        public Boolean GetMine() { return m_mine; }
        public Boolean GetFlag() { return m_flag; }
        public void SetDug()
        {
            m_b.Text = m_nearby.ToString();
            m_dug = true;
            if (m_mine && !m_flag)
                m_b.BackgroundImage = m_mineIMG;
            else 
                m_b.BackColor=Color.BlanchedAlmond;
           
        }
        public void setFlag()
        {
            m_flag = !m_flag;
            if (m_flag) { m_b.BackgroundImage = m_flagIMG; }

            else { m_b.BackgroundImage = null; }
               
        }

    }
}
