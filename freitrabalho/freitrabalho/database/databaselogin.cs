using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freitrabalho.database.entity
{
    class databaselogin
    {
        database.entity.freitrabalhoEntities banco = new database.entity.freitrabalhoEntities();

        public void inserir(database.entity.tblogin login)
        {
            banco.tblogin.Add(login);
            banco.SaveChanges();
        }
    }
}
