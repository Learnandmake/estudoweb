using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freidesktop.session9.bussines
{
    class bussines
    {
        database.database data = new database.database();
        public void insert(model.modelfilme model)
        {
            data.Inserir(model);

        }
        public List<model.modelfilme> listartodos()
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
