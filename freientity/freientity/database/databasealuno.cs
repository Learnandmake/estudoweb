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

    }
}
