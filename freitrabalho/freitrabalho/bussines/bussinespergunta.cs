using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freitrabalho.bussines
{
    class bussinespergunta
    {
        database.databasepergunta data = new database.databasepergunta();
        public void inserir(database.entity.tbpergunta pergunta)
        {
            data.inserir(pergunta);
        }
        public void deletar(database.entity.tbpergunta pergunta)
        {
            data.deletar(pergunta);
        }
        public List<database.entity.tbpergunta> ltodos()
        {
            List<database.entity.tbpergunta> listar = data.btodos();
            return listar;
        }
        public List<database.entity.tbpergunta> fuf(string uf)
        {
            List<database.entity.tbpergunta> listar = data.fuf(uf);
            return listar;
        }
        public void alterar(database.entity.tbpergunta pergunta)
        {
            data.alterar(pergunta);
        }
        public database.entity.tbpergunta bporid(int id)
        {
            database.entity.tbpergunta pergunta = data.bporid(id);
            return pergunta;
        }
        public int maximopergunta()
        {
            int contar = data.contarpergunta();
            return contar;
        }
    }
}
