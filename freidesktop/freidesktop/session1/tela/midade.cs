using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.session1.tela
{
    public partial class midade : Form
    {
        public midade()
        {
            InitializeComponent();
        }

        private void btnfmc_Click(object sender, EventArgs e)
        {
        try
            {
                int idade = Convert.ToInt32(txtidade.Text);
                function.sessionone vmidade = new function.sessionone();
                bool re = vmidade.vmidade(idade);
                if(re==true)
                {
                lblresposta.Visible=true;
                    lblfmc.Visible = true;
                    lblfmc.Text = "maior de idade";
                }
                else
                {
                    lblresposta.Visible = true;
                    lblfmc.Visible = true;
                    lblfmc.Text = "menor de idade";
                }
              } 
          

            catch(Exception)
            {
                lblresposta.Text = "erro verifique o formulario";
                lblresposta.Visible = true;
                lblfmc.Visible = false;
            }
        }


    }
}
