using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.session2.form
{
    public partial class enviaremail : Form
    {
        public enviaremail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string email = "testinmail21@gmail.com";
                string password = "98847685";

                function.sessiontwo credencial = new function.sessiontwo();
                credencial.ConfigurarCredenciais(email, password);

                string para = Convert.ToString(txtpara.Text);
                string assunto = Convert.ToString(txtassunto.Text);
                string mensagem = Convert.ToString(txtmensagem.Text);

                credencial.Enviar(para, assunto, mensagem);
                lblok.Text = "Sua mensagem foi enviada";
                lblok.Visible = true;

            }

            catch (Exception)
            {
                lblok.Text = "Erro verifique o formulario";
                lblok.Visible = true;

            }
        }
    }
}
