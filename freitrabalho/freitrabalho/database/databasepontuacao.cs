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
        public List<entity.tbpontuacao> btodos()
        {
            List<entity.tbpontuacao> lista = banco.tbpontuacao.ToList();
            return lista;
        }
        public List<entity.tbpontuacao> flista(string nick)
        {
            List<entity.tbpontuacao> lista = banco.tbpontuacao.Where(t => t.nick == nick).ToList();
            return lista;
        }
        
    }
}
