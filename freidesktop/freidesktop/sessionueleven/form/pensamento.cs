using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.sessionueleven.form
{
    public partial class pensamento : Form
    {
        public pensamento()
        {
            InitializeComponent();
            bussines.bussines b = new bussines.bussines();
            dvg.DataSource = b.listartodos();
        }

        private void picclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sentimento = Convert.ToString(txtbnome.Text);
            bussines.bussines b = new bussines.bussines();
            dvg.DataSource = b.filtrarsentimento(sentimento);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        try
        {
                string sentimento = Convert.ToString(txtsentimento.Text);
                string polaridade = Convert.ToString(txtpolaridade.Text);
                string dsgruposocial = Convert.ToString(txtgruposocial.Text);
                DateTime registro = DateTime.Now;

                bussines.bussines b = new bussines.bussines();

                model.modelpensamento m = new model.modelpensamento();
                m.dsgruposocial = dsgruposocial;
                m.dspolaridade = polaridade;
                m.dtinclusao = registro;
                m.dssentimento = sentimento;
                b.inserir(m);
                MessageBox.Show("Fomulario enviado");

                dvg.DataSource = b.listartodos();

            }

            catch(Exception)
            { MessageBox.Show("Erro por favor verifique o formulario"); }
        }

       
    }
}
