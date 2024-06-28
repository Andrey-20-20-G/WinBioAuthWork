using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.AccessRoles;

namespace WindowsFormsApp3.Settings_files
{
    internal class DBcommands
    {
        DBcon dBcon = new DBcon();

        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        DataTable dt = new DataTable();


        public bool InsertUser(string login, string pass)
        {
            string query = $"insert into [Authorization].[dbo].[Sign_on_table](Login, Password, UserRole)" +
                $"values('{login}', '{pass}', 'Employee')";
            SqlCommand command = new SqlCommand(query, dBcon.getConnection());
            dBcon.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                UserModel.Login = login;
                UserModel.Password = pass;
                UserModel.UserRole = "Employee";

                Debug.WriteLine("App Registration Status: OK");
                return true;
            }
            else
            {
                Debug.WriteLine("App Registration Status: Error");
                return false;
            }
        }

        public bool CheckUser(string login, string pass) 
        {
            string query = $"select Login, Password, UserRole " +
                $"from [Authorization].[dbo].[Sign_on_table] " +
                $"WHERE Login = '{login}' and Password = '{pass}'";
            SqlCommand command = new SqlCommand(query,dBcon.getConnection());
            sqlDataAdapter.SelectCommand = command;
            sqlDataAdapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                UserModel.Login = login;
                UserModel.Password = pass;
                UserModel.UserRole = "Employee";
                UserModel.Access.Read = true;

                Debug.WriteLine("App Passport Status: OK");
                return true;
            }
            else
            {
                Debug.WriteLine("Local Passport Status: Error.\nInvalid username or password");
                return false;
            }
        }
    }
}
