using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freitrabalho.telas.pergunta
{
    public partial class cadastrar : Form
    {
        public cadastrar()
        {
            InitializeComponent();
            bussines.bussinespergunta bpergunta = new bussines.bussinespergunta();
            List<database.entity.tbpergunta> lista = bpergunta.ltodos();
            dvgpergunta.DataSource = lista;
           
        }

        private void picclose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        private void picbarra_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picclose_MouseLeave(object sender, EventArgs e)
        {
            
                picclose.BackColor = Color.Teal;
        }

        private void picclose_MouseEnter(object sender, EventArgs e)
        {
            picclose.BackColor = Color.Maroon;
        }

        private void dvgpergunta_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cbobuf_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btncadastro_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btncadastrar_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void cadastrar_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btncadastro_Click(object sender, EventArgs e)
        {
            string enunciado = Convert.ToString(txtenunciado.Text);
            string ala = Convert.ToString(txtala.Text);
            string alb = Convert.ToString(txtalb.Text);
            string alc = Convert.ToString(txtalc.Text);
            string ald = Convert.ToString(txtald.Text);
            string resposta = Convert.ToString(cboresposta.SelectedItem);
            string uf = Convert.ToString(cbouf.SelectedItem);

            database.entity.tbpergunta pergunta = new database.entity.tbpergunta();
            bussines.bussinespergunta bpergunta = new bussines.bussinespergunta();

            pergunta.enunciado = enunciado;
            pergunta.palternativa = ala;
            pergunta.salternativa = alb;
            pergunta.talternativa = alc;
            pergunta.qalternativa = ald;
            pergunta.resposta = resposta;
            pergunta.uf = uf;

            bpergunta.inserir(pergunta);

            MessageBox.Show("Operação bem sucedida");
           
            List<database.entity.tbpergunta> lista = bpergunta.ltodos();
            dvgpergunta.DataSource = lista;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.entity.tbpergunta pergunta = new database.entity.tbpergunta();
            bussines.bussinespergunta bpergunta = new bussines.bussinespergunta();
            pergunta.idpergunta =Convert.ToInt32(lblid.Text);
            bpergunta.deletar(pergunta);

            MessageBox.Show("Operação bem sucedida");

            List<database.entity.tbpergunta> lista = bpergunta.ltodos();
            dvgpergunta.DataSource = lista;

        }

        private void dvgpergunta_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
       
            database.entity.tbpergunta pergunta = dvgpergunta.CurrentRow.DataBoundItem as database.entity.tbpergunta;
            lblid.Text = Convert.ToString(pergunta.idpergunta);
            txtenunciado.Text = Convert.ToString(pergunta.enunciado);
            txtala.Text = Convert.ToString(pergunta.palternativa);
            txtalb.Text = Convert.ToString(pergunta.salternativa);
            txtalc.Text = Convert.ToString(pergunta.talternativa);
            txtald.Text = Convert.ToString(pergunta.qalternativa);
            
            
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            string enunciado = Convert.ToString(txtenunciado.Text);
            string ala = Convert.ToString(txtala.Text);
            string alb = Convert.ToString(txtalb.Text);
            string alc = Convert.ToString(txtalc.Text);
            string ald = Convert.ToString(txtald.Text);
            string resposta = Convert.ToString(cboresposta.SelectedItem);
            string uf = Convert.ToString(cbouf.SelectedItem);

            database.entity.tbpergunta pergunta = new database.entity.tbpergunta();
            bussines.bussinespergunta bpergunta = new bussines.bussinespergunta();

            pergunta.idpergunta = Convert.ToInt32(lblid.Text);
            pergunta.enunciado = enunciado;
            pergunta.palternativa = ala;
            pergunta.salternativa = alb;
            pergunta.talternativa = alc;
            pergunta.qalternativa = ald;
            pergunta.resposta = resposta;
            pergunta.uf = uf;

            bpergunta.alterar(pergunta);

            MessageBox.Show("Operação bem sucedida");

            List<database.entity.tbpergunta> lista = bpergunta.ltodos();
            dvgpergunta.DataSource = lista;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            database.entity.tbpergunta pergunta = new database.entity.tbpergunta();
            bussines.bussinespergunta bpergunta = new bussines.bussinespergunta();
            string uf =Convert.ToString( cbobuf.SelectedItem);
            if(uf != null)
            {
                List<database.entity.tbpergunta> lista = bpergunta.fuf(uf);
                dvgpergunta.DataSource = lista;
            }  
         else
            {
                List<database.entity.tbpergunta> lista = bpergunta.ltodos();
                dvgpergunta.DataSource = lista;
            }
        }
    }
}
