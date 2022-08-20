using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freientity.database
{
    class databasealuno
    {
        entity.schooldbEntities0 entitie = new entity.schooldbEntities0();
        public void inserirthpk(entity.tbaluno aluno)
        {
            entitie.tbaluno.Add(aluno);
            entitie.SaveChanges();
        }
        public List<entity.tbaluno> ltodosalfa()
        {
            List<entity.tbaluno> lista = entitie.tbaluno.OrderBy(t => t.nmaluno).ToList();
            return lista;
        }
        public void delete(int idaluno)
        {
            entity.tbaluno lista = entitie.tbaluno.FirstOrDefault(t => t.idaluno == idaluno);
            entitie.Entry(lista).State = System.Data.EntityState.Deleted;
            entitie.SaveChanges();
        }
        public List<entity.tbaluno> falunospt (int a )
        {
            List<entity.tbaluno> lista = entitie.tbaluno.Where(t=>t.idturma == a).ToList();
            return lista;
        }
        
        public void alterar(entity.tbaluno idaluno)
        {
            entity.tbaluno lista =  entitie.tbaluno.OrderByDescending(t =>t.nmaluno).FirstOrDefault(t => t.idaluno == idaluno.idaluno);

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

        public void ordenaral(entity.tbaluno idaluno)
        {
            entity.tbaluno lista = entitie.tbaluno.FirstOrDefault(t => t.idaluno == idaluno.idaluno);
            
          
         if  (lista != null )
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


        
    }
}
