using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.session2.form
{
    public partial class quiz : Form
    {
        public quiz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           



        }

        private void rbp1a_CheckedChanged(object sender, EventArgs e)
        {
            barra.Value = +20;
        }

        private void rbp1b_CheckedChanged(object sender, EventArgs e)
        {

            barra.Value = +20;
        }

        private void rbp1c_CheckedChanged(object sender, EventArgs e)
        {

            barra.Value = +20;
        }

        private void rbp1d_CheckedChanged(object sender, EventArgs e)
        {

            barra.Value= +20;
        }

        private void rbp2a_CheckedChanged(object sender, EventArgs e)
        {
            barra.Value = +40;
        }

        private void rbp2b_CheckedChanged(object sender, EventArgs e)
        {
            barra.Value = +40;
        }

        private void rbp2c_CheckedChanged(object sender, EventArgs e)
        {
            barra.Value = +40;
        }

        private void rbp2d_CheckedChanged(object sender, EventArgs e)
        {
            barra.Value = +40;
        }
    }
}
