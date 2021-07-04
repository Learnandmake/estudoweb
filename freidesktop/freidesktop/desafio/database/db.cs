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
        public void ExecuteInsertScript(string script, List<MySqlParameter> parameters)
        {
          session9.database.connection conn = new session9.database.connection();
            MySqlConnection connection = conn.Create();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = script;

            if (parameters != null)
            {
                foreach (MySqlParameter param in parameters)
                {
                    command.Parameters.Add(param);
                }
            }

            command.ExecuteNonQuery();
            connection.Close();
        }

        public int ExecuteInsertScriptWithPk(string script, List<MySqlParameter> parameters)
        {
            session9.database.connection conn = new session9.database.connection();
            MySqlConnection connection = conn.Create();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = script;

            if (parameters != null)
            {
                foreach (MySqlParameter param in parameters)
                {
                    command.Parameters.Add(param);
                }
            }

            command.ExecuteNonQuery();
            connection.Close();

            int id = Convert.ToInt32(command.LastInsertedId);
            return id;
        }

        public MySqlDataReader ExecuteSelectScript(string script, List<MySqlParameter> parameters)
        {
            session9.database.connection conn = new session9.database.connection();
            MySqlConnection connection = conn.Create();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = script;

            if (parameters != null)
            {
                foreach (MySqlParameter param in parameters)
                {
                    command.Parameters.Add(param);
                }
            }

            MySqlDataReader reader =
                 command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            return reader;
        }

    }
}
