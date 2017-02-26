using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Multi_Starter
{
    class dbconnector
    {

        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string pass;

        public dbconnector()
        {
            
        }

        private void Initialize()
        {
            server = "localhost";
            database = "yes_newera";
        }

    }
}
