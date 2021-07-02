using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.session7.menu
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void acaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.acai m = new form.acai();
            m.Show();
        }
    }
}
