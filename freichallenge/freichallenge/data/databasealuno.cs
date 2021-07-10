using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freichallenge.data
{
    class databasealuno
    {
        entity.schooldbEntities banco = new entity.schooldbEntities();

     
        public List<data.entity.tbaluno> filtrarporturma(int idturma)
        {
            List<data.entity.tbaluno> lista = banco. tbaluno.Where(t => t.idturma == idturma).ToList();
            return lista;
        }
        public List<data.entity.tbaluno> ltodos()
        {
            List<data.entity.tbaluno> lista = banco.tbaluno.OrderBy(t=>t.nmaluno).ToList();
            return lista;
        }
        public entity.tbaluno filtrarporid (int idaluno, int idturma)
         {
            entity.tbaluno aluno = banco.tbaluno.OrderBy(t=>t.nmaluno).FirstOrDefault(t => t.idaluno == idaluno &&  t.idturma == idturma);
        
               while (aluno == null)
           {
                idaluno++;
               aluno = banco.tbaluno.FirstOrDefault(t => t.idaluno == idaluno && t.idturma == idturma);
            }
            return aluno;
         }
  
        public void alterar(data.entity.tbaluno aluno)
        {
            // loop para busca
           int posicao = 1;
           int numero = 1;
           int total = banco.tbaluno.Count(t => t.idturma == aluno.idturma);
           entity.tbaluno listaraluno = banco.tbaluno.FirstOrDefault(t => t.idaluno == posicao && t.idturma == aluno.idturma);

            while (aluno == null)
            {
               posicao++;
                listaraluno = banco.tbaluno.FirstOrDefault(t => t.idaluno == posicao && t.idturma ==aluno.idturma);
            }
          //erro
            while (posicao <= total && aluno != null)
            {
                aluno.nrchamada = numero;
                entity.tbaluno alterar = banco.tbaluno.FirstOrDefault(t =>t.idaluno ==aluno.idaluno);
                if (alterar != null)
                {
                    alterar.nmaluno =listaraluno.nmaluno;
                    alterar.nrchamada = listaraluno.nrchamada;
                 
                  
                }
                banco.SaveChanges();
                posicao++;
                while (posicao>= 2)
             {
                    numero++;
             }
                
            }
         
          
        }
    }
}
