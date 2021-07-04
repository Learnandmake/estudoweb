using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freidesktop.desafio.database
{
    class database
    {
        public void Inserir(desafio.model.modelfilme filme)
        {
            string script = @"insert into tb_filme (nm_filme, vl_avaliacao, bt_disponivel, dt_estreia)
                                            values (@nm_filme, @vl_avaliacao, @bt_disponivel, @dt_estreia)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_filme", filme.nome));
            parms.Add(new MySqlParameter("vl_avaliacao", filme.avaliacao));
            parms.Add(new MySqlParameter("bt_disponivel", filme.disponivel));
            parms.Add(new MySqlParameter("dt_estreia", filme.dtestreia));

            db db = new db();
            db.ExecuteInsertScript(script, parms);
        }

        public List<model.modelfilme> FiltrarPorNome(string nome)
        {
            string script = "select * from tb_filme where nm_filme like @nome";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nome", "%" + nome + "%"));

            db db = new db();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<model.modelfilme> lista = new List<model.modelfilme>();

            while (reader.Read())
            {
                model.modelfilme filme = new model.modelfilme();
                filme.idfilme = Convert.ToInt32(reader["id_filme"]);
                filme.nome = Convert.ToString(reader["nm_filme"]);
                filme.avaliacao = Convert.ToDecimal(reader["vl_avaliacao"]);
                filme.dtestreia = Convert.ToDateTime(reader["dt_estreia"]);
                filme.disponivel = Convert.ToBoolean(reader["bt_disponivel"]);

                lista.Add(filme);
            }
            reader.Close();

            return lista;
        }
    }
}
