using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.session2.form
{
    public partial class criptografia : Form
    {
        public criptografia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chave = Convert.ToString(txtcc.Text);
            string mensagem = Convert.ToString(txtcm.Text);
            if(chave.Length ==16)
            {
                function.sessiontwo criptografia = new function.sessiontwo();
            string c =criptografia.Criptografar(chave, mensagem);
                txtm.Text = c;
            }
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string chave = Convert.ToString(txtcc.Text);
            string mensagem = Convert.ToString(txtm.Text);

            function.sessiontwo criptografia = new function.sessiontwo();
            txtm.Text = criptografia.Descriptografar(chave, mensagem);
        }
    }
}
