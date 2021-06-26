using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.session6.form
{
    public partial class inicial : Form
    {
        public inicial()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncomprar_Click(object sender, EventArgs e)
        {

            comprar m = new comprar();
            m.Show();
            this.Visible = false;

        }
    }
}
