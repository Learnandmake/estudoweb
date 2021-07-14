using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freitrabalho.telas.menu
{
    public partial class menuadm : Form
    {
        public menuadm(string nick)
        {
            InitializeComponent();
            lblnick.Text = nick;
        }

        private void picclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = (DateTime.Now.ToString("HH:mm:ss"));
        }

        private void picclose_MouseEnter(object sender, EventArgs e)
        {
            picclose.BackColor = Color.Maroon;
        }

        private void picclose_MouseLeave(object sender, EventArgs e)
        {
            picclose.BackColor = Color.Teal;
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
        private void lbltime_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void lblnick_MouseMove(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void piccadastrarpergunta_Click(object sender, EventArgs e)
        {
            telas.pergunta.cadastrar m = new pergunta.cadastrar();
            m.Show();
        }

        private void picconsultartop_Click(object sender, EventArgs e)
        {
            telas.usuario.topplayer m = new usuario.topplayer();
            m.Show();
        }

        private void picconsultar_Click(object sender, EventArgs e)
        {
            telas.usuario.consultarusuario m = new usuario.consultarusuario();
            m.Show();
        }

        private void piccadastraradm_Click(object sender, EventArgs e)
        {
            telas.adm.cadastro m = new adm.cadastro();
            m.Show();
        }


    }
}
