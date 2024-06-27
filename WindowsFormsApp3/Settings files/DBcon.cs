using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp3.Settings_files
{
    internal class DBcon
    {
        SqlConnection conn = new SqlConnection(
            "Data Source=LAPTOP-T22HF5E5;Initial Catalog=UsersDB;Integrated Security=True");

        public void openConnection()
        {
            if(conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public SqlConnection getConnection() 
        {
            return conn;
        }
    }
}
