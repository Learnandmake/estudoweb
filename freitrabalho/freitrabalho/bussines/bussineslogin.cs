using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freitrabalho.bussines
{
    class bussineslogin
    {

        database.databaselogin data = new database.databaselogin();
        public void inserir(database.entity.tblogin login)
        {
            data.inserir(login);
        }
        public void alterar(database.entity.tblogin usuario)
        {
            data.alterar(usuario);
        }
        public void deletar(database.entity.tblogin login)
        {
            data.deletar(login);
        }
      public database.entity.tblogin fazerlogin (string nick , string senha)
      {
           database.entity.tblogin lista= data.fazerlogin(nick, senha);
            return lista;
      }
        public database.entity.tblogin buscarloginpornick(string nick)
        {
            database.entity.tblogin lista = data.buscarloginpornick(nick);
            return lista;
        }
      
    }
}
