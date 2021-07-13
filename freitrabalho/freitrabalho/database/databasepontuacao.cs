using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freitrabalho.database
{
    class databasepontuacao
    {
        database.entity.freitrabalhoEntities1 banco = new database.entity.freitrabalhoEntities1();

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
        public void alterar(entity.tbpontuacao usuario)
        {
            entity.tbpontuacao lista = banco.tbpontuacao.FirstOrDefault(t => t.nick == usuario.nick);
            if (lista != null)
            {
                lista.nick = usuario.nick;
              
            }
            banco.SaveChanges();

        }
    }
}
