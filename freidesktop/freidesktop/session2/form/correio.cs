using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios;

namespace freidesktop.session2.form
{
    public partial class correio : Form
    {
        public correio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        try
            {
                string cep = Convert.ToString(mskcep.Text);

                Correios.CorreiosApi m = new CorreiosApi();
                var end = m.consultaCEP(cep);

                lblend.Text = end.end;
                lblend.Visible = true;
                lblbairro.Text = end.bairro;
                lblbairro.Visible = true;
                lblcidade.Text = end.cidade;
                lblcidade.Visible = true;
            }
           catch(Exception)
           {
                lblend.Text = "erro verifique o formulario";
                lblend.Visible = true;
                lblbairro.Visible = false;
                lblcidade.Visible = false;
            }
        }
    }
}
