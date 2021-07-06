using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.sessionvtwelve.menu
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void filmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.filme m = new form.filme();
            m.Show();
        }
    }
}
