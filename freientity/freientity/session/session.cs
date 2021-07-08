using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freientity
{
    public partial class session : Form
    {
        public session()
        {
            InitializeComponent();
            bussines.bussines b = new bussines.bussines();
            List<database.entity.tbturma> lista = b.ltodos();
            dvg.DataSource = lista; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = (DateTime.Now.ToString("HH:mm:ss"));
        }

        private void picfecha_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nmturma = Convert.ToString(txtnmturma.Text);
            string curso = Convert.ToString(txtcurso.Text);
            int qtdaluno = Convert.ToInt32(qtdmaxaluno.Text);

            bussines.bussines b = new bussines.bussines();
            database.entity.tbturma model = new database.entity.tbturma();
           

            model.nmcurso = curso;
            model.nmturma = nmturma;
            model.qtmaxalunos = qtdaluno;

            b.inserir(model);

            MessageBox.Show("Operação bem sucedida");

            List<database.entity.tbturma> lista = b.ltodos();
            dvg.DataSource = lista;
        }
    }
}
