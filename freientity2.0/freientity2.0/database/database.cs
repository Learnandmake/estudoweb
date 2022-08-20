using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freientity2._0.database
{
    class database
    {
        entity.schooldbEntities entitie = new entity.schooldbEntities();

        public void inserir(entity.tbturma turma)
        {
            entitie.tbturma.Add(turma);
            entitie.SaveChanges();
        }

        public List<entity.tbturma> ltodos()
        {
            List<entity.tbturma> lista = entitie.tbturma.ToList();
            return lista;
        }
        public List<entity.tbturma> fturma(string turma)
        {
            List<entity.tbturma> lista = entitie.tbturma.Where(t => t.nmturma == turma).ToList();
            return lista;
        }
        public List<entity.tbturma> fcurso(string curso)
        {
            List<entity.tbturma> lista = entitie.tbturma.Where(t => t.nmcurso == curso).ToList();
            return lista;
        }
        public List<entity.tbturma> fid(int id)
        {
            List<entity.tbturma> lista = entitie.tbturma.Where(t => t.idturma == id).ToList();
            return lista;
        }
        public List<entity.tbturma> fqtdaluno(int qtdaluno)
        {
            List<entity.tbturma> lista = entitie.tbturma.Where(t => t.qtmaxalunos == qtdaluno).ToList();
            return lista;
        }
        public void delete(int idturma)
        {
            entity.tbturma lista = entitie.tbturma.FirstOrDefault(t => t.idturma == idturma);
            entitie.Entry(lista).State = System.Data.Entity.EntityState.Deleted; 
            entitie.SaveChanges();
        }
        public void alterar(entity.tbturma turma)
        {
            entity.tbturma lista = entitie.tbturma.FirstOrDefault(t => t.idturma == turma.idturma);

            if (lista != null)
            {
                lista.idturma = lista.idturma;
                lista.nmcurso = turma.nmcurso;
                lista.nmturma = turma.nmturma;
                lista.qtmaxalunos = turma.qtmaxalunos;

                entitie.SaveChanges();
            }
        }

        public void alterarpornome(entity.tbturma turma)
        {
            entity.tbturma lista = entitie.tbturma.FirstOrDefault(t => t.nmturma == turma.nmturma);

            if (lista != null)
            {
                lista.idturma = lista.idturma;
                lista.nmcurso = turma.nmcurso;
                lista.nmturma = turma.nmturma;
                lista.qtmaxalunos = turma.qtmaxalunos;

                entitie.SaveChanges();
            }
        }

        public void deletenmturma(string nmturma)
        {
            entity.tbturma lista = entitie.tbturma.FirstOrDefault(t => t.nmturma == nmturma);
            entitie.Entry(lista).State = System.Data.Entity.EntityState.Deleted;
            entitie.SaveChanges();
        }
        public int vnmturma(string nmturma)
        {
            int b = entitie.tbturma.Count(t => t.nmturma == nmturma);
            return b;
        }
    }
}
