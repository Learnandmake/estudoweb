using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freidesktop.session9.database
{
    class connection
    {
        public MySqlConnection Create()
        {
            string connectionString = "server=localhost;database=info2019DB;uid=root;password=1234";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            return connection;
        }
    }
}
