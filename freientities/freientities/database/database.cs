using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freientities.database
{
    class database
    {  
        entities.schooldbEntities1 entity = new entities.schooldbEntities1();
        public void inserir (entities.tbturma turma)
        {
            entity.tbturma.Add(turma);
        }
        public List<entities.tbturma> listartodasasturmas()
        {
            List<entities.tbturma> lista = entity.tbturma.ToList();
            return lista;
        }
        public List<entities.tbturma>filtrarcurso(string nmcurso)
        {
            List<entities.tbturma> lista = entity.tbturma.Where(t => t.nmcurso == nmcurso).ToList();
            return lista;
        }
    }
}
