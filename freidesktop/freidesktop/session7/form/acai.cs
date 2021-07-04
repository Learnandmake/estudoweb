using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.session7.form
{
    public partial class acai : Form
    {
        public acai()
        {
            InitializeComponent();
        }

        private void numacai300_ValueChanged(object sender, EventArgs e)
        {

            decimal acai1 = numacai300.Value;
            decimal acai2 = numacai500.Value;
            decimal pastelnormal = numpasteln.Value;
            decimal pasteldoce = numpasteldoce.Value;
            decimal pastelespecial = numpastelespecial.Value;
            decimal acompanhamento = 0;

            if (cbbanana.Checked == true)
            {
                acompanhamento += 1;
            }

            if (cbkiwi.Checked == true)
            {
                acompanhamento += 1;
            }

            if (cblconde.Checked == true)
            {
                acompanhamento += 1;
            }

            if (cbmorango.Checked == true)
            {
                acompanhamento += 1;
            }

            if (cblninho.Checked == true)
            {
                acompanhamento += 1;
            }

            if (cbbanana.Checked == false && cbkiwi.Checked == false && cblconde.Checked == false && cbmorango.Checked == false && cblninho.Checked == false)
            {
                acompanhamento = 0;
            }
            function.sessionseven m = new function.sessionseven();
            decimal total = m.total(acai1, acai2, acompanhamento, pastelnormal, pastelespecial, pasteldoce);
            lbltotal.Text = total.ToString();
        }

        private void picclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
