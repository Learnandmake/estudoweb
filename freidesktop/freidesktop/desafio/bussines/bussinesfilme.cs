using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freidesktop.desafio.bussines
{
    class bussinesfilme
    {
        database.database data = new database.database();
        public void insert (model.modelfilme modelo)
        {
            data.Inserir(modelo);

        }
    
    }
}
