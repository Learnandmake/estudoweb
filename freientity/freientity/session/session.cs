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
            dvgturma2.DataSource = lista;
            dvgcurso2.DataSource = lista;
            dvgidturma2.DataSource = lista;
            dvgqtdaluno2.DataSource = lista;

            nudqtdaluno2.Minimum = 25;
            txtnmturma2.MaxLength = 50;
            txtnmcurso2.MaxLength = 50;
         
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

        private void button2_Click(object sender, EventArgs e)
        {
            string curso = Convert.ToString(txtnmturma.Text);
            bussines.bussines b = new bussines.bussines();
            List<database.entity.tbturma> lista = b.fcurso(curso);
            dvg.DataSource = lista;
        }

        private void button7_Click(object sender, EventArgs e)
        {   
            string nmturma = Convert.ToString(txtnmturma2.Text);
            string curso = Convert.ToString(txtnmcurso2.Text);
            int qtdaluno = Convert.ToInt32(nudqtdaluno2.Value);
            nmturma.Trim();
            curso.Trim();
            if (nmturma !=  string.Empty && curso != string.Empty && qtdaluno !=null )
            {
              
                bussines.bussines a = new bussines.bussines();
                database.entity.tbturma model = new database.entity.tbturma();

                model.nmcurso = curso;
                model.nmturma = nmturma;
                model.qtmaxalunos = qtdaluno;

                a.inserir(model);

                MessageBox.Show("Operação bem sucedida");
            }
            else
            { MessageBox.Show("erro verifique o formulario"); }
            bussines.bussines b = new bussines.bussines();

            List<database.entity.tbturma> lista = b.ltodos();
            dvgturma2.DataSource = lista;
            dvgcurso2.DataSource = lista;
            dvgidturma2.DataSource = lista;
            dvgqtdaluno2.DataSource = lista;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string curso = Convert.ToString(txtbcurso2.Text);
            bussines.bussines b = new bussines.bussines();
            List<database.entity.tbturma> lista = b.fcurso(curso);
            dvgcurso2.DataSource = lista;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string curso = Convert.ToString(txtbturma2.Text);
            bussines.bussines b = new bussines.bussines();
            List<database.entity.tbturma> lista = b.fturma(curso);
            dvgturma2.DataSource = lista;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text);
            bussines.bussines b = new bussines.bussines();
            List<database.entity.tbturma> lista = b.fid(id);
            dvgidturma2.DataSource = lista;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int qtd = Convert.ToInt32(txtqtdaluno2.Text);
            bussines.bussines b = new bussines.bussines();
            List<database.entity.tbturma> lista = b.fqtdaluno(qtd);
            dvgqtdaluno2.DataSource = lista;
        }
    }
}
