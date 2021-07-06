using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.sessionten.form
{
    public partial class cadastrar : Form
    {
        public cadastrar()
        {
            InitializeComponent();
        }

        private void picclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
