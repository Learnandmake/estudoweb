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
    }
}
