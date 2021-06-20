using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.session3.menu
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.facebook m = new form.facebook();
            m.Show();
        }

        private void facebookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form.facebook m = new form.facebook();
            m.Show();
        }
    }
}
