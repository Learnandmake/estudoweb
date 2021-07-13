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
    public partial class recusenha : Form
    {
        public recusenha(string nick)
        {
            InitializeComponent();
            lblnick.Text = nick;
            txtcsenha.UseSystemPasswordChar = true;
            txtsenha.UseSystemPasswordChar = true;
        }

    
        private void btncadastrar_Click(object sender, EventArgs e)
        {
            string nick = lblnick.Text;
            string senha = Convert.ToString(txtsenha.Text);
            
            if(txtsenha.Text == txtcsenha.Text)
            {
            
            }
            else
            {
                MessageBox.Show("as senhas não coincidem");
            }
        }
    }
}
