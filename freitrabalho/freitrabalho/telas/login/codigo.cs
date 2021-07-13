using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freitrabalho.telas.login
{
    public partial class codigo : Form
    {
        public codigo(int codigo, string nick)
        {
            InitializeComponent();
            lblnick.Text = nick;
            lblcodigo.Text = Convert.ToString(codigo);
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            string nick = lblnick.Text;
         string codigo1 = lblcodigo.Text;
            if (codigo1 == txtcodigo.Text)
            {
                recusenha m = new recusenha(nick);
                m.Show();
                
                telas.login.codigo codigo2 = new codigo(1,nick);
                codigo2.Visible = false;
                
            }
        }

     
    }
}
