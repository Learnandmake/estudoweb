using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freitrabalho.bussines
{
    class bussinesusuario
    { 
        database.databaseusuario data = new database.databaseusuario();
        public void inserir(database.entity.tbusuario usuario)
        {
            data.inserir(usuario);
        }
    }
}
