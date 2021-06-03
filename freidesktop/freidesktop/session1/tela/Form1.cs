using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnfmc_Click(object sender, EventArgs e)
        {
        try
        {
                int idade = Convert.ToInt32(txtidade.Text);
                function.sessionone fmc = new function.sessionone();
                string re = Convert.ToString( fmc.calcfmc(idade));
                resposta.Visible = true;
                lblfmc.Text =re;
                lblfmc.Visible=true;


        }
        catch(Exception)
        {
                resposta.Text = "erro verifique o formulario";
                resposta.Visible = true;
                lblfmc.Visible = false;
            }
        }
    }
}
