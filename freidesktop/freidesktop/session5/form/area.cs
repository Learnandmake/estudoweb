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
    }
}
