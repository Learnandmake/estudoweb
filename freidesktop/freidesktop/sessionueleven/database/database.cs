using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freidesktop.sessionueleven.database
{
    class database
    {
        public void Inserir(model.modelpensamento pensamento)
        {
            string script = @"insert into tbpensamento (dspolaridade, dssentimento, dsgruposocial, dtinclusao)
                                            values (@dspolaridade, @dssentimento, @dsgruposocial, @dtinclusao)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("dspolaridade", pensamento.dspolaridade));
            parms.Add(new MySqlParameter("dssentimento", pensamento.dssentimento));
            parms.Add(new MySqlParameter("dsgruposocial", pensamento.dsgruposocial));
            parms.Add(new MySqlParameter("dtinclusao", pensamento.dtinclusao));


            db db = new db();
            db.ExecuteInsertScript(script, parms);
        }

        public List<model.modelpensamento> FiltrarPorNome(string nome)
        {
            string script = "select * from tbagenda where nmpessoa like @";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nmpessoa", "%" + nome + "%"));

            db db = new db();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<model.modelpensamento > lista = new List<model.modelpensamento>();

            while (reader.Read())
            {
                model.modelpensamento pensamento = new model.modelpensamento();
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
