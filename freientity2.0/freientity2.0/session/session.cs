using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freientity2._0.session
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
            dvgturma3.DataSource = lista;
            dvg4a1.DataSource = lista;
            dvg4a2.DataSource = lista;
            dvg4a3.DataSource = lista;
            dvg4a4.DataSource = lista;
            dvg4a5.DataSource = lista;


            //s2
            nudqtdaluno2.Minimum = 25;
            txtnmturma2.MaxLength = 50;
            txtnmcurso2.MaxLength = 50;

            //s3
            nudqtdaluno3.Minimum = 25;

            //s4
            txtqtdaluno4a1.Minimum = 25;
            nudqtdaluno4a2.Minimum = 25;
            nudqtdaluno4a5.Minimum = 25;

            cbonmturma4a2.DataSource = lista;
            cbonmturma4a2.DisplayMember = "nmturma";
            cbonmturma4a2.ValueMember = "nmturma";
            cbonmturma4a4.DataSource = lista;
            cbonmturma4a4.DisplayMember = "nmturma";
            cbonmturma4a4.ValueMember = "nmturma";
            //s5 
            bussines.bussinesalunos al = new bussines.bussinesalunos();
            dvg5.DataSource = al.listartda();
            dvg6.DataSource = al.listartda();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = (DateTime.Now.ToString("HH:mm:ss"));
        }

        private void picfecha_Click_1(object sender, EventArgs e)
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
            dvgturma2.DataSource = lista;
            dvgcurso2.DataSource = lista;
            dvgidturma2.DataSource = lista;
            dvgqtdaluno2.DataSource = lista;
            dvgturma3.DataSource = lista;
            dvg4a1.DataSource = lista;
            dvg4a2.DataSource = lista;
            dvg4a3.DataSource = lista;
            dvg4a4.DataSource = lista;
            dvg4a5.DataSource = lista;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string curso = Convert.ToString(txtnmturma.Text);
            bussines.bussines b = new bussines.bussines();
            List<database.entity.tbturma> lista = b.fcurso(curso);
            dvg.DataSource = lista;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            string nmturma = Convert.ToString(txtnmturma2.Text);
            string curso = Convert.ToString(txtnmcurso2.Text);
            int qtdaluno = Convert.ToInt32(nudqtdaluno2.Value);
            nmturma.Trim();
            curso.Trim();
            if (nmturma != string.Empty && curso != string.Empty && qtdaluno != null)
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

        private void button3_Click_1(object sender, EventArgs e)
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

        private void button9_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtidturma3.Text);

            bussines.bussines b = new bussines.bussines();
            b.dturma(id);

            MessageBox.Show("Operação bem sucedida");

            List<database.entity.tbturma> lista = b.ltodos();
            dvgturma3.DataSource = lista;
        }

        private void dvgturma3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            database.entity.tbturma turmaselecionada = dvgturma3.CurrentRow.DataBoundItem as database.entity.tbturma;
            txtnmcurso3.Text = turmaselecionada.nmcurso;
            txtnmturma3.Text = turmaselecionada.nmturma;
            txtidturma3.Text = Convert.ToString(turmaselecionada.idturma);
            
            nudqtdaluno3.Value = Convert.ToDecimal(turmaselecionada.qtmaxalunos);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string curso = Convert.ToString(txtnmcurso3.Text);
            string turma = Convert.ToString(txtnmturma3.Text);
            int idturma = Convert.ToInt32(txtidturma3.Text);
            int qtdaluno = Convert.ToInt32(nudqtdaluno3.Value);
            bussines.bussines b = new bussines.bussines();
            if (turma != string.Empty && curso != string.Empty && qtdaluno != null)
            {


                database.entity.tbturma model = new database.entity.tbturma();
                model.idturma = idturma;
                model.nmcurso = curso;
                model.nmturma = turma;
                model.qtmaxalunos = qtdaluno;

                b.aturma(model);
                MessageBox.Show("Operação bem sucedida");

            }

            else
            { MessageBox.Show("erro verifique o formulario"); }

            List<database.entity.tbturma> lista = b.ltodos();
            dvgturma3.DataSource = lista;
        }

        private void dvg4a1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            database.entity.tbturma turmaselecionada = dvg4a1.CurrentRow.DataBoundItem as database.entity.tbturma;
            txtcurso4a1.Text = turmaselecionada.nmcurso;
            txtnmturma4a1.Text = turmaselecionada.nmturma;
            txtidturma4a1.Text = Convert.ToString(turmaselecionada.idturma);
            txtqtdaluno4a1.Value = Convert.ToDecimal(turmaselecionada.qtmaxalunos);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                string curso = Convert.ToString(txtcurso4a1.Text);
                string turma = Convert.ToString(txtnmturma4a1.Text);
                int idturma = Convert.ToInt32(txtidturma4a1.Text);
                int qtdaluno = Convert.ToInt32(txtqtdaluno4a1.Value);
                bussines.bussines b = new bussines.bussines();
                if (turma != string.Empty && curso != string.Empty && qtdaluno != null)
                {
                    database.entity.tbturma model = new database.entity.tbturma();
                    model.idturma = idturma;
                    model.nmcurso = curso;
                    model.nmturma = turma;
                    model.qtmaxalunos = qtdaluno;

                    b.aturmapornome(model);
                    MessageBox.Show("Operação bem sucedida");
                }

                else
                { MessageBox.Show("erro verifique o formulario"); }

                List<database.entity.tbturma> lista = b.ltodos();
                dvg4a5.DataSource = lista;
                dvg4a4.DataSource = lista;
                dvg4a3.DataSource = lista;
                dvg4a2.DataSource = lista;
                dvg4a1.DataSource = lista;
                cbonmturma4a2.DataSource = lista;
                cbonmturma4a2.DisplayMember = "nmturma";
                cbonmturma4a2.ValueMember = "nmturma";
                cbonmturma4a4.DataSource = lista;
                cbonmturma4a4.DisplayMember = "nmturma";
                cbonmturma4a4.ValueMember = "nmturma";
            }
            catch (Exception)
            { MessageBox.Show("erro verifique o formulario"); }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                var turma1 = cbonmturma4a2.SelectedItem as database.entity.tbturma;
                string curso = Convert.ToString(txtcurso4a2.Text);
                string turma = turma1.nmturma;
                int idturma = Convert.ToInt32(txtidturma4a2.Text);
                int qtdaluno = Convert.ToInt32(nudqtdaluno4a2.Value);
                bussines.bussines b = new bussines.bussines();
                if (turma != string.Empty && curso != string.Empty && qtdaluno != null)
                {


                    database.entity.tbturma model = new database.entity.tbturma();
                    model.idturma = idturma;
                    model.nmcurso = curso;
                    model.nmturma = turma;
                    model.qtmaxalunos = qtdaluno;

                    b.aturmapornome(model);
                    MessageBox.Show("Operação bem sucedida");
                }

                else
                { MessageBox.Show("erro verifique o formulario"); }

                List<database.entity.tbturma> lista = b.ltodos();
                dvg4a5.DataSource = lista;
                dvg4a4.DataSource = lista;
                dvg4a3.DataSource = lista;
                dvg4a2.DataSource = lista;
                dvg4a1.DataSource = lista;
                cbonmturma4a2.DataSource = lista;
                cbonmturma4a2.DisplayMember = "nmturma";
                cbonmturma4a2.ValueMember = "nmturma";
                cbonmturma4a4.DataSource = lista;
                cbonmturma4a4.DisplayMember = "nmturma";
                cbonmturma4a4.ValueMember = "nmturma";
            }
            catch (Exception)
            { MessageBox.Show("erro verifique o formulario"); }
        }
        private void cbonmturma4a2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var turma = cbonmturma4a2.SelectedItem as database.entity.tbturma;

            txtcurso4a2.Text = turma.nmcurso;

            txtidturma4a2.Text = Convert.ToString(turma.idturma);
            nudqtdaluno4a2.Value = Convert.ToDecimal(turma.qtmaxalunos);



        }
      
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = Convert.ToString(txtnmturma4a3.Text);

                bussines.bussines b = new bussines.bussines();
                b.dturmanmturma(nome);

                MessageBox.Show("Operação bem sucedida");

                List<database.entity.tbturma> lista = b.ltodos();
                dvg4a5.DataSource = lista;
                dvg4a4.DataSource = lista;
                dvg4a3.DataSource = lista;
                dvg4a2.DataSource = lista;
                dvg4a1.DataSource = lista;
                cbonmturma4a2.DataSource = lista;
                cbonmturma4a2.DisplayMember = "nmturma";
                cbonmturma4a2.ValueMember = "nmturma";
                cbonmturma4a4.DataSource = lista;
                cbonmturma4a4.DisplayMember = "nmturma";
                cbonmturma4a4.ValueMember = "nmturma";
            }
            catch (Exception)
            { MessageBox.Show("erro verifique o formulario"); }
        }

        private void dvg4a3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            database.entity.tbturma turmaselecionada = dvg4a3.CurrentRow.DataBoundItem as database.entity.tbturma;
            txtcurso4a3.Text = turmaselecionada.nmcurso;
            txtnmturma4a3.Text = turmaselecionada.nmturma;
            txtidturma4a3.Text = Convert.ToString(turmaselecionada.idturma);
            nudqtdaluno4a3.Value = Convert.ToDecimal(turmaselecionada.qtmaxalunos);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                var turma = cbonmturma4a4.SelectedItem as database.entity.tbturma;
                string nome = turma.nmturma;

                bussines.bussines b = new bussines.bussines();
                b.dturmanmturma(nome);

                MessageBox.Show("Operação bem sucedida");

                List<database.entity.tbturma> lista = b.ltodos();
                dvg4a5.DataSource = lista;
                dvg4a4.DataSource = lista;
                dvg4a3.DataSource = lista;
                dvg4a2.DataSource = lista;
                dvg4a1.DataSource = lista;
                cbonmturma4a2.DataSource = lista;
                cbonmturma4a2.DisplayMember = "nmturma";
                cbonmturma4a2.ValueMember = "nmturma";
                cbonmturma4a4.DataSource = lista;
                cbonmturma4a4.DisplayMember = "nmturma";
                cbonmturma4a4.ValueMember = "nmturma";
            }
            catch (Exception)
            { MessageBox.Show("erro verifique o formulario"); }
        }

        private void cbonmturma4a4_SelectedIndexChanged(object sender, EventArgs e)
        {
            var turma = cbonmturma4a4.SelectedItem as database.entity.tbturma;

            txtcurso4a4.Text = turma.nmcurso;
            txtidturma4a4.Text = Convert.ToString(turma.idturma);
            nudqtdaluno4a4.Value = Convert.ToDecimal(turma.qtmaxalunos);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                string nmturma = Convert.ToString(txtnmturma4a5.Text);
                string curso = Convert.ToString(txtcurso4a5.Text);
                int qtdaluno = Convert.ToInt32(nudqtdaluno4a5.Value);
                nmturma.Trim();
                curso.Trim();

                bussines.bussines a = new bussines.bussines();

                int b = a.vnmturma(nmturma);
                if (nmturma != string.Empty && curso != string.Empty && qtdaluno != null && b == 0)
                {


                    database.entity.tbturma model = new database.entity.tbturma();

                    model.nmcurso = curso;
                    model.nmturma = nmturma;
                    model.qtmaxalunos = qtdaluno;

                    a.inserir(model);

                    MessageBox.Show("Operação bem sucedida");
                }

                else
                { MessageBox.Show("ja tem uma turma com esse nome"); }
                bussines.bussines b1 = new bussines.bussines();

                List<database.entity.tbturma> lista = b1.ltodos();
                dvg4a5.DataSource = lista;
                dvg4a4.DataSource = lista;
                dvg4a3.DataSource = lista;
                dvg4a2.DataSource = lista;
                dvg4a1.DataSource = lista;
                cbonmturma4a2.DataSource = lista;
                cbonmturma4a2.DisplayMember = "nmturma";
                cbonmturma4a2.ValueMember = "nmturma";
                cbonmturma4a4.DataSource = lista;
                cbonmturma4a4.DisplayMember = "nmturma";
                cbonmturma4a4.ValueMember = "nmturma";
            }
            catch (Exception)
            { MessageBox.Show("erro verifique o formulario"); }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                int idturma = Convert.ToInt32(txtidturma5.Text);
                int nrchamada = Convert.ToInt32(txtnrchamada5.Value);
                string nome = Convert.ToString(txtnome5.Text);
                string bairro = Convert.ToString(txtbairro5.Text);
                string municipio = Convert.ToString(txtmunicipio5.Text);
                DateTime data = Convert.ToDateTime(dtnascimento5.Value);

                bussines.bussinesalunos b = new bussines.bussinesalunos();

                database.entity.tbaluno aluno = new database.entity.tbaluno();
                aluno.idturma = idturma;
                aluno.nmaluno = nome;
                aluno.nrchamada = nrchamada;
                aluno.dsbairro = bairro;
                aluno.dsmunicipio = municipio;
                aluno.dtnascimento = data;

                b.inserir(aluno);

                MessageBox.Show("Operação bem sucedida");

                bussines.bussinesalunos al = new bussines.bussinesalunos();
                dvg5.DataSource = al.listartda();
                dvg6.DataSource = al.listartda();
            }
            catch (Exception)
            {
                MessageBox.Show("erro verifique o formulario");
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                database.entity.tbaluno aluno = new database.entity.tbaluno();
                aluno.dsbairro = Convert.ToString(txtbairro6.Text);
                aluno.idaluno = Convert.ToInt32(txtidaluno6.Text);
                aluno.dsmunicipio = Convert.ToString(txtmunicipio6.Text);
                aluno.nmaluno = Convert.ToString(txtnome6.Text);
                aluno.idturma = Convert.ToInt32(txtturma6.Text);
                aluno.nrchamada = Convert.ToInt32(nudnrchamada6.Value);
                aluno.dtnascimento = dtnascimento6.Value;

                bussines.bussinesalunos b = new bussines.bussinesalunos();
                b.alterar(aluno);

                MessageBox.Show("operação bem sucedida");

                dvg6.DataSource = b.listartda();
            }
            catch (Exception)
            { MessageBox.Show("erro verifique o formulario"); }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtidaluno6.Text);

                bussines.bussinesalunos a = new bussines.bussinesalunos();
                a.delete(id);

                MessageBox.Show("Operação bem sucedida");

                bussines.bussinesalunos al = new bussines.bussinesalunos();
                dvg6.DataSource = al.listartda();
            }
            catch (Exception)
            { MessageBox.Show("erro verifique o formulario"); }
        }

        private void dvg6_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            database.entity.tbaluno alunoselecionado = dvg6.CurrentRow.DataBoundItem as database.entity.tbaluno;
            txtbairro6.Text = alunoselecionado.dsbairro;
            txtidaluno6.Text = Convert.ToString(alunoselecionado.idaluno);
            txtmunicipio6.Text = alunoselecionado.dsmunicipio;
            txtnome6.Text = alunoselecionado.nmaluno;
            txtturma6.Text = Convert.ToString(alunoselecionado.idturma);
            dtnascimento6.Value = alunoselecionado.dtnascimento;
            nudnrchamada6.Value = Convert.ToDecimal(alunoselecionado.nrchamada);

        }
        
    }
   }
  
