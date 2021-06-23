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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            txtsenha.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = Convert.ToString(txtlogin.Text);
            string senha = Convert.ToString(txtsenha.Text);

           if (usuario=="conhecimento" && senha=="knowledge")
            {
                session5.menu.menus5 m = new menu.menus5();
                m.Show();
                this.Visible = false;
                
            }
            else
            {
                lblaviso.Visible = true;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
