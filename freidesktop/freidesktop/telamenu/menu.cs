using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.telamenu
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void oneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            session1.menu.menu one = new session1.menu.menu();
            one.Show();
        
        }

        private void twoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            session2.menu.menu m = new session2.menu.menu();
            m.Show();
        }

        private void threeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            session3.menu.menu m = new session3.menu.menu();
            m.Show(); 
        }

        private void desafioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void desafioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            desafio.menu.Form1 m = new desafio.menu.Form1();
            m.Show();
        }

        private void fourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            session4.menu.menu m = new session4.menu.menu();
            m.Show();
        }

        private void fiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            session5.menu.menu m = new session5.menu.menu();
            m.Show();
        }

        private void sixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            session6.menu.menu m = new session6.menu.menu();
            m.Show();
        }

        private void sevenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            session7.menu.menu m = new session7.menu.menu();
            m.Show();
        }

        private void eightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            session8.menu.menu m = new session8.menu.menu();
            m.Show();
        }

        private void nineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            session9.menu.menu m = new session9.menu.menu();
            m.Show();
        }

        private void tenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sessionten.menu.menu n = new sessionten.menu.menu();
            n.Show();
        }

        private void elevenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sessionueleven.menu.menu m = new sessionueleven.menu.menu();
            m.Show();
        }

        private void twoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sessionvtwelve.menu.menu m = new sessionvtwelve.menu.menu();
            m.Show();
        }
    }
}
