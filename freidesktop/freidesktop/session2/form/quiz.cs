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
        {try
            { int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            if( rbp1a.Checked==true )
            {
                p1 = 1;
            }
            if (rbp1b.Checked == true)
            {
                p1 = 2;
            }
            if (rbp1c.Checked == true)
            {
                p1 = 3;
            }
            if (rbp1d.Checked == true)
            {
                p1 = 4;
            }


            if (rbp2a.Checked == true)
            {
                p2 = 1;
            }
            if (rbp2b.Checked == true)
            {
                p2 = 2;
            }
            if (rbp2c.Checked == true)
            {
                p2 = 3;
            }
            if (rbp2d.Checked == true)
            {
                p2 = 4;
            }


            if (rbp3a.Checked == true)
            {
                p3 = 1;
            }
            if (rbp3b.Checked == true)
            {
                p3 = 2;
            }
            if (rbp3c.Checked == true)
            {
                p3 = 3;
            }
            if (rbp3d.Checked == true)
            {
                p3 = 4;
            }


            if (rbp4a.Checked == true)
            {
                p4 = 1;
            }
            if (rbp4b.Checked == true)
            {
                p4 = 2;
            }
            if (rbp4c.Checked == true)
            {
                p4 = 3;
            }
            if (rbp4d.Checked == true)
            {
                p4 = 4;
            }


            if (rbp5a.Checked == true)
            {
                p5 = 1;
            }
            if (rbp5b.Checked == true)
            {
                p5 = 2;
            }
            if (rbp5c.Checked == true)
            {
                p5 = 3;
            }
            if (rbp5d.Checked == true)
            {
                p5 = 4;
            }


            function.sessiontwo two = new function.sessiontwo();
            double acerto = two.vquiz(p1, p2, p3, p4, p5);
            lbltotal.Text = Convert.ToString(acerto);
            lbltotal.Visible = true;
            lblp.Visible = true;
            lblvca.Visible = true;
             }
             catch(Exception)
             {
                lbltotal.Text = "barra de progresso cheia";
                lbltotal.Visible = true;
            }
        }

        private void rbp1a_CheckedChanged(object sender, EventArgs e)
        {
          
            if (barra.Value < 100)
            { barra.Value += 20; }
        }

        private void rbp1b_CheckedChanged(object sender, EventArgs e)
        {


            if (barra.Value < 100)
            { barra.Value += 20; }
        }

        private void rbp1c_CheckedChanged(object sender, EventArgs e)
        {


            if (barra.Value < 100)
            { barra.Value += 20; }
        }

        private void rbp1d_CheckedChanged(object sender, EventArgs e)
        {


            if (barra.Value < 100)
            { barra.Value += 20; }
        }

        private void rbp2a_CheckedChanged(object sender, EventArgs e)
        {

            if (barra.Value < 100)
            { barra.Value += 20; }
        }

        private void rbp2b_CheckedChanged(object sender, EventArgs e)
        {

            if (barra.Value < 100)
            { barra.Value += 20; }
        }

        private void rbp2c_CheckedChanged(object sender, EventArgs e)
        {

            if (barra.Value < 100)
            { barra.Value += 20; }
        }

        private void rbp2d_CheckedChanged(object sender, EventArgs e)
        {

            if (barra.Value < 100)
            { barra.Value += 20; }
        }

        private void rbp3a_CheckedChanged(object sender, EventArgs e)
        {

            if (barra.Value < 100)
            { barra.Value += 20; }
        }

        private void rbp3b_CheckedChanged(object sender, EventArgs e)
        {

            if (barra.Value < 100)
            { barra.Value += 20; };
        }

        private void rbp3c_CheckedChanged(object sender, EventArgs e)
        {

            if (barra.Value < 100)
            { barra.Value += 20; }
        }

        private void rbp3d_CheckedChanged(object sender, EventArgs e)
        {

            if (barra.Value < 100)
            { barra.Value += 20; }
        }

        private void rbp4a_CheckedChanged(object sender, EventArgs e)
        {

            if (barra.Value < 100)
            { barra.Value += 20; }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void rbp4b_CheckedChanged(object sender, EventArgs e)
        {

            if (barra.Value < 100)
            { barra.Value += 20; }
        }

        private void rbp4c_CheckedChanged(object sender, EventArgs e)
        {

            if (barra.Value < 100)
            { barra.Value += 20; }
        }

        private void rbp4d_CheckedChanged(object sender, EventArgs e)
        {

            if (barra.Value < 100)
            { barra.Value += 20; }
        }

        private void rbp5a_CheckedChanged(object sender, EventArgs e)
        {

            if (barra.Value < 100)
            { barra.Value += 20; }
        }

        private void rbp5b_CheckedChanged(object sender, EventArgs e)
        {

            if (barra.Value < 100)
            { barra.Value += 20; }
        }

        private void rbp5c_CheckedChanged(object sender, EventArgs e)
        {

            if (barra.Value < 100)
            { barra.Value += 20; }
        }

        private void rbp5d_CheckedChanged(object sender, EventArgs e)
        {

            if (barra.Value < 100)
            { barra.Value += 20; }
        }
    }
}
