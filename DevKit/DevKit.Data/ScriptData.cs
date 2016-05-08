using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevKit.Entity;
using DevKit.Model;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace DevKit.Data
{
    public class ScriptData
    {
        public string GenerateTableStructure(ServerModel server, StructureType gentype,List<TableModel> tables)
        {
            try
            {
                Server srv = new Server();

                srv.ConnectionContext.LoginSecure = false;
                srv.ConnectionContext.Login = server.Username;
                srv.ConnectionContext.Password = server.Password;
                srv.ConnectionContext.ServerInstance = server.ServerName;

                Scripter scripter = new Scripter(srv);

                Database genDb = srv.Databases[server.Database];

                ScriptingOptions scriptOptions = new ScriptingOptions();

                scriptOptions.DriPrimaryKey = true;
                scriptOptions.AnsiFile = true;
                scriptOptions.IncludeHeaders = false;
                scriptOptions.ScriptOwner = false;
                scriptOptions.AppendToFile = false;
                scriptOptions.AllowSystemObjects = false;
                scriptOptions.ScriptDrops = false;
                scriptOptions.WithDependencies = false;
                scriptOptions.SchemaQualify = false;
                scriptOptions.SchemaQualifyForeignKeysReferences = false;
                scriptOptions.ScriptBatchTerminator = false;

                scriptOptions.Indexes = true;
                scriptOptions.ClusteredIndexes = true;
                scriptOptions.NonClusteredIndexes = true;
                scriptOptions.NoCollation = true;

                scriptOptions.DriAll = true;
                scriptOptions.DriIncludeSystemNames = false;

                scriptOptions.ToFileOnly = true;
                scriptOptions.Permissions = true;


                StringBuilder sb = new StringBuilder();
                foreach (var t in tables)
                {
                    string tbScr = "";
                    var tbl = genDb.Tables[t.TableName, "dbo"];
                    StringCollection tableScripts = tbl.Script(scriptOptions);
                    foreach (string script in tableScripts)
                        tbScr += script + "\n";

                    var scpt = GetStructureHeaderQuery(gentype, t.TableName);
                    scpt = scpt.Replace("{query}", tbScr);
                    sb.AppendLine(scpt);
                    sb.AppendLine("\n");
                }

                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }

        public string GenerateTableData(ServerModel server, DataGenType gentype, List<TableModel> tables)
        {
            try
            {
                var output = new StringBuilder();
                if (gentype == DataGenType.Truncate)
                {
                    foreach (var t in tables)
                    {
                        var scpt = GetDataHeaderQuery(gentype, t.TableName);
                        output.AppendLine(scpt);
                    }
                }
                else
                {
                    Server srv = new Server();

                    srv.ConnectionContext.LoginSecure = false;
                    srv.ConnectionContext.Login = server.Username;
                    srv.ConnectionContext.Password = server.Password;
                    srv.ConnectionContext.ServerInstance = server.ServerName;
                    Database genDb = srv.Databases[server.Database];

                    ScriptingOptions scriptOptions = new ScriptingOptions();
                    scriptOptions.ScriptData = true;
                    scriptOptions.ScriptSchema = false;

                    Scripter scripter = new Scripter(srv) { Options = scriptOptions };

                    
                    
                    foreach (var t in tables)
                    {
                        var gen = new StringBuilder();
                        var tbl = genDb.Tables[t.TableName, "dbo"];
                        var script = scripter.EnumScript(new SqlSmoObject[] { tbl });
                        foreach (var line in script)
                            gen.AppendLine(line);

                        var scpt = GetDataHeaderQuery(gentype, t.TableName);
                        scpt = scpt.Replace("{query}", gen.ToString());
                        output.AppendLine(scpt);
                    }
                }
                
                return output.ToString();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string GetStructureHeaderQuery(StructureType gentype,string tablename)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                
                if (gentype == StructureType.IfNotExists)
                {
                    sb.Append("--- Table " + tablename);
                    sb.Append("\n");
                    sb.Append("IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo'AND TABLE_NAME = '"+ tablename + "')");
                    sb.Append("\nBEGIN\n{query}\nEND\n\nGO\n");
                }
                else if (gentype == StructureType.DropAndCreate)
                {
                    sb.Append("--- Table " + tablename);
                    sb.Append("\n");
                    sb.Append("IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo'AND TABLE_NAME = '" + tablename + "')");
                    sb.Append("\nBEGIN\n\tDROP TABLE " + tablename);
                    sb.Append("\nEND\nGO\n\n");
                    sb.Append("--- Table " + tablename);
                    sb.Append("\n");
                    sb.Append("\n{query}\n\nGO\n");
                }
                else if (gentype == StructureType.Create)
                {
                    sb.Append("\n{query}\n\nGO\n");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return sb.ToString();
        }

        public string GetDataHeaderQuery(DataGenType gentype, string tablename)
        {
            StringBuilder sb = new StringBuilder();
            try
            {

                if (gentype == DataGenType.Insert)
                {
                    sb.Append("--- Table " + tablename);
                    sb.Append("\n{query}\n\nGO\n");
                    //sb.Append("--- Table " + tablename);
                    //sb.Append("\n");
                    //sb.Append("IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLESWHERE TABLE_SCHEMA = 'dbo'AND TABLE_NAME = '" + tablename + "')");
                    //sb.Append("\nBEGIN\n{query}\nEND\n\nGO\n");
                }
                else if (gentype == DataGenType.Update)
                {
                    //sb.Append("--- Table " + tablename);
                    //sb.Append("\n");
                    //sb.Append("IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLESWHERE TABLE_SCHEMA = 'dbo'AND TABLE_NAME = '" + tablename + "')");
                    //sb.Append("\nBEGIN\n\tDROP TABLE " + tablename);
                    //sb.Append("\nEND\nGO\n\n");
                    //sb.Append("--- Table " + tablename);
                    //sb.Append("\n");
                    //sb.Append("\n{query}\n\nGO\n");
                }
                else if (gentype == DataGenType.Truncate)
                {
                    sb.Append("--- Table " + tablename);
                    sb.Append("\n");
                    sb.Append("IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo'AND TABLE_NAME = '" + tablename + "')");
                    sb.Append("\nBEGIN\n");
                    sb.Append("\tTRUNCATE TABLE [dbo].[" + tablename + "]");
                    sb.Append("\nEND\n\nGO\n");
                }
                else if (gentype == DataGenType.TruncateInsert)
                {
                    sb.Append("--- Table " + tablename);
                    sb.Append("\n");
                    sb.Append("IF EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo'AND TABLE_NAME = '" + tablename + "')");
                    sb.Append("\nBEGIN\n");
                    sb.Append("\tTRUNCATE TABLE [dbo].[" + tablename + "]");
                    sb.Append("\nEND\n\nGO\n");
                    sb.Append("\n{query}\nGO\n");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return sb.ToString();
        }
    }
}
