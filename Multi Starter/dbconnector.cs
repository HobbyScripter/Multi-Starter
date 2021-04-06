using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
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
            database = "********";
            uid = "root";
            pass = "********";
            string connstring;
            connstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD" + pass + ";";
            conn = new MySqlConnection(connstring);
        }

        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }catch(MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to Server. Please Contact Adminisitrator!");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again!");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public List<string>[] Select(string name, string password)
        {
            string query = "SELECT * FROM user";

            //Create a list to store the result
            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();
            list[1] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["name"] + "");
                    list[1].Add(dataReader["password"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
    }
}
