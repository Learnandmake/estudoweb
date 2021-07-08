using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freientity
{
    public partial class session : Form
    {
        public session()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = (DateTime.Now.ToString("HH:mm:ss"));
        }

        private void picfecha_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
