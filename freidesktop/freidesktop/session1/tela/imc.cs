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
    public partial class imc : Form
    {
        public imc()
        {
            InitializeComponent();
        }

        private void btnfmc_Click(object sender, EventArgs e)
        {try
            {
                function.sessionone menu = new function.sessionone();

                double altura = Convert.ToDouble(nudaltura.Value);
                double peso = Convert.ToDouble(nudpeso.Value);
                string resultado = Convert.ToString(menu.calcimc(peso, altura));
                
                resposta.Visible = true;
                lblfmc.Text = resultado;
                lblfmc.Visible = true;

                


            }

            catch(Exception)
            { resposta.Text = "erro verifique o formulario";
                resposta.Visible = true;
             }
          
        }
    }
}
