using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.session8.menu
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void mediavlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.mediavl m = new form.mediavl();
            m.Show();
        }
    }
}
