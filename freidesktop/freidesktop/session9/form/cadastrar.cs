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
    public partial class cadastrar : Form
    {
        public cadastrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // try
            //{
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

           // }
          //  catch (Exception)
           // {
           //     MessageBox.Show("Erro, verifique o formulario");
            //}


        }

        private void picclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
