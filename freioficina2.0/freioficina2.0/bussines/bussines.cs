using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace freioficina.bussines
{
    public class bussines
    {
        database.database data = new database.database();

        public List<model.livromodel> ltodos()
        {
            List<model.livromodel> lista = data.listartodos();
            return lista;
        }
        public model.livromodel flivro(int id)
        {
            model.livromodel lista = data.FiltrarPorid(id);
            return lista;
        }
        public void inserir(model.livromodel livro)
        {
            if (livro != null)
            {
                data.Inserir(livro);
            }
        }
        public void delete(int id)
        {
            data.delete(id);
        }
        public void alterar(model.livromodel livro)
        {
            data.alterar(livro);
        }
    }
}