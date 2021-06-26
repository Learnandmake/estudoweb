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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
            txtsenha.UseSystemPasswordChar = true;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string login = txtlogin.Text.ToString();
            string senha = txtsenha.Text.ToString();

            if(login == "adm" && senha== "1234"  || login=="cliente" && senha == "4321" )
            {
                inicial m = new inicial();
                m.Show();
                this.Visible = false;            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
