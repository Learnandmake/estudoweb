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
    public partial class dbfilme : Form
    {
        public dbfilme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                string nome = txtnome.Text;
                decimal nota = numav.Value;
                DateTime data = dtpdatetime.Value;
                bool disponivel = cbdisponivel.Checked;

                model.modelfilme m = new model.modelfilme();
                m.avaliacao = nota;
                m.disponivel = disponivel;
                m.dtestreia = data;
              
                bussines.bussinesfilme b = new bussines.bussinesfilme();

                b.insert(m);

                MessageBox.Show("Deu certo");
            
          
        }
    }
}
