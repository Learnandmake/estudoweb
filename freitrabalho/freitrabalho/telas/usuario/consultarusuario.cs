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

namespace freitrabalho.telas.usuario
{
    public partial class consultarusuario : Form
    {
        public consultarusuario()
        {
            InitializeComponent();
        }

        private void picclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picclose_MouseLeave(object sender, EventArgs e)
        {
            picclose.BackColor = Color.Teal;
        }

        private void picclose_MouseEnter(object sender, EventArgs e)
        {
            picclose.BackColor = Color.Maroon;
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

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            string nome = Convert.ToString(txtnome.Text);
            string nick = Convert.ToString(txtnickusuario.Text);
            string email = Convert.ToString(txtemail.Text);
            string senha = Convert.ToString(txtnickusuario.Text);

            bussines.bussineslogin blogin = new bussines.bussineslogin();
            bussines.bussinespergunta bpergunta = new bussines.bussinespergunta();
            bussines.bussinespontuacao bpontuacao = new bussines.bussinespontuacao();
            bussines.bussinesusuario busuario = new bussines.bussinesusuario();
            function.criptografia criptografia = new function.criptografia();
            function.vemail fvemail = new function.vemail();
            string senha2 = criptografia.gerarmd5(senha);
            bool vemail = fvemail.isemail(email);
            if (vemail == false)
            { MessageBox.Show("Porfavor insira um e-mail valido"); }

            if (vemail == true)
            {
                database.entity.tblogin login = new database.entity.tblogin();
                database.entity.tbpergunta pergunta = new database.entity.tbpergunta();
                database.entity.tbpontuacao pontuacao = new database.entity.tbpontuacao();
                database.entity.tbusuario usuario = new database.entity.tbusuario();

                usuario.nick = nick;
                usuario.email = email;
                usuario.registro = DateTime.Now;
                login.nick = nick;
                login.senha = senha2;
                pontuacao.nick = nick;
                pontuacao.pontuacao = 0;

                busuario.inserir(usuario);
                blogin.inserir(login);
                bpontuacao.inserir(pontuacao);
                MessageBox.Show("Operação bem sucedida");
            }
        }
    }
}
