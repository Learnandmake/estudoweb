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
          try 
            {
                bussines.bussinesusuario busuario = new bussines.bussinesusuario();
                bussines.bussineslogin blogin = new bussines.bussineslogin();
                function.enviaremail enviaremail = new function.enviaremail();
                database.entity.tbusuario usuario = new database.entity.tbusuario();
                database.entity.tblogin login= new database.entity.tblogin();
                function.gerarcodigo gcogido = new function.gerarcodigo();
                int codigo = gcogido.gcodigo();

                usuario = busuario.buscarusuariopornick(nick);
                login = blogin.buscarloginpornick(nick);
                string senha = Convert.ToString(login.senha);
                enviaremail.ConfigurarCredenciais("testinmail21@gmail.com", "98847685");
                enviaremail.Enviar(usuario.email, "recuperaçao de senha", "aqui esta seu codigo"+" "+codigo);

                telas.login.codigo telacodigo = new telas.login.codigo(codigo, nick, usuario.email);
                telacodigo.Show();
            }
      
            catch(Exception)
            {
                MessageBox.Show("usuario não encontrado");
            }
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
        try
        {

                string nick = Convert.ToString(txtnickusuario.Text);
                string senha1 = Convert.ToString(txtnickusuario.Text);
                nick.Trim();
                senha1.Trim();
                nick.ToLower();
                senha1.ToLower();
             
                function.criptografia criptografia = new function.criptografia();
                bussines.bussineslogin blogin = new bussines.bussineslogin();
                bussines.bussinesusuario busuario = new bussines.bussinesusuario();
                bussines.bussinespontuacao bpontuacao = new bussines.bussinespontuacao();
                database.entity.tblogin login = new database.entity.tblogin();
                database.entity.tbusuario usuario = new database.entity.tbusuario();
                database.entity.tbpontuacao pontuacao = new database.entity.tbpontuacao();

                 string senha2 = criptografia.gerarmd5(senha1);

                usuario = busuario.buscaridpornick(nick);
                login = blogin.fazerlogin(nick, senha2);
                pontuacao = bpontuacao.buscarpontuacaopnick(usuario.nick);
                string pontuacaof = Convert.ToString(pontuacao.pontuacao);
                if (login != null)
                {
                    if (usuario.cargo == "adm")
                    {
                        menu.menuadm m = new menu.menuadm(nick);
                        m.Show();
                        this.Visible = false;
                    }
                    if (usuario.cargo == "player")
                    {
                        menu.menuplayer m = new menu.menuplayer(nick,pontuacaof);
                        m.Show();
                        this.Visible = false;
                    }
                }
                else {
                    MessageBox.Show("usuario não encontrado");
                }
            }
            catch(Exception)
            { MessageBox.Show("Erro por favor verifique o formulario"); }
        }
    }
}
