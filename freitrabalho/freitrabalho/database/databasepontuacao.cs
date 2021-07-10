using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freitrabalho.database
{
    class databasepontuacao
    {
        database.entity.freitrabalhoEntities banco = new database.entity.freitrabalhoEntities();

        public void inserir(database.entity.tbpontuacao pontuacao)
        {
            banco.tbpontuacao.Add(pontuacao);
            banco.SaveChanges();
        }
    }
}
