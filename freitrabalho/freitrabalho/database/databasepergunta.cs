using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freitrabalho.database
{
    class databasepergunta
    {
        database.entity.freitrabalhoEntities banco = new database.entity.freitrabalhoEntities();

        public void inserir(database.entity.tbpergunta pergunta)
        {
            banco.tbpergunta.Add(pergunta);
            banco.SaveChanges();
        }
    }
}
