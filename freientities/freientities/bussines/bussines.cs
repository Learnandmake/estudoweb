using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freientities.bussines
{
    class bussines
    {
        database.database data = new database.database();
        public void inserir (database.entities.tbturma turma)
        {
            data.inserir(turma);
        }
        public List<database.entities.tbturma> listartdturma()
        {
            List<database.entities.tbturma> lista = data.listartodasasturmas();
            return lista; 
        }
        public List<database.entities.tbturma> filtrarcurso(string curso)
        {
            List<database.entities.tbturma> lista = data.filtrarcurso(curso);
            return lista;
        }
    }
}
