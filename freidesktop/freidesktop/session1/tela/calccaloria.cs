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
                 if (btnchurra.Checked == true)
                    opcaocomida = 2;
                if (btnlanchenatural.Checked == true)
                    opcaocomida = 3;


                 if (btncocacola.Checked == true)
                    opcaobebida = 1;
                 if (btnsucocaixa.Checked == true)
                    opcaobebida = 2;
                 if (btnsuconatural.Checked == true)
                    opcaobebida = 3;


                 if (btnacai.Checked == true)
                    opcaosobremesa = 1;
                 if (btnbolo.Checked == true)
                    opcaosobremesa = 2;
                 if (btnmousse.Checked == true)
                    opcaosobremesa = 3;

                function.sessionone one = new function.sessionone();

                double caloria = one.calccaloria(opcaocomida, opcaobebida, opcaosobremesa);

                lbltotal.Text = Convert.ToString(caloria);
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
