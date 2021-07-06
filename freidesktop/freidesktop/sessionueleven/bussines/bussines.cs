using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freidesktop.sessionueleven.bussines
{
    class bussines
    {
        database.database data = new database.database();
        public void inserir(model.modelpensamento model)
        {
            data.Inserir(model);
        }
        public List<model.modelpensamento> listartodos()
        {
            List<model.modelpensamento> lista = data.Filtrartodos();
            return lista;
        }
        public List<model.modelpensamento> filtrarsentimento (string nome)
        {
          List<model.modelpensamento> lista = data.FiltrarPorNome(nome);
            return lista;
            }






}



    }
