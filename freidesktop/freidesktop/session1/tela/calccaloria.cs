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
    public partial class calccaloria : Form
    {
        public calccaloria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        try
        {
                int opcaocomida = 0;
                int opcaobebida = 0;
                int opcaosobremesa = 0;

                if (btnFastFood.Checked == true)
                    opcaocomida = 1;
                else if (btnchurra.Checked == true)
                    opcaocomida = 2;
                else if (btnlanchenatural.Checked == true)
                    opcaocomida = 3;
                else if (btncocacola.Checked == true)
                    opcaobebida = 1;
                else if (btnsucocaixa.Checked == true)
                    opcaobebida = 2;
                else if (btnsuconatural.Checked == true)
                    opcaobebida = 3;
                else if (btnacai.Checked == true)
                    opcaosobremesa = 1;
                else if (btnbolo.Checked == true)
                    opcaosobremesa = 2;
                else if (btnmousse.Checked == true)
                    opcaosobremesa = 3;

                function.sessionone one = new function.sessionone();

                lbltotal.Text = Convert.ToString(one.calccaloria(opcaocomida, opcaobebida, opcaosobremesa));
                lbltotal.Visible = true;
                lbltconsumiu.Visible = true;
                lbltcal.Visible = true;
            }
            catch(Exception)
            {
                lbltotal.Text = "erro verifique o formulario";
                lbltotal.Visible = true;
            }


        }
    }
}
