using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    internal class DBconnection
    {
        private static string connectionString;
        static SqlConnection myConnection;
        static string SQLServerName = "DESKTOP-F6L52V8\\SQLEXPRESS";
        static string DataBaseName = "CinemaDB";
        public static void OpenConnection()
        {
            connectionString = "Data Source=" + SQLServerName + ";Initial Catalog=" + DataBaseName + ";Integrated Security=True";
            myConnection = new SqlConnection(connectionString);
            myConnection.Open();
        }

        public static void OpenConnection(string SqlServerName, string DataBaseName)
        {
            connectionString = "Data Source=" + SQLServerName + ";Initial Catalog=" + DataBaseName + ";Integrated Security=True";
            myConnection = new SqlConnection(connectionString);
            myConnection.Open();
        }

        public static void ExecuteQueryLogin(string email, string pass)
        {
            string query = "select * from Users_table where Email = @Email and Password = @Password";
            SqlCommand cmd = new SqlCommand(query, myConnection);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", pass);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
        }
    }
}
