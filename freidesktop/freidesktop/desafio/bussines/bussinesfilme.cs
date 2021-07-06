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
        public List<model.modelfilme> listartodos ()
        {
            List<model.modelfilme> a = data.Filtrartodos();
            return a;
        }

        public List<model.modelfilme> filtrarnome(string nome)
        {
            List<model.modelfilme> a = data.FiltrarPorNome(nome);
            return a;
        }
    }
}
