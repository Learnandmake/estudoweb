using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freidesktop.desafio.database
{
    class connection
    {
        public MySql.Data.MySqlClient.MySqlConnection Create()
        {
            string connectionString = "server=localhost;database=infoX01_2019DB;uid=root;password=1234";

            MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();

            return connection;
        }
    }
}
