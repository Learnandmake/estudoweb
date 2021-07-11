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

    }
}
