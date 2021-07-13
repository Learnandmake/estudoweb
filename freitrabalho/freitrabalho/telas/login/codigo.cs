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
    public partial class codigo : Form
    {
        public codigo(int codigo, string nick, string email)
        {
            InitializeComponent();
            lblnick.Text = nick;
            lblcodigo.Text = Convert.ToString(codigo);
            lblnickaviso.Text = email;
            txtcodigo.MaxLength = 9;

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            string nick = lblnick.Text;
         string codigo1 = lblcodigo.Text;
            if (codigo1 == txtcodigo.Text)
            {
                recusenha m = new recusenha(nick);
                m.Show();

                this.Visible = false;
                
            }
            else
            {
                MessageBox.Show("código incorreto");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Maroon;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Teal;
        }
    }
}
