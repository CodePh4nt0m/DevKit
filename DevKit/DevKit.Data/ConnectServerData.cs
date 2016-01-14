using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevKit.Model;

namespace DevKit.Data
{
    public class ConnectServerData
    {
        public List<string> GetServerDatabaseList(ServerModel server)
        {
            try
            {
                string query = "SELECT name FROM master.sys.databases";
                var dblist = new List<string>();
                using (SqlCommand cmd = new SqlCommand(query, ConnectionManager.Connection(server)))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            dblist.Add(dr["name"].ToString());
                        }
                        return dblist;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                ConnectionManager.Close();
            }
            return null;
        }
    }
}
