using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freitrabalho.telas
{
    public partial class cadastrarusuario : Form
    {
        public cadastrarusuario()
        {
            InitializeComponent();
            txtsenha.UseSystemPasswordChar = true;
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            string nome = Convert.ToString(txtnome.Text);
            string nick = Convert.ToString(txtnickusuario.Text);
            string email = Convert.ToString(txtnickusuario.Text);
            string senha = Convert.ToString(txtnickusuario.Text);

            bussines.bussineslogin blogin = new bussines.bussineslogin();
            bussines.bussinespergunta bpergunta = new bussines.bussinespergunta();
            bussines.bussinespontuacao bpontuacao = new bussines.bussinespontuacao();
            bussines.bussinesusuario busuario = new bussines.bussinesusuario();
            function.criptografia criptografia = new function.criptografia();
            string senha2 = criptografia.gerarmd5(senha);

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
