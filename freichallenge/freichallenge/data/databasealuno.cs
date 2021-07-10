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

        public entity.tbaluno ultimaturma(int idturma)
        {
            entity.tbaluno a = banco.tbaluno.Last(t => t.idturma == idturma);
            return a;
        }
        public List<data.entity.tbaluno> filtrarporturma(int idturma)
        {
            List<data.entity.tbaluno> lista = banco.tbaluno.Where(t => t.idturma == idturma).ToList();
            return lista;
        }
        public List<data.entity.tbaluno> ltodos()
        {
            List<data.entity.tbaluno> lista = banco.tbaluno.ToList();
            return lista;
        }
        public entity.tbaluno idprimeiro(int idturma)
        {
            entity.tbaluno a = banco.tbaluno.First(t => t.idturma == idturma);
            return a;
        }
         
        public entity.tbaluno filtarporid(int id )
        { 
            entity.tbaluno lista = banco.tbaluno.FirstOrDefault(t => t.idturma == id);
            return lista;
        }

        public void alterar(data.entity.tbaluno aluno)
        {    
            entity.tbaluno alterar = banco.tbaluno. FirstOrDefault(t => t.idturma == aluno.idturma);
           if (alterar !=null)
           {      
                alterar.nmaluno = aluno.nmaluno;
                alterar.nrchamada = aluno.nrchamada;
                alterar.dtnascimento = aluno.dtnascimento;
                alterar.dsbairro = aluno.dsbairro;
                alterar.dsmunicipio = aluno.dsmunicipio;
           }
            banco.SaveChanges();
          
        }
    }
}
