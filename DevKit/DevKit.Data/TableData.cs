using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevKit.Model;

namespace DevKit.Data
{
    public class TableData
    {
        public List<TableModel> GetTableList(ServerModel server)
        {
            try
            {
                string query = "select name,object_id from sys.tables ORDER BY name";
                var tablelist = new List<TableModel>();
                using (SqlCommand cmd = new SqlCommand(query, ConnectionManager.Connection(server)))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            tablelist.Add(new TableModel()
                            {
                                TableId = Convert.ToInt32(dr["object_id"].ToString()),
                                TableName = dr["name"].ToString()
                            });
                        }
                        return tablelist;
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

        public List<TableModel> SearchTable(ServerModel server,string tablename)
        {
            try
            {
                string query = "select name,object_id from sys.tables WHERE name LIKE '%" + tablename + "%' ORDER BY name";
                var tablelist = new List<TableModel>();
                using (SqlCommand cmd = new SqlCommand(query, ConnectionManager.Connection(server)))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            tablelist.Add(new TableModel()
                            {
                                TableId = Convert.ToInt32(dr["object_id"].ToString()),
                                TableName = dr["name"].ToString()
                            });
                        }
                        return tablelist;
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
