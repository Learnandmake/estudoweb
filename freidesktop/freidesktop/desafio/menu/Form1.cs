using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.desafio.menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.mouse m = new form.mouse();
            m.Show();
        }

        private void filmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.dbfilme a = new form.dbfilme();
            a.Show();
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.dbfilme a = new form.dbfilme();
            a.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
