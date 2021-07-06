using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.session9.menu
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.cadastrar m = new form.cadastrar();
            m.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.consultar m = new form.consultar();
            m.Show();
        }
    }
}
