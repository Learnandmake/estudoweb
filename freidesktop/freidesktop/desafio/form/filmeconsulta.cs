using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.desafio.form
{
    public partial class filmeconsulta : Form
    {
        public filmeconsulta()
        {
            InitializeComponent();
            bussines.bussinesfilme b = new bussines.bussinesfilme();
            List<model.modelfilme> l = b.listartodos();
            dvgfilme.DataSource = l;
        }

        private void dvgfilme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = Convert.ToString(txtnome.Text);
            bussines.bussinesfilme b = new bussines.bussinesfilme();
            List<model.modelfilme> l = b.filtrarnome(nome);
            dvgfilme.DataSource = l;
        }

        private void picclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
