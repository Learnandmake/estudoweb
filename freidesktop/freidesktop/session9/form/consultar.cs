using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freidesktop.session9.form
{
    public partial class consultar : Form
    {
        public consultar()
        {
            InitializeComponent();
            InitializeComponent();
            bussines.bussines b = new bussines.bussines();
            List<model.modelfilme> l = b.listartodos();
            dvgfilme.DataSource = l;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = Convert.ToString(txtnome.Text);
            bussines.bussines b = new bussines.bussines();
            List<model.modelfilme> l = b.filtrarnome(nome);
            dvgfilme.DataSource = l;
        }
    }
}
