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
    public partial class corprimaria : Form
    {
        public corprimaria()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
        try
        {
                string cor1 = Convert.ToString(cbo1cor.SelectedItem);
                string cor2 = Convert.ToString(cbo2cor.SelectedItem);

                function.sessionone one = new function.sessionone();

                lblcor.Text = one.cor(cor1, cor2);
                lblcor.Visible = true;
                lbltcor.Visible = true;

            }
           
            catch(Exception)
            {
                lblcor.Text = "Erro verifique o formulario";
                lblcor.Visible = true;
            }
        }
    }
}
