using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace freioficina.database
{
    public class database
    {
        public void Inserir(model.livromodel livro)
        {
            string script = @"insert into tblivro (nmlivro, nmautor, dtlancamento, dtleitura,lido)
                                            values (@nmlivro, @nmautor, @dtlancamento, @dtleitura,@lido)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nmlivro", livro.nmlivro));
            parms.Add(new MySqlParameter("nmautor", livro.nmautor));
            parms.Add(new MySqlParameter("dtlancamento", livro.dtlancamento));
            parms.Add(new MySqlParameter("dtleitura", livro.dtleitura));
            parms.Add(new MySqlParameter("lido", livro.lido));

            db db = new db();
            db.ExecuteInsertScript(script, parms);
        }

        public model.livromodel FiltrarPorid(int idlivro)
        {


            MySqlConnection con = new MySqlConnection("server=localhost;database=freioficina;uid=root;pwd=");
            con.Open();

            MySqlCommand comand = con.CreateCommand();
            comand.CommandText = @" select * from tblivro where idlivro = @idlivro";

            comand.Parameters.Add(new MySqlParameter("idlivro", idlivro));

            MySqlDataReader reader = comand.ExecuteReader();

            model.livromodel livros = null;

            if (reader.Read())
            {
                livros = new model.livromodel();
                livros.idlivro = Convert.ToInt32(reader["idlivro"]);
                livros.nmlivro = Convert.ToString(reader["nmlivro"]);
                livros.nmautor = Convert.ToString(reader["nmautor"]);
                livros.dtlancamento = Convert.ToDateTime(reader["dtlancamento"]);
                livros.dtleitura = Convert.ToDateTime(reader["dtleitura"]);
                livros.lido = Convert.ToBoolean(reader["lido"]);
            }
            con.Close();

            return livros;


        }

        public List<model.livromodel> listartodos()
        {
            string script = "select * from tblivro";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            db db = new db();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<model.livromodel> lista = new List<model.livromodel>();

            while (reader.Read())
            {
                model.livromodel livro = new model.livromodel();
                livro.idlivro = Convert.ToInt32(reader["idlivro"]);
                livro.nmlivro = Convert.ToString(reader["nmlivro"]);
                livro.nmautor = Convert.ToString(reader["nmautor"]);
                livro.dtlancamento = Convert.ToDateTime(reader["dtlancamento"]);
                livro.dtleitura = Convert.ToDateTime(reader["dtleitura"]);
                livro.lido = Convert.ToBoolean(reader["lido"]);

                lista.Add(livro);
            }
            reader.Close();

            return lista;
        }
        public void delete(int idlivro)
        {
            string script = "delete  from tblivro where idlivro like idlivro ";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            comand.Parameters.Add(new MySqlParameter("idlivro", idlivro));
           

            db db = new db();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

        }
        public void alterar(model.livromodel livro)
        {
            string script = "update tblivro set idlivro=@idlivro,nmlivro=@nmlivro,nmautor=@nmautor,dtlancamento=@dtlancamento,dtleitura=@dtleitura,lido=@lido where idlivro like @idlivro";


            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("idlivro", livro.idlivro));
            parms.Add(new MySqlParameter("nmlivro", livro.nmlivro));
            parms.Add(new MySqlParameter("nmautor", livro.nmautor));
            parms.Add(new MySqlParameter("dtlancamento", livro.dtlancamento));
            parms.Add(new MySqlParameter("dtleitura", livro.dtleitura));
            parms.Add(new MySqlParameter("lido", livro.lido));
            db db = new db();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);
        }
    }
}
