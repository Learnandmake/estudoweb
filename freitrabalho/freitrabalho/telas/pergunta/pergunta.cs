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

namespace freitrabalho.telas.pergunta
{
    public partial class pergunta : Form
    {
        int tempo = 200;
        int minuto = 0;
        int segundo = 0;
        public pergunta(string nick)
        {
            InitializeComponent();
            lblnick.Text = nick;

            function.escolhepergunta epergunta = new function.escolhepergunta();
        
            database.entity.tbpergunta pergunta= epergunta.escolherpergunta();
            lblenunciado.Text = pergunta.enunciado;
            lblala.Text = pergunta.palternativa;
            lblalb.Text = pergunta.salternativa;
            lblalc.Text = pergunta.talternativa;
            lblald.Text = pergunta.qalternativa;
            lblresposta.Text = pergunta.resposta;      
         
            bussines.bussinesusuario busuario = new bussines.bussinesusuario();
            bussines.bussinespontuacao bpontuacao = new bussines.bussinespontuacao();       
            database.entity.tbusuario usuario = new database.entity.tbusuario();
            database.entity.tbpontuacao pontuacao = new database.entity.tbpontuacao();

            usuario = busuario.buscaridpornick(nick); 
            pontuacao = bpontuacao.buscarpontuacaopnick(usuario.nick);
            string pontuacaof = Convert.ToString(pontuacao.pontuacao);
            lblpontuacao.Text = pontuacaof;
           
            
            if (tempo >=60) 
        {
                minuto = tempo / 60;
                segundo = tempo % 60;
        }
            else
            {
                minuto = 0;
                minuto = tempo;
            }

            lblminuto.Text = Convert.ToString(minuto);
            lblsegundo.Text = Convert.ToString(segundo);
            timer1.Enabled = true;
        }

        private void picbarra_Click(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        private void picclose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            telas.menu.menuplayer m  = new menu.menuplayer(lblnick.Text, lblpontuacao.Text);
            m.Show();
        }
        private void label2_MouseMove_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblpontuacao_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void picbarra_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblnick_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pergunta_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnenviar_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cboresposta_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblala_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblalb_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblalc_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label8_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblald_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picclose_MouseEnter(object sender, EventArgs e)
        {
            picclose.BackColor = Color.Maroon;
        }

        private void picclose_MouseLeave(object sender, EventArgs e)
        {
            picclose.BackColor = Color.Teal;
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            string resposta = Convert.ToString(cboresposta.SelectedItem);
            string nick =  lblnick.Text;

            function.escolhepergunta epergunta = new function.escolhepergunta();

            database.entity.tbpergunta pergunta = epergunta.escolherpergunta();

            bussines.bussinespontuacao bpontuacao = new bussines.bussinespontuacao();
            if (resposta == lblresposta.Text)
            {
                bpontuacao.addpontuacao(nick);
              
                lblenunciado.Text = pergunta.enunciado;
                lblala.Text = pergunta.palternativa;
                lblalb.Text = pergunta.salternativa;
                lblalc.Text = pergunta.talternativa;
                lblald.Text = pergunta.qalternativa;
                lblresposta.Text = pergunta.resposta;

                bussines.bussinesusuario busuario = new bussines.bussinesusuario();
                database.entity.tbusuario usuario = new database.entity.tbusuario();
                database.entity.tbpontuacao pontuacao = new database.entity.tbpontuacao();

                usuario = busuario.buscaridpornick(nick);
                pontuacao = bpontuacao.buscarpontuacaopnick(usuario.nick);
                string pontuacaof = Convert.ToString(pontuacao.pontuacao);
                lblpontuacao.Text = pontuacaof;
            

            }
            else
            {
            if(lblpontuacao.Text !="0")
                bpontuacao.reduzirpontuacao(nick);
                lblenunciado.Text = pergunta.enunciado;
                lblala.Text = pergunta.palternativa;
                lblalb.Text = pergunta.salternativa;
                lblalc.Text = pergunta.talternativa;
                lblald.Text = pergunta.qalternativa;
                lblresposta.Text = pergunta.resposta;

                bussines.bussinesusuario busuario = new bussines.bussinesusuario();
                database.entity.tbusuario usuario = new database.entity.tbusuario();
                database.entity.tbpontuacao pontuacao = new database.entity.tbpontuacao();

                usuario = busuario.buscaridpornick(nick);
                pontuacao = bpontuacao.buscarpontuacaopnick(usuario.nick);
                string pontuacaof = Convert.ToString(pontuacao.pontuacao);
                lblpontuacao.Text = pontuacaof;
               
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundo--;
            if (minuto > 0)
            {
                if (segundo < 0)
                {
                    segundo = 59;
                   
                    minuto--;
                }      
            }
            lblminuto.Text = Convert.ToString(minuto);
            lblsegundo.Text = Convert.ToString(segundo);
            if(minuto == 0 && segundo ==0)
            {
                MessageBox.Show("sessao encerrada");
                telas.menu.menuplayer m = new menu.menuplayer(lblnick.Text, lblpontuacao.Text);
                m.Show();
                this.Visible = false;
            }
        }
    }
}
