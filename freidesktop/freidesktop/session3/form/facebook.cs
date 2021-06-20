using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.session3.form
{
    public partial class facebook : Form
    {
        public facebook()
        {
            InitializeComponent();
            txtsenha.UseSystemPasswordChar = true;
        }

        private void cboidioma_TextChanged(object sender, EventArgs e)
        {
            string idioma = Convert.ToString(cboidioma.SelectedItem);

            if (idioma == "Brasil")
            { 
                picfbbr.Visible = true;
                picfbesp.Visible = false;
                picfbeua.Visible = false;
                picfb.Visible = false;    
             }
            if (idioma == "Espanha")
            {
                picfbbr.Visible = false;
                picfbesp.Visible = true;
                picfbeua.Visible = false;
                picfb.Visible = false;
            }
            if (idioma == "Estados Unidos")
            {
                picfbbr.Visible = false;
                picfbesp.Visible = false;
                picfbeua.Visible = true;
                picfb.Visible = false;
            }

        }

        private void cboutro_CheckedChanged(object sender, EventArgs e)
        {
            if(cboutro.Checked == true)
            {
                txtoutro.Visible = true;
            }
            else
            {
                txtoutro.Visible = false;
            }
        }

        private void dtpnasc_ValueChanged(object sender, EventArgs e)
        {
            bool vidade = false;

            function.sessionthree three = new function.sessionthree();
            vidade = three.vidade(dtpnasc.Value);
         
            if(vidade==true )
            {
                lblaviso.Visible = false;
                btncadastro.Enabled = true;
            }
            else
            {
                lblaviso.Visible = true;
                lblaviso.Text = "Tem que ser maior de idade";
                btncadastro.Enabled = false;
            }
        }

        private void mskcep_TextChanged(object sender, EventArgs e)
        {
           string cep1= String.Join("", System.Text.RegularExpressions.Regex.Split(mskcep.Text, @"[^\d]"));
            int n = cep1.Length;
           
         if(n == 8)
            {
                string cep = Convert.ToString(mskcep.Text);
                Correios.CorreiosApi correio = new Correios.CorreiosApi();
                var endereco =  correio.consultaCEP(cep);
                lblrua.Text = endereco.end;
                lblrua.Visible = true;
                lblbairro.Text = endereco.bairro;
                lblbairro.Visible = true;
                lblcidade.Text = endereco.cidade;
                lblcidade.Visible = true;
                lblestado.Text = endereco.uf;
                lblestado.Visible = true;
            }
        }

        private void btncadastro_Click(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {
            if(txtnome.TextLength <=0)
            {
                txtnome.BackColor = Color.Red;
                txtnome.ForeColor = Color.White;
            }
            else
            {
                txtnome.BackColor = Color.White;
                txtnome.ForeColor = Color.Black;
            }
        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {
            txtsenha.Text.ToLower();
            txtsenha.Text.Trim();
            txtcsenha.Text.ToLower();
            txtcsenha.Text.Trim();
       
            if (txtsenha.Text.Length <=3)
            {
                lblfsenha.Text = "Fraca";
                lblfsenha.Visible = true;
            }
            if (txtsenha.Text.Length >=4 && txtsenha.Text.Length <=7)
            {
                lblfsenha.Text = "Média";
                lblfsenha.Visible = true;
            }
            if (txtsenha.Text.Length >= 8 )
            {
                lblfsenha.Text = "Forte";
                lblfsenha.Visible = true;
            }
        }
    }
}
