using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.sessionvtwelve.form
{
    public partial class filme : Form
    {
        public filme()
        {
            InitializeComponent();
            bussines.bussines b = new bussines.bussines();
            List<model.modelfilme> l = b.listartodos();
            dvg.DataSource = l;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string nome = Convert.ToString(txtnome.Text);
                decimal nota = numav.Value;
                DateTime data = dtpdatetime.Value;
                bool disponivel = cbdisponivel.Checked;

                model.modelfilme m = new model.modelfilme();
                m.avaliacao = nota;
                m.disponivel = disponivel;
                m.dtestreia = data;
                m.nome = nome;
                bussines.bussines b = new bussines.bussines();

                b.insert(m);

                MessageBox.Show("Operação bem sucedida");

            }
            catch (Exception)
            {
                MessageBox.Show("Erro, verifique o formulario");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nome = Convert.ToString(txtnome.Text);
            bussines.bussines b = new bussines.bussines();
            List<model.modelfilme> l = b.filtrarnome(nome);
            dvg.DataSource = l;
        }
    }
}
