using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace freidesktop.desafio.database
{
    class db
    {
        public void ExecuteInsertScript(string script, List<MySql.Data.MySqlClient.MySqlParameter> parameters)
        {
             connection conn = new connection();
            MySql.Data.MySqlClient.MySqlConnection connection = conn.Create();

            MySql.Data.MySqlClient.MySqlCommand command = connection.CreateCommand();
            command.CommandText = script;

            if (parameters != null)
            {
                foreach (MySql.Data.MySqlClient.MySqlParameter param in parameters)
                {
                    command.Parameters.Add(param);
                }
            }

            command.ExecuteNonQuery();
            connection.Close();
        }

        public int ExecuteInsertScriptWithPk(string script, List<MySql.Data.MySqlClient.MySqlParameter> parameters)
        {
            connection conn = new connection();
            MySql.Data.MySqlClient.MySqlConnection connection = conn.Create();

            MySql.Data.MySqlClient.MySqlCommand command = connection.CreateCommand();
            command.CommandText = script;

            if (parameters != null)
            {
                foreach (MySql.Data.MySqlClient.MySqlParameter param in parameters)
                {
                    command.Parameters.Add(param);
                }
            }

            command.ExecuteNonQuery();
            connection.Close();

            int id = Convert.ToInt32(command.LastInsertedId);
            return id;
        }

        public MySql.Data.MySqlClient.MySqlDataReader ExecuteSelectScript(string script, List<MySql.Data.MySqlClient.MySqlParameter> parameters)
        {
            connection conn = new connection();
            MySql.Data.MySqlClient.MySqlConnection connection = conn.Create();

            MySql.Data.MySqlClient.MySqlCommand command = connection.CreateCommand();
            command.CommandText = script;

            if (parameters != null)
            {
                foreach (MySql.Data.MySqlClient.MySqlParameter param in parameters)
                {
                    command.Parameters.Add(param);
                }
            }

            MySql.Data.MySqlClient.MySqlDataReader reader =
                 command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            return reader;
        }

        
    }
}
