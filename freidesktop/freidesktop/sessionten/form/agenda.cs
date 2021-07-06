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
    public partial class agenda : Form
    {
        public agenda()
        {
            InitializeComponent();
            busi.bussines a = new busi.bussines();
            List<mod.agendamodel> m = a.listartodos();
            dvg.DataSource = m;
        }

      
        

        private void picclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nmpessoa = Convert.ToString(txtnome.Text);
                string dscontato = Convert.ToString(mcscontato.Text);

                mod.agendamodel m = new mod.agendamodel();
                m.nmpessoa = nmpessoa;
                m.dscontato = dscontato;

                busi.bussines b = new busi.bussines();
                b.inserir(m);
                busi.bussines a = new busi.bussines();
                List<mod.agendamodel> m1 = a.listartodos();
                dvg.DataSource = m1;

                MessageBox.Show("formulario enviado com sucesso");
            }
            
           
            catch(Exception)
            {
                MessageBox.Show("erro verique o formulario");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {try
        {
                string nmpessoa = Convert.ToString(txtbnome.Text);
                busi.bussines b = new busi.bussines();
                List<mod.agendamodel> m1 = b.filtrarnome(nmpessoa);
                dvg.DataSource = m1;
            }
           catch(Exception)
            { MessageBox.Show("erro verique o formulario"); }
        }
    }
}
