using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freitrabalho.telas.login
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            txtsenha.UseSystemPasswordChar = true;
        }

        private void lblcadastro_Click(object sender, EventArgs e)
        {
            telas.cadastrarusuario m = new cadastrarusuario();
            m.Show();
        }

        private void picclose_MouseEnter(object sender, EventArgs e)
        {
            picclose.BackColor = Color.Maroon;
        }

        private void picclose_MouseLeave(object sender, EventArgs e)
        {
            picclose.BackColor = Color.Teal;
        }

        private void picclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        private void picbarra_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblrecusenha_Click(object sender, EventArgs e)
        {
            string nick = Convert.ToString(txtnickusuario.Text);
            bussines.bussinesusuario busuario = new bussines.bussinesusuario();
            string email = busuario.buscaremail(nick);
            if(email != string.Empty)
            { MessageBox.Show("email enviado para " + email); }
            else
            { MessageBox.Show("usuario não encontrado"); }
        }
    }
}
