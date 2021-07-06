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
            string script = "select * from tbpensamento where dssentimento like @dssentimento";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("dssentimento", "%" + nome + "%"));

            db db = new db();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<model.modelpensamento > lista = new List<model.modelpensamento>();

            while (reader.Read())
            {
                model.modelpensamento pensamento = new model.modelpensamento();
                pensamento.dssentimento = Convert.ToString(reader["dssentimento"]);
                pensamento.dspolaridade = Convert.ToString(reader["dspolaridade"]);
                pensamento.dsgruposocial = Convert.ToString(reader["dsgruposocial"]);
                pensamento.dtinclusao = Convert.ToDateTime(reader["dtinclusao"]);
                lista.Add(pensamento);
            }
            reader.Close();

            return lista;
        }

        public List<model.modelpensamento> Filtrartodos()
        {
            string script = "select * from tbpensamento";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            db db = new db();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List < model.modelpensamento > lista = new List< model.modelpensamento > ();

            while (reader.Read())
            {
                model.modelpensamento pensamento = new model.modelpensamento();
                pensamento.dssentimento = Convert.ToString(reader["dssentimento"]);
                pensamento.dspolaridade = Convert.ToString(reader["dspolaridade"]);
                pensamento.dsgruposocial = Convert.ToString(reader["dsgruposocial"]);
                pensamento.dtinclusao = Convert.ToDateTime(reader["dtinclusao"]);
                lista.Add(pensamento);
            }
            reader.Close();

            return lista;
        }
    }
}
