using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freichallenge.bussines
{
    class bussinesturma
    {
        data.databaseturma banco = new data.databaseturma();
        public List<data.entity.tbturma> listar()
        {
            List<data.entity.tbturma> lista  = banco.listar();
            return lista;
        }

       
    }
}
