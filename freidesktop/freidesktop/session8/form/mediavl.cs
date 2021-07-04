using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.session8.form
{
    public partial class mediavl : Form
    {
        public mediavl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal nota1 = Convert.ToDecimal(txt1bi.Text);
            decimal nota2 = Convert.ToDecimal(txt2bi.Text);
            decimal nota3 = Convert.ToDecimal(txt3bi.Text);
            decimal nota4 = Convert.ToDecimal(txt4bi.Text);
            decimal recu = Convert.ToDecimal(txtrecu.Text);

            function.sessioneight m = new function.sessioneight();
            decimal total= m.calcmedia1(nota1, nota2, nota3, nota4);

            lbltotal.Text = total.ToString();
            lbltotal.Visible = true;

            bool passou = m.vmedia(total);
            if (passou == true)
            {
                lblpassou.Text = "Você passou";
                lbltotal.Visible = true;
            }
            else 
           { lblpassou.Text = "Você não passou digite sua nota de recuperação";
                lblpassou.Visible = true;
                txtrecu.Visible = true;
                lblrecu.Visible = true; 
                }


        }
    }
}
