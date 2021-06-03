using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.telamenu
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void oneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            session1.menu.menu one = new session1.menu.menu();
            one.Show();
            this.Visible = false;
        }
    }
}
