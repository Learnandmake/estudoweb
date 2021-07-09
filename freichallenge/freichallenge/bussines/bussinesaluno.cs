using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freichallenge.bussines
{
    class bussinesaluno
    {
        data.databasealuno banco = new data.databasealuno();
        public List<data.entity.tbaluno> listaralunoporid (int id)
        {
            List<data.entity.tbaluno> list = banco.filtrarporturma(id);
            return list;
        }
    }
}
