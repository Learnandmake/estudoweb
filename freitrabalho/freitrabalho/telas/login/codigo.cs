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
        public codigo(int codigo, string nick)
        {
            InitializeComponent();
            lblnick.Text = nick;
            lblcodigo.Text = Convert.ToString(codigo);
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
                
                telas.login.codigo codigo2 = new codigo(1,nick);
                codigo2.Visible = false;
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            telas.login.codigo codigo2 = new codigo(1, lblnick.Text);
            codigo2.Visible = false;
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
    }
}
