using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.session4.menu
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void spotifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.spotify m = new form.spotify();
            m.Show();
        }
    }
}
