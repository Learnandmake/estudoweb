using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freitrabalho2._0.database
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
            List<entity.tbpontuacao> lista = banco.tbpontuacao.OrderByDescending(t => t.pontuacao).Where(t =>t.pontuacao !=0).ToList();
            return lista;
        }
       
        public List<entity.tbpontuacao> flista(string nick)
        {
            List<entity.tbpontuacao> lista = banco.tbpontuacao.OrderBy(t=>t.pontuacao).Where(t => t.nick == nick).ToList();
            return lista;
        }
        public void addpontuacao(string nick)
        {
            entity.tbpontuacao lista = banco.tbpontuacao.FirstOrDefault(t=>t.nick == nick);
            if (lista != null)
            {
                lista.pontuacao += 1;
            }
            banco.SaveChanges();
        }
        public void reduzirpontuacao(string nick)
        {
            entity.tbpontuacao lista = banco.tbpontuacao.FirstOrDefault(t => t.nick == nick);
            if (lista != null)
            {
                lista.pontuacao -= 1;
            }
            banco.SaveChanges();
        }
        public entity.tbpontuacao buscarpontuacaopnick(string nick)
        {
            entity.tbpontuacao lista = banco.tbpontuacao.FirstOrDefault(t =>t.nick == nick) ;
            return lista;
        }
        public void deletar(entity.tbpontuacao pontuacao)
        {
            entity.tbpontuacao lista = banco.tbpontuacao.FirstOrDefault(t => t.idusuario == pontuacao.idusuario);
            banco.Entry(lista).State = System.Data.Entity.EntityState.Deleted; 
            banco.SaveChanges();
        }
        public void alterar(entity.tbpontuacao usuario)
        {
            entity.tbpontuacao lista = banco.tbpontuacao.FirstOrDefault(t => t.idusuario == usuario.idusuario);
            if (lista != null)
            {
                lista.idusuario = usuario.idusuario;
                lista.nick = usuario.nick;
              
            }
            banco.SaveChanges();

        }
    }
}
