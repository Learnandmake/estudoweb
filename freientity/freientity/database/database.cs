using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freientity.database
{
    class database
    {
        entity.schooldbEntities entitie = new entity.schooldbEntities();

        public void inserir(entity.tbturma turma)
        {
            entitie.tbturmas.Add(turma);
            entitie.SaveChanges();
        }

        public List<entity.tbturma> ltodos()
        {
            List<entity.tbturma> lista = entitie.tbturmas.ToList();
            return lista;
        }
        public List<entity.tbturma> fturma(string turma)
        {
            List<entity.tbturma> lista = entitie.tbturmas.Where(t =>t.nmturma == turma).ToList();
            return lista;
        }
        public List<entity.tbturma> fcurso(string curso)
        {
            List<entity.tbturma> lista = entitie.tbturmas.Where(t => t.nmcurso == curso).ToList();
            return lista;
        }
        public List<entity.tbturma> fid(int id)
        {
            List<entity.tbturma> lista = entitie.tbturmas.Where(t => t.idturma == id).ToList();
            return lista;
        }
        public List<entity.tbturma> fqtdaluno(int qtdaluno)
        {
            List<entity.tbturma> lista = entitie.tbturmas.Where(t => t.qtmaxalunos == qtdaluno).ToList();
            return lista;
        }
    }
}
