using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freichallenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //c1
            bussines.bussinesturma bturma = new bussines.bussinesturma();
            List<data.entity.tbturma> lista = bturma.listar();
            cbo1.DataSource = lista;
            cbo1.DisplayMember = "nmturma";
            bussines.bussinesaluno baluno = new bussines.bussinesaluno();
            var idturma = cbo1.SelectedItem as data.entity.tbturma;
            dvg1.DataSource = baluno.listaralunoporid(idturma.idturma);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var turma = cbo1.SelectedItem as data.entity.tbturma;

        }

        private void cbo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bussines.bussinesaluno baluno = new bussines.bussinesaluno();
            var idturma = cbo1.SelectedItem as data.entity.tbturma;
            dvg1.DataSource = baluno.listaralunoporid(idturma.idturma);
        }
    }
}
