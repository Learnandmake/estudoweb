using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freichallenge.data
{
    class databaseturma
    {
        entity.schooldbEntities banco = new entity.schooldbEntities();
        public List<data.entity.tbturma> listar () 
        {
            List<data.entity.tbturma> lista = banco.tbturma.ToList();
            return lista;
        }
    }
}
