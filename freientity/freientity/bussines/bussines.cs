using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freientity.bussines
{
    class bussines
    {
        database.database data = new database.database();
    
        public void inserir (database.entity.tbturma turma)
        {
            data.inserir(turma);
        }
        
        public List<database.entity.tbturma > ltodos()
        {
            List < database.entity.tbturma > lista = data.ltodos();
            return lista;
        }
        public List<database.entity.tbturma> ftodos(string curso)
        {
            List<database.entity.tbturma> lista = data.fturma(curso);
            return lista;
        }
    }
}
