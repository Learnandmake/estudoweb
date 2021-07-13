using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freitrabalho.database
{
    class databaselogin
    {
        database.entity.freitrabalhoEntities1 banco = new database.entity.freitrabalhoEntities1();

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
        public void alterar(entity.tblogin usuario)
        {
            entity.tblogin lista = banco.tblogin.FirstOrDefault(t => t.idusuario == usuario.idusuario);
            if (lista != null)
            {
                lista.nick = usuario.nick;
                lista.senha = usuario.senha;
            }
            banco.SaveChanges();
        }
        public void deletar(entity.tblogin login)
        {
            entity.tblogin lista = banco.tblogin.FirstOrDefault(t => t.idusuario == login.idusuario);
            banco.Entry(lista).State = System.Data.EntityState.Deleted;
            banco.SaveChanges();
        }
    }
}
