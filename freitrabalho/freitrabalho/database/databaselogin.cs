using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freitrabalho.database
{
    class databaselogin
    {
        database.entity.freitrabalhoEntities banco = new database.entity.freitrabalhoEntities();

        public void inserir(database.entity.tblogin login)
        {
            banco.tblogin.Add(login);
            banco.SaveChanges();
        }
        public List<entity.tblogin> btodos()
        {
            List<entity.tblogin> lista = banco.tblogin.ToList();
            return lista;
        }
        public List<entity.tblogin> flista(string nick)
        {
            List<entity.tblogin> lista = banco.tblogin.Where(t => t.nick == nick).ToList();
            return lista;
        }
   
    }
}
