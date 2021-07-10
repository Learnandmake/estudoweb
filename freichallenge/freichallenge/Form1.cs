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
            var idturma = cbo1.SelectedItem as data.entity.tbturma;
            data.databasealuno banco = new freichallenge.data.databasealuno();
            bussines.bussinesaluno baluno = new bussines.bussinesaluno();
            data.entity.tbaluno aluno = dvg1.CurrentRow.DataBoundItem as data.entity.tbaluno;
            data.entity.tbaluno aluno2 = new data.entity.tbaluno();
            var ultimoaluno = banco.ultimaturma(idturma.idturma);
            int total = ultimoaluno.idaluno ;
            int numero = 1; 
  
            var posicao1 = banco.idprimeiro(idturma.idturma);
             int posicao =posicao1.idaluno;
            int asas = 0;
            while (posicao <=total )
            {
                aluno2 =  banco.filtarporid(posicao);
                aluno2.nrchamada = numero;        
                banco.alterar(aluno2);
               
                posicao++;
              while(posicao >=2)
             {
                    numero++;
             }
            }
        }

        private void cbo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bussines.bussinesaluno baluno = new bussines.bussinesaluno();
            var idturma = cbo1.SelectedItem as data.entity.tbturma;
            dvg1.DataSource = baluno.listaralunoporid(idturma.idturma);
            
        }
    }
}
