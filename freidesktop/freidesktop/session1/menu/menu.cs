using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.session1.menu
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tela.imc a = new tela.imc();
            a.Show();
        }

       
        private void aToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tela.midade midade = new tela.midade();
            midade.Show();
        }

        private void bToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tela.calccaloria midade = new tela.calccaloria();
            midade.Show();
        }

        private void aToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
