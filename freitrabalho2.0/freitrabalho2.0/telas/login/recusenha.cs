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

namespace freitrabalho2._0.telas.login
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
            string senha1 = Convert.ToString(txtsenha.Text);

            nick.Trim();
            senha1.Trim();
            nick.ToLower();
            senha1.ToLower();

            database.entity.tbusuario usuario = new database.entity.tbusuario();
            database.entity.tblogin login = new database.entity.tblogin();
            bussines.bussineslogin blogin = new bussines.bussineslogin();
            bussines.bussinesusuario busuario = new bussines.bussinesusuario();
            function.criptografia criptografia = new function.criptografia();

            string senha2 = criptografia.gerarmd5(senha1);

            if (txtsenha.Text == txtcsenha.Text)
            {
                usuario = busuario.buscaridpornick(nick);
                login.idusuario = usuario.idusuario;
                login.senha = senha2;
                login.nick = usuario.nick;
                blogin.alterar(login);
                MessageBox.Show("Operação concluida com sucesso");
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("as senhas não coincidem");
            }
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

        private void picclose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void picclose_MouseLeave(object sender, EventArgs e)
        {
            picclose.BackColor = Color.Teal;
        }

        private void picclose_MouseEnter(object sender, EventArgs e)
        {
            picclose.BackColor = Color.Maroon;
        }
    }
}
