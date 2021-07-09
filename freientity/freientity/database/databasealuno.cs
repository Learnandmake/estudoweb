using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freientity.database
{
    class databasealuno
    {
        entity.schooldbEntities entitie = new entity.schooldbEntities();
        public void inserirthpk(entity.tbaluno aluno)
        {
            entitie.tbalunos.Add(aluno);
            entitie.SaveChanges();
        }
        public List<entity.tbaluno> ltodosalfa()
        {
            List<entity.tbaluno> lista = entitie.tbalunos.OrderBy(t => t.nmaluno).ToList();
            return lista;
        }
        public void delete(int idaluno)
        {
            entity.tbaluno lista = entitie.tbalunos.FirstOrDefault(t => t.idaluno == idaluno);
            entitie.Entry(lista).State = System.Data.EntityState.Deleted;
            entitie.SaveChanges();
        }
        public List<entity.tbaluno> falunospt (int a )
        {
            List<entity.tbaluno> lista = entitie.tbalunos.Where(t=>t.idturma == a).ToList();
            return lista;
        }
        
        public void alterar(entity.tbaluno idaluno)
        {
            entity.tbaluno lista =  entitie.tbalunos.OrderByDescending(t =>t.nmaluno).FirstOrDefault(t => t.idaluno == idaluno.idaluno);

            if (lista != null)
            {
                lista.idturma = idaluno.idturma;
                lista.nmaluno = idaluno.nmaluno;
                lista.nrchamada = idaluno.nrchamada;
                lista.dtnascimento = idaluno.dtnascimento;
                lista.idaluno = lista.idaluno;
                lista.dsmunicipio = idaluno.dsmunicipio;
                lista.dsbairro = idaluno.dsbairro;
                

                entitie.SaveChanges();
            }
        }

     
        public int count  ()
        {
            int b = entitie.tbalunos.Count();
            return b;
        }
    }
}
