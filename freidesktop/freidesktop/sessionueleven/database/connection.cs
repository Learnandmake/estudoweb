﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freidesktop.sessionueleven.database
{
    class connection
    {
        public MySql.Data.MySqlClient.MySqlConnection Create()
        {
            string connectionString = "server=localhost;database=pensamento;uid=root;password=";

            MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            connection.Open();

            return connection;
        }
    }
}
