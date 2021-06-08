using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.session1.tela
{
    public partial class totalday : Form
    {
        public totalday()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime nasci = dtnasci.Value;

            function.sessionone one = new function.sessionone();

            int totaldays = one.diasdevida(nasci);

            lblt1.Visible = true;
            lbldia.Text = totaldays.ToString();
            lbldia.Visible = true;
            lblt2.Visible = true; 
        }
    }
}
