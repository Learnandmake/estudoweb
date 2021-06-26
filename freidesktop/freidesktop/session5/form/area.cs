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

        private void btna_Click(object sender, EventArgs e)
        { try
            {
                decimal b = nmb.Value;
                decimal a = nma.Value;

                picarea.Width = Convert.ToInt32(b);
                picarea.Height = Convert.ToInt32(a);

                function.sessionfive five = new function.sessionfive();

                decimal area = five.calcarea(b, a);
                decimal perimetro = five.calcper(b, a);

                lblarea.Text = area.ToString();
                lblper.Text = perimetro.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("erro verifique o formulario");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string frase = txtpfrase.Text.ToLower().ToString();

                function.sessionfive five = new function.sessionfive();

                int qtdai = five.qtdai(frase);
                lblai.Text = qtdai.ToString();
                int qtdar = five.qtdar(frase);
                lblad.Text = qtdar.ToString();
                int qtdpre = five.qtdpre(frase);
                lblqp.Text = qtdpre.ToString();
            }

            catch (Exception)
            {
                MessageBox.Show("erro verifique o formulario");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filosofo = cbofilosofo.SelectedItem.ToString();
            int pocicao = cbofilosofo.SelectedIndex;
            if (filosofo == "Sócrates")
            {
                lblcitacao.Text = "Só sei que nada sei.";
                picaritosteles.Visible = false;
                picepicro.Visible = false;
                picrene.Visible = false;
                picsocrates.Visible = true;
                picrich.Visible = false;
            }
            if (filosofo == "René Descartes")
            {
                picaritosteles.Visible = false;
                picepicro.Visible = false;
                picrene.Visible = true;
                picsocrates.Visible = false;
                picrich.Visible = false;
                lblcitacao.Text = "Daria tudo que sei pela metade do que ignoro.";
            }
            if (filosofo == "Aristóteles")
            {
                picaritosteles.Visible = true;
                picepicro.Visible = false;
                picrene.Visible = false;
                picsocrates.Visible = false;
                picrich.Visible = false;
                lblcitacao.Text = "A esperança é o sonho do homem acordado.";
            }
            if (filosofo == "Friedrich Nietzsche")
            {
                picaritosteles.Visible = false;
                picepicro.Visible = false;
                picrene.Visible = false;
                picsocrates.Visible = false;
                picrich.Visible = true;
                lblcitacao.Text = "Eu não sei o que quero ser, mas sei muito bem o que não quero me tornar.";
            }
            if (filosofo == "Epicuro")
            {
                picaritosteles.Visible = false;
                picepicro.Visible = true;
                picrene.Visible = false;
                picsocrates.Visible = false;
                picrich.Visible = false;
                lblcitacao.Text = "Nada é suficiente para quem considera pouco o suficiente.";
            }




        }

        private void picbefore_Click(object sender, EventArgs e)
        {
            try
            {

                if (cbofilosofo.SelectedIndex == 0)
                {
                    cbofilosofo.SelectedIndex += 4;
                }
                else
                {
                    cbofilosofo.SelectedIndex -= 1;
                }
            }

            catch (Exception)
            {

            }
        }

        private void picnext_Click(object sender, EventArgs e)
        {try
            {
                
                if (cbofilosofo.SelectedIndex ==4)
                {
                    cbofilosofo.SelectedIndex -= 4 ;
                }
                else
                {
                    cbofilosofo.SelectedIndex += 1;
                }
            }

    catch(Exception)
    {

    }
        }
        //sudeste
        private void lblsp_MouseEnter(object sender, EventArgs e)
        {
            lblcapital.Text = "São Paulo";
            lblestado.Text = "São Paulo";
        }

        private void lblmg_MouseEnter(object sender, EventArgs e)
        {
            lblcapital.Text = "Belo Horizonte";
            lblestado.Text = "Minas Gerais";
        }

        private void lblrj_MouseEnter(object sender, EventArgs e)
        {
            lblcapital.Text = "Rio de janeiro";
            lblestado.Text = "Rio de janeiro";
        }

        private void lbles_MouseEnter(object sender, EventArgs e)
        {
            lblcapital.Text = "Vitória";
            lblestado.Text = "Espírito Santo";
        }

        //sul
        private void lblpr_MouseEnter(object sender, EventArgs e)
        {
            lblcapital.Text = "Curitiba";
            lblestado.Text = "Paraná";
        }

        private void lblsc_MouseEnter(object sender, EventArgs e)
        {
            lblcapital.Text = "Florianópolis";
            lblestado.Text = "Santa Catarina";
        }

        private void lblrs_MouseEnter(object sender, EventArgs e)
        {
            lblcapital.Text = "Porto Alegre";
            lblestado.Text = "Rio Grande do Sul";
        }

        //centrooeste
        private void lblms_MouseEnter(object sender, EventArgs e)
        {
            lblcapital.Text = "Campo Grande";
            lblestado.Text = "Mato Grosso do Sul";
        }

        private void lblmt_MouseEnter(object sender, EventArgs e)
        {
            lblcapital.Text = "Cuiabá";
            lblestado.Text = "Mato Grosso";
        }

        private void lblgo_MouseEnter(object sender, EventArgs e)
        {
            lblcapital.Text = "Goiânia";
            lblestado.Text = "Goiás";
        }

        private void lbldf_MouseEnter(object sender, EventArgs e)
        {
            lblcapital.Text = "Brasília";
            lblestado.Text = "Distrito Federal";
        }

        //norte
        private void lblac_MouseEnter(object sender, EventArgs e)
        {
            lblcapital.Text = "Rio Branco";
            lblestado.Text = "Acre";
        }

        private void lblro_MouseEnter(object sender, EventArgs e)
        {
            lblcapital.Text = "Porto Velho";
            lblestado.Text = "Rondônia";
        }

        private void lblam_MouseEnter(object sender, EventArgs e)
        {
            lblcapital.Text = "Manaus";
            lblestado.Text = "Amazonas";
        }

        private void lblrr_MouseEnter(object sender, EventArgs e)
        {
            lblcapital.Text = "Boa Vista";
            lblestado.Text = "Roraima";
        }

        private void lblpa_MouseEnter(object sender, EventArgs e)
        {
            lblcapital.Text = "Belém";
            lblestado.Text = "Pará";
        }

        private void lblap_MouseEnter(object sender, EventArgs e)
        {
            lblcapital.Text = "Macapá";
            lblestado.Text = "Amapá";
        }

        private void lblto_MouseEnter(object sender, EventArgs e)
        {
            lblcapital.Text = "Palmas";
            lblestado.Text = "Tocantins";
        }

        //nordeste
        private void lblba_MouseEnter(object sender, EventArgs e)
        {
            lblcapital.Text = "Salvador";
            lblestado.Text = "Bahia";
        }

        private void lblse_MouseEnter(object sender, EventArgs e)
        {
            lblcapital.Text = "Aracaju";
            lblestado.Text = "Sergipe";
        }

        private void lblal_MouseEnter(object sender, EventArgs e)
        {
            lblcapital.Text = "Maceió";
            lblestado.Text = "Alagoas";
        }

        private void lblpe_MouseEnter(object sender, EventArgs e)
        {
            lblcapital.Text = "Recife";
            lblestado.Text = "Pernambuco";
        }

        private void lblpb_MouseEnter(object sender, EventArgs e)
        {
            lblcapital.Text = "João Pessoa";
            lblestado.Text = "Paraíba";
        }

        private void lblrn_MouseEnter(object sender, EventArgs e)
        {
            lblcapital.Text = "Natal";
            lblestado.Text = "Rio Grande do Norte";
        }

        private void lblce_MouseEnter(object sender, EventArgs e)
        {
            lblcapital.Text = "Fortaleza";
            lblestado.Text = "Ceará";
        }

        private void lblpi_MouseEnter(object sender, EventArgs e)
        {
            lblcapital.Text = "Teresina";
            lblestado.Text = "Piauí";
        }

        private void lblma_MouseEnter(object sender, EventArgs e)
        {
            lblcapital.Text = "São Luís";
            lblestado.Text = "Maranhão";
        }

        private void cboelemento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string elemento = cboelemento.SelectedItem.ToString();

            if(elemento =="ouro")
            {
                picouro.Visible = true;
                picprata.Visible = false;
                picc.Visible = false;
            }
            if (elemento == "prata")
            {
                picouro.Visible = false;
                picprata.Visible = true;
                picc.Visible = false;
            }
            if (elemento == "agua")
            {
                picouro.Visible = false;
                picprata.Visible = false;
                picc.Visible = true;
            }
            nudgrau.Maximum = 2865;
            lblqestado.Text = "Estado:";
            lblqestado.ForeColor = Color.Black;
            nudgrau.Minimum = -20;
            nudgrau.Value = -20;
        }

        private void nudgrau_ValueChanged(object sender, EventArgs e)
        {
            decimal grau = nudgrau.Value;
            
            if(grau== 0 &&cboelemento.SelectedItem.ToString()== "agua")
            {
                lblqestado.Text = "Liquido";
                lblqestado.ForeColor = Color.Blue;
            }

            if (grau >= 100 && cboelemento.SelectedItem.ToString() == "agua")
            {
                lblqestado.Text = "Gás";
                lblqestado.ForeColor = Color.Red;
            }
            if (grau >= 1538 && cboelemento.SelectedItem.ToString() == "prata")
            {
                lblqestado.Text = "Liquido";
                lblqestado.ForeColor = Color.Green;
            }
            if (grau >= 2861 && cboelemento.SelectedItem.ToString() == "prata")
            {
                lblqestado.Text = "Gás";
                lblqestado.ForeColor = Color.Red;
            }
            if (grau >= 1064 && cboelemento.SelectedItem.ToString() == "ouro")
            {
                lblqestado.Text = "Liquido";
                lblqestado.ForeColor = Color.Green;
            }
            if (grau >= 2865 && cboelemento.SelectedItem.ToString() == "ouro")
            {
                lblqestado.Text = "Gás";
                lblqestado.ForeColor = Color.Red;
            }
        }
    }
}
