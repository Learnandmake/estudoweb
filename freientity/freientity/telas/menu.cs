using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freientity.telas
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void sessionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            session A = new session();
            A.Show();
        }

        private void challengeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Challenge.Challenge A = new Challenge.Challenge();
            A.Show();
        }

        private void picclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
