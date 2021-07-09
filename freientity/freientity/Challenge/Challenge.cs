using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freientity.Challenge
{
    public partial class Challenge : Form
    {
        public Challenge()
        {
            InitializeComponent();
            bussines.bussines b = new bussines.bussines();
            List<database.entity.tbturma> lista = b.ltodos();
            cboturma1.DataSource = lista;
            cboturma1.DisplayMember = "nmturma";
            var turma = cboturma1.SelectedItem as database.entity.tbturma;
            int a =Convert.ToInt32( turma.idturma);
            bussines.bussinesalunos a1 = new bussines.bussinesalunos();
            List<database.entity.tbaluno> lista1 = a1.lalunospt(a);
            dvg1.DataSource = lista1;

        }

        private void picfecha_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = (DateTime.Now.ToString("HH:mm:ss"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void cboturma1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var turma = cboturma1.SelectedItem as database.entity.tbturma;
            int a = Convert.ToInt32(turma.idturma);
            bussines.bussinesalunos a1 = new bussines.bussinesalunos();
            List<database.entity.tbaluno> lista1 = a1.lalunospt(a);
            dvg1.DataSource = lista1;
        }
    }
}
