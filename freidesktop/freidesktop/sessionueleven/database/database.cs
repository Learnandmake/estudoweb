using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freidesktop.sessionueleven.database
{
    class database
    {
        public void Inserir(mod.agendamodel agenda)
        {
            string script = @"insert into tbagenda (nmpessoa, dscontato)
                                            values (@nmpessoa, @dscontato)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nmpessoa", agenda.nmpessoa));
            parms.Add(new MySqlParameter("dscontato", agenda.dscontato));


            db db = new db();
            db.ExecuteInsertScript(script, parms);
        }

        public List<mod.agendamodel> FiltrarPorNome(string nome)
        {
            string script = "select * from tbagenda where nmpessoa like @nmpessoa";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nmpessoa", "%" + nome + "%"));

            db db = new db();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<mod.agendamodel> lista = new List<mod.agendamodel>();

            while (reader.Read())
            {
                mod.agendamodel agenda = new mod.agendamodel();
                agenda.idagenda = Convert.ToInt32(reader["idagenda"]);
                agenda.nmpessoa = Convert.ToString(reader["nmpessoa"]);
                agenda.dscontato = Convert.ToString(reader["dscontato"]);


                lista.Add(agenda);
            }
            reader.Close();

            return lista;
        }

        public List<mod.agendamodel> Filtrartodos()
        {
            string script = "select * from tbagenda";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            db db = new db();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<mod.agendamodel> lista = new List<mod.agendamodel>();

            while (reader.Read())
            {
                mod.agendamodel agenda = new mod.agendamodel();
                agenda.idagenda = Convert.ToInt32(reader["idagenda"]);
                agenda.nmpessoa = Convert.ToString(reader["nmpessoa"]);
                agenda.dscontato = Convert.ToString(reader["dscontato"]);


                lista.Add(agenda);
            }
            reader.Close();

            return lista;
        }
    }
}
