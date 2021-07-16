using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace freioficina.database
{
    public class connection
    {
        public MySql.Data.MySqlClient.MySqlConnection Create()
        {
            string connectionString = "server=localhost;database=freioficina;uid=root;password=";

            MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();

            return connection;
        }

    }
}