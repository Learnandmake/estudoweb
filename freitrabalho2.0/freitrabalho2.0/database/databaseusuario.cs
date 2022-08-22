using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freitrabalho2._0.database
{
    class databaseusuario
    {

        database.entity.freitrabalhoEntities banco = new database.entity.freitrabalhoEntities();

        public void inserir(database.entity.tbusuario usuario)
        {
            banco.tbusuario.Add(usuario);
            banco.SaveChanges();
        }
        public List<entity.tbusuario> btodos()
        {
            List<entity.tbusuario> lista = banco.tbusuario.ToList();
            return lista;
        }
        public List<entity.tbusuario> flista(string nick)
        {
            List<entity.tbusuario> lista = banco.tbusuario.Where(t => t.nick == nick).ToList();
            return lista;
        }
       
        public entity.tbusuario buscaridpornick(string nick)
        {
           entity.tbusuario lista = banco.tbusuario.FirstOrDefault(t => t.nick == nick);
            return lista;
        }
        public void deletar (entity.tbusuario usuario)
        {
            entity.tbusuario lista = banco.tbusuario.FirstOrDefault(t => t.idusuario == usuario.idusuario);
            banco.Entry(lista).State = System.Data.Entity.EntityState.Deleted;
            banco.SaveChanges();
        }
        
        public void alterar(entity.tbusuario usuario)
        {
            entity.tbusuario lista = banco.tbusuario.FirstOrDefault(t => t.idusuario == usuario.idusuario);
            if (lista != null)
            {
                lista.idusuario = lista.idusuario;
                lista.nick = usuario.nick;
                lista.email = usuario.email;
                lista.cargo = usuario.cargo;
                lista.registro = usuario.registro;
            }
            banco.SaveChanges();

        }

        public entity.tbusuario buscarusuariopornick(string nick)
        {
            entity.tbusuario lista = banco.tbusuario.FirstOrDefault(t => t.nick == nick);
            return lista;

        }
    }
}
