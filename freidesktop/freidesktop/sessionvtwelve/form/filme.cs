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
                DateTime data = dtesteia.Value;
                bool disponivel = cbdisponivel.Checked;

                model.modelfilme m = new model.modelfilme();
                m.avaliacao = nota;
                m.disponivel = disponivel;
                m.dtestreia = data;
                m.nome = nome;
                bussines.bussines b = new bussines.bussines();

                b.insert(m);

                MessageBox.Show("Operação bem sucedida");
             
                List<model.modelfilme> l = b.listartodos();
                dvg.DataSource = l;

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

        private void picclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                model.modelfilme usuario = dvg.CurrentRow.DataBoundItem as model.modelfilme;
                string nome = usuario.nome;
                bussines.bussines b = new bussines.bussines();
                b.delete(nome);
                MessageBox.Show("Operação bem sucedida");

                List<model.modelfilme> l = b.listartodos();
                dvg.DataSource = l;
            }
            catch(Exception)
            { MessageBox.Show("Erro, verifique o formulario"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
         
            
        }

        private void dvg_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            model.modelfilme usuario = dvg.CurrentRow.DataBoundItem as model.modelfilme;
            txtnome.Text = usuario.nome;
            numav.Value = Convert.ToDecimal(usuario.disponivel);
            dtesteia.Value = Convert.ToDateTime(usuario.dtestreia);
            cbdisponivel.Checked = Convert.ToBoolean(usuario.disponivel);
        }
    }
}
