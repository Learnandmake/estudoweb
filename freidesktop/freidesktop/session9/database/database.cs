using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freidesktop.session9.database
{
    class database
    {
        public void Inserir(model.modelfilme filme)
        {
            string script = @"insert into tbfilme (nmfilme, vlavaliacao, btdisponivel, dtestreia)
                                            values (@nmfilme, @vlavaliacao, @btdisponivel, @dtestreia)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nmfilme", filme.nome));
            parms.Add(new MySqlParameter("vlavaliacao", filme.avaliacao));
            parms.Add(new MySqlParameter("btdisponivel", filme.disponivel));
            parms.Add(new MySqlParameter("dtestreia", filme.dtestreia));

            db db = new db();
            db.ExecuteInsertScript(script, parms);
        }

        public List<model.modelfilme> FiltrarPorNome(string nome)
        {
            string script = "select * from tbfilme where nmfilme like @nome";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nome", "%" + nome + "%"));

            db db = new db();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<model.modelfilme> lista = new List<model.modelfilme>();

            while (reader.Read())
            {
                model.modelfilme filme = new model.modelfilme();
                filme.idfilme = Convert.ToInt32(reader["idfilme"]);
                filme.nome = Convert.ToString(reader["nmfilme"]);
                filme.avaliacao = Convert.ToDecimal(reader["vlavaliacao"]);
                filme.dtestreia = Convert.ToDateTime(reader["dtestreia"]);
                filme.disponivel = Convert.ToBoolean(reader["btdisponivel"]);

                lista.Add(filme);
            }
            reader.Close();

            return lista;
        }

        public List<model.modelfilme> Filtrartodos()
        {
            string script = "select * from tbfilme";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            db db = new db();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<model.modelfilme> lista = new List<model.modelfilme>();

            while (reader.Read())
            {
                model.modelfilme filme = new model.modelfilme();
                filme.idfilme = Convert.ToInt32(reader["idfilme"]);
                filme.nome = Convert.ToString(reader["nmfilme"]);
                filme.avaliacao = Convert.ToDecimal(reader["vlavaliacao"]);
                filme.dtestreia = Convert.ToDateTime(reader["dtestreia"]);
                filme.disponivel = Convert.ToBoolean(reader["btdisponivel"]);

                lista.Add(filme);
            }
            reader.Close();

            return lista;
        }
    }
}
