using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.session5.form
{
    public partial class area : Form
    {
        public area()
        {
            InitializeComponent();
        }

        private void matematicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gm.Visible = true;
            gp.Visible = false;
            gf.Visible = false;
            gq.Visible = false;
            gg.Visible = false;

        }

   
        private void portuguêsToolStripMenuItem_Click(object sender, EventArgs e)
        {


            gm.Visible = false;
            gp.Visible = true;
            gf.Visible = false;
            gq.Visible = false;
            gg.Visible = false;
        }

        private void filosofiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            gm.Visible = false;
            gp.Visible = false;
            gf.Visible = true;
            gq.Visible = false;
            gg.Visible = false;
        }

        private void geografiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            gm.Visible = false;
            gp.Visible = false;
            gf.Visible = false;
            gq.Visible = false;
            gg.Visible = true;
        }

        private void químicaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            gm.Visible = false;
            gp.Visible = false;
            gf.Visible = false;
            gq.Visible = true;
            gg.Visible = false;
        }
    }
}
