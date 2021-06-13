using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.session2.menu
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void quizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            session2.form.quiz q = new form.quiz();
            q.Show();
        }

        private void orçamentoPcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.orcamento o = new form.orcamento();
            o.Show();
        }

        private void envioDeEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.enviaremail ee = new form.enviaremail();
            ee.Show();
        }

        private void consultaCepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.correio co = new form.correio();
            co.Show();
        }

        private void criptografiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.criptografia cr = new form.criptografia();
            cr.Show();
        }
    }
}
