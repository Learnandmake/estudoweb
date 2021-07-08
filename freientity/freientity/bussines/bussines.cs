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
        public List<database.entity.tbturma> fturma(string turma)
        {
            List<database.entity.tbturma> lista = data.fturma(turma);
            return lista;
        }
        public List<database.entity.tbturma> fcurso(string curso)
        {
            List<database.entity.tbturma> lista = data.fcurso(curso);
            return lista;
        }
        public List<database.entity.tbturma> fid(int id)
        {
            List<database.entity.tbturma> lista = data.fid(id);
            return lista;
        }
        public List<database.entity.tbturma> fqtdaluno(int qtdmaxaluno)
        {
            List<database.entity.tbturma> lista = data.fqtdaluno(qtdmaxaluno);
            return lista;
        }
        public void dturma (int id)
        {
            data.delete(id);
        }
    }
}
