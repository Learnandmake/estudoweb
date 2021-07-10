using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freitrabalho.bussines
{
    class bussinespontuacao
    {
        database.databasepontuacao data = new database.databasepontuacao();
        public void inserir(database.entity.tbpontuacao pontuacao)
        {
            data.inserir(pontuacao);
        }
    }
}
