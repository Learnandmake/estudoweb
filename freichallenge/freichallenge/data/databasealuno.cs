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

        public List<data.entity.tbaluno> filtrarporturma (int idturma)
        {
            List<data.entity.tbaluno> lista = banco.tbaluno.Where(t => t.idturma == idturma).ToList();
            return lista;
        }
    }
}
