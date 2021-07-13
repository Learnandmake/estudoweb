using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freitrabalho.database
{
    class databasepergunta
    {
        database.entity.freitrabalhoEntities1 banco = new database.entity.freitrabalhoEntities1();

        public void inserir(database.entity.tbpergunta pergunta)
        {
            banco.tbpergunta.Add(pergunta);
            banco.SaveChanges();
        }
        public List<entity.tbpergunta> btodos()
        {
            List<entity.tbpergunta> lista = banco.tbpergunta.ToList();
            return lista;
        }
        public void deletar(entity.tbpergunta pergunta)
        {
            entity.tbpergunta lista = banco.tbpergunta.FirstOrDefault(t => t.idpergunta== pergunta.idpergunta);
            banco.Entry(lista).State = System.Data.EntityState.Deleted;
            banco.SaveChanges();
        }
    }
}
