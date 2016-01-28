using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevKit.Model;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace DevKit.Data
{
    public class TableHelper
    {
        public void GenerateTableSript(ServerModel server, ServerModel depserver, List<TableModel> tablelist)
        {
            //Server srv = new Server(new ServerConnection(ConnectionManager.Connection(server)));
            Server srv = new Server();

            srv.ConnectionContext.LoginSecure = false;
            srv.ConnectionContext.Login = server.Username;
            srv.ConnectionContext.Password = server.Password;
            srv.ConnectionContext.ServerInstance = server.ServerName;

            string dbName = server.Database;

            Database db = new Database();
            db = srv.Databases[dbName];

            StringBuilder sb = new StringBuilder();

            List<Table> newtables = new List<Table>();
            List<TableModel> modtables = new List<TableModel>();

            foreach (var tbl in tablelist)
            {
                if (!CheckTable(depserver, tbl.TableName))
                {
                    newtables.Add(db.Tables[tbl.TableName]);
                }
                else
                {
                    modtables.Add(tbl);
                }
            }

            foreach (Table tbl in newtables)
            {
                ScriptingOptions options = new ScriptingOptions();
                options.ClusteredIndexes = true;
                options.Default = true;
                options.DriAll = true;
                options.Indexes = true;
                options.IncludeHeaders = true;

                StringCollection coll = tbl.Script(options);
                foreach (string str in coll)
                {
                    sb.Append(str);
                    sb.Append(Environment.NewLine);
                }
            }

            System.IO.StreamWriter fs = System.IO.File.CreateText("c:\\temp\\output.txt");
            fs.Write(sb.ToString());
            fs.Close();
        }

        public bool CheckTable(ServerModel server, string tablename)
        {
            try
            {
                string query = @"IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES 
                       WHERE TABLE_NAME='" + tablename + "') SELECT 1 ELSE SELECT 0";
                var tablelist = new List<TableModel>();
                using (SqlCommand cmd = new SqlCommand(query, ConnectionManager.Connection(server)))
                {
                    int res = Convert.ToInt32(cmd.ExecuteScalar());
                    if (res == 1)
                        return true;
                    else
                        return false;
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
        }

        public void GenereateAlterScripts(ServerModel server, ServerModel depserver, List<TableModel> tablelist)
        {
            Server srv = new Server();

            srv.ConnectionContext.LoginSecure = false;
            srv.ConnectionContext.Login = server.Username;
            srv.ConnectionContext.Password = server.Password;
            srv.ConnectionContext.ServerInstance = server.ServerName;

            string dbName = server.Database;

            Database db = new Database();
            db = srv.Databases[dbName];

            StringBuilder sb = new StringBuilder();

            var modtables = new List<Table>();

            foreach (var tbl in tablelist)
            {
                modtables.Add(db.Tables[tbl.TableName]);
            }
            List<Column> collist = new List<Column>();

            foreach (Table tbl in modtables)
            {
                //ScriptingOptions options = new ScriptingOptions();
                //options.ClusteredIndexes = true;
                //options.Default = true;
                //options.DriAll = true;
                //options.Indexes = true;
                //options.IncludeHeaders = true;

                //StringCollection coll = tbl.Script(options);
                //foreach (string str in coll)
                //{
                //    sb.Append(str);
                //    sb.Append(Environment.NewLine);
                //}
                foreach (Column col in tbl.Columns)
                {
                    collist.Add(col);
                }

                tbl.Columns.Add(collist[0]);
                tbl.Alter();
            }

            System.IO.StreamWriter fs = System.IO.File.CreateText("c:\\temp\\output.txt");
            fs.Write(sb.ToString());
            fs.Close();
        }
    }
}
