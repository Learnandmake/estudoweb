using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freidesktop.sessionten.busi
{
    class bussines
    {
        data.database data = new sessionten.data.database();
    public void inserir (mod.agendamodel model)
    {
            data.Inserir(model);
    }
    public List<mod.agendamodel> listartodos()
    {
            List<mod.agendamodel> lista = data.Filtrartodos();
            return lista;
    }
        public List<mod.agendamodel>filtrarnome(string nome)
        {
            List<mod.agendamodel> lista = data.FiltrarPorNome(nome);
            return lista;
        }
    }
}
