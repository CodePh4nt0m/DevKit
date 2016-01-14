using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevKit.Common;
using DevKit.Model;

namespace DevKit.Data
{
    public class ConnectionManager
    {
        public static string ConnString = "";
        private static SqlConnection conn = new SqlConnection();
        public static string GetConnectionString(ServerModel server)
        {
            if (server != null)
            {
                ConnString = "Server=" + server.ServerName + ";" +
                                "Database=" + server.Database + ";" +
                                "User Id=" + server.Username + ";" +
                                "Password=" + server.Password + ";";
                return ConnString;
            }
            return null;
        }

        public static SqlConnection Connection(ServerModel server)
        {
            conn.ConnectionString = GetConnectionString(server == null ? AppTimeConfiguration.MainServer : server);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            return conn;
        }

        public static void Close()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}
