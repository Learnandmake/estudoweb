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
        }

        public List<entity.tbturma> ltodos()
        {
            List<entity.tbturma> lista = entitie.tbturmas.ToList();
            return lista;
        }
        public List<entity.tbturma> fturma(string curso)
        {
            List<entity.tbturma> lista = entitie.tbturmas.Where(t =>t.nmcurso == curso).ToList();
            return lista;
        }
    }
}
