﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freitrabalho.database
{
    class databaseusuario
    {

        database.entity.freitrabalhoEntities banco = new database.entity.freitrabalhoEntities();

        public void inserir(database.entity.tbusuario usuario)
        {
            banco.tbusuario.Add(usuario);
            banco.SaveChanges();
        }
    }
}
