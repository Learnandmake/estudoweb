using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.session6.form
{
    public partial class comprar : Form
    {
        public comprar()
        {
            InitializeComponent();
        }
      
            
          

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
        //asento
        private void h1_Click(object sender, EventArgs e)
        {
        if(h1.BackColor == Color.LimeGreen)
        {
                h1.BackColor = Color.Firebrick;
        }
        else
        { h1.BackColor = Color.LimeGreen; }
        }

        private void g1_Click(object sender, EventArgs e)
        {
            if (g1.BackColor == Color.LimeGreen)
            {
                g1.BackColor = Color.Firebrick;
            }
            else
            { g1.BackColor = Color.LimeGreen; }
        
    }

        private void f1_Click(object sender, EventArgs e)
        {
            if (f1.BackColor == Color.LimeGreen)
            {
                f1.BackColor = Color.Firebrick;
            }
            else
            { f1.BackColor = Color.LimeGreen; }

        }

        private void e1_Click(object sender, EventArgs e)
        {
            if (e1.BackColor == Color.LimeGreen)
            {
                e1.BackColor = Color.Firebrick;
            }
            else
            { e1.BackColor = Color.LimeGreen; }
        }

        private void d1_Click(object sender, EventArgs e)
        {
            if (d1.BackColor == Color.LimeGreen)
            {
                d1.BackColor = Color.Firebrick;
            }
            else
            { d1.BackColor = Color.LimeGreen; }
        }

        private void c1_Click(object sender, EventArgs e)
        {
            if (c1.BackColor == Color.LimeGreen)
            {
                c1.BackColor = Color.Firebrick;
            }
            else
            { c1.BackColor = Color.LimeGreen; }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (b1.BackColor == Color.LimeGreen)
            {
                b1.BackColor = Color.Firebrick;
            }
            else
            { b1.BackColor = Color.LimeGreen; }
        }

        private void a1_Click(object sender, EventArgs e)
        {
            if (a1.BackColor == Color.LimeGreen)
            {
                a1.BackColor = Color.Firebrick;
            }
            else
            { a1.BackColor = Color.LimeGreen; }
        }

        private void a2_Click(object sender, EventArgs e)
        {
            if (a2.BackColor == Color.LimeGreen)
            {
                a2.BackColor = Color.Firebrick;
            }
            else
            { a2.BackColor = Color.LimeGreen; }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (b2.BackColor == Color.LimeGreen)
            {
                b2.BackColor = Color.Firebrick;
            }
            else
            { b2.BackColor = Color.LimeGreen; }
        }

        private void c2_Click(object sender, EventArgs e)
        {
            if (c2.BackColor == Color.LimeGreen)
            {
                c2.BackColor = Color.Firebrick;
            }
            else
            { c2.BackColor = Color.LimeGreen; }
        }

        private void d2_Click(object sender, EventArgs e)
        {
            if (d2.BackColor == Color.LimeGreen)
            {
                d2.BackColor = Color.Firebrick;
            }
            else
            { d2.BackColor = Color.LimeGreen; }
        }

        private void f2_Click(object sender, EventArgs e)
        {
            if (f2.BackColor == Color.LimeGreen)
            {
                f2.BackColor = Color.Firebrick;
            }
            else
            { f2.BackColor = Color.LimeGreen; }
        }

        private void g2_Click(object sender, EventArgs e)
        {
            if (g2.BackColor == Color.LimeGreen)
            {
                g2.BackColor = Color.Firebrick;
            }
            else
            { g2.BackColor = Color.LimeGreen; }
        }

        private void a3_Click(object sender, EventArgs e)
        {
            if (a3.BackColor == Color.LimeGreen)
            {
                a3.BackColor = Color.Firebrick;
            }
            else
            { a3.BackColor = Color.LimeGreen; }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (b3.BackColor == Color.LimeGreen)
            {
                b3.BackColor = Color.Firebrick;
            }
            else
            { b3.BackColor = Color.LimeGreen; }
        }

        private void c3_Click(object sender, EventArgs e)
        {
            if (c3.BackColor == Color.LimeGreen)
            {
                c3.BackColor = Color.Firebrick;
            }
            else
            { c3.BackColor = Color.LimeGreen; }
        }

        private void d3_Click(object sender, EventArgs e)
        {
            if (d3.BackColor == Color.LimeGreen)
            {
                d3.BackColor = Color.Firebrick;
            }
            else
            { d3.BackColor = Color.LimeGreen; }
        }

        private void cbofilme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbofilme.SelectedItem.ToString() == "Harry potter")
            {
                try
                {
                    decimal inteira = nudinteira.Value;
                    decimal meia = nudmeia.Value;
                    string filme = cbofilme.SelectedItem.ToString();
                    string cupom = txtcupom.Text;
                    DateTime dia = dtpagendar.Value;
                    cupom.ToLower();
                    function.sessionsix six = new function.sessionsix();
                    decimal total = six.calctotal(filme, inteira, meia, cupom, dia);
                    lbltotal.Text = total.ToString();
                }
                catch (Exception)
                { }
                picharry.Visible = true;
                picavenger.Visible = false;
                picveloz.Visible = false;
                gsinopse.Visible = true;
                lblsinopse.Text = "Depois da sessão você vai sair falando as magia e fingindo que tem uma varinha";
             }

            if (cbofilme.SelectedItem.ToString() == "Velozes e furiosos")
            {
                try
                {
                    decimal inteira = nudinteira.Value;
                    decimal meia = nudmeia.Value;
                    string filme = cbofilme.SelectedItem.ToString();
                    string cupom = txtcupom.Text;
                    DateTime dia = dtpagendar.Value;
                    cupom.ToLower();
                    function.sessionsix six = new function.sessionsix();
                    decimal total = six.calctotal(filme, inteira, meia, cupom, dia);
                    lbltotal.Text = total.ToString();
                }
                catch (Exception)
                { }
                picharry.Visible = false;
                picavenger.Visible = false;
                picveloz.Visible = true;
                gsinopse.Visible = true;
                lblsinopse.Text = "Louco demais, e o toretto ainda continua careca";
            }


            if (cbofilme.SelectedItem.ToString() == "Avengers")
            {
                try
                {
                    decimal inteira = nudinteira.Value;
                    decimal meia = nudmeia.Value;
                    string filme = cbofilme.SelectedItem.ToString();
                    string cupom = txtcupom.Text;
                    DateTime dia = dtpagendar.Value;
                    cupom.ToLower();
                    function.sessionsix six = new function.sessionsix();
                    decimal total = six.calctotal(filme, inteira, meia, cupom, dia);
                    lbltotal.Text = total.ToString();
                }
                catch (Exception)
                { }
                picharry.Visible = false;
                picavenger.Visible = true;
                picveloz.Visible = false;
                gsinopse.Visible = true;
                lblsinopse.Text = "Como você ainda não assitiu?";
            }
        }
        public void calc (string filme,decimal inteira,decimal meia)
        {
          
          
        }
        private void lblcupom_Click(object sender, EventArgs e)
        {
            lblcupom.Visible = false;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                decimal inteira = nudinteira.Value;
                decimal meia = nudmeia.Value;
                string filme = cbofilme.SelectedItem.ToString();
                string cupom = txtcupom.Text;
                DateTime dia = dtpagendar.Value;
                cupom.ToLower();
                function.sessionsix six = new function.sessionsix();
                decimal total = six.calctotal(filme, inteira, meia, cupom, dia);
                lbltotal.Text = total.ToString();
            }
            catch (Exception)
            { }
        }
        private void nudinteira_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                decimal inteira = nudinteira.Value;
                decimal meia = nudmeia.Value;
                string filme = cbofilme.SelectedItem.ToString();
                string cupom = txtcupom.Text;
                DateTime dia = dtpagendar.Value;
                cupom.ToLower();
                function.sessionsix six = new function.sessionsix();
                decimal total = six.calctotal(filme, inteira, meia, cupom, dia);
                lbltotal.Text = total.ToString();
            }
            catch (Exception)
            { }
        }

        private void nudmeia_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                decimal inteira = nudinteira.Value;
                decimal meia = nudmeia.Value;
                string filme = cbofilme.SelectedItem.ToString();
                string cupom = txtcupom.Text;
                DateTime dia = dtpagendar.Value;
                cupom.ToLower();
                function.sessionsix six = new function.sessionsix();
                decimal total = six.calctotal(filme, inteira, meia, cupom, dia);
                lbltotal.Text = total.ToString();
            }
            catch (Exception)
            { }
        }

        private void dtpagendar_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                decimal inteira = nudinteira.Value;
                decimal meia = nudmeia.Value;
                string filme = cbofilme.SelectedItem.ToString();
                string cupom = txtcupom.Text;
                DateTime dia = dtpagendar.Value;
                cupom.ToLower();
                function.sessionsix six = new function.sessionsix();
                decimal total = six.calctotal(filme, inteira, meia, cupom, dia);
                lbltotal.Text = total.ToString();
            }
            catch(Exception)
            { }
        }
    }
}
