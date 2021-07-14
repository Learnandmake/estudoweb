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

namespace freitrabalho.telas.mapa
{
    public partial class mapabrasil : Form
    {
        public mapabrasil()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        private void picclose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void picclose_MouseEnter(object sender, EventArgs e)
        {
            picclose.BackColor = Color.Maroon;
        }

        private void picclose_MouseLeave(object sender, EventArgs e)
        {
            picclose.BackColor = Color.Teal;
        }

        private void picbarra_MouseMove(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void mapabrasil_MouseMove(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
