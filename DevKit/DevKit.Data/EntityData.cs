using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevKit.Entity;
using DevKit.Model;
using Microsoft.SqlServer.Management.Common;

namespace DevKit.Data
{
    public class EntityData
    {
        public List<ServerModel> GetServerList()
        {
            try
            {
                using (DevKitEntities db = new DevKitEntities())
                {
                    var res = db.DBServers.Where(x=> x.IsVisible).Select(s => new ServerModel()
                    {
                        ServerID = s.ServerID,
                        ServerName = s.Servername,
                        Username = s.Username,
                        Password = s.Password,
                        Database = s.Database,
                        DbAlias = s.DBName,
                        IsMain = s.IsMain,

                        IsVisible = s.IsVisible
                    });
                    return res.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ServerModel> GetAllServers()
        {
            try
            {
                using (DevKitEntities db = new DevKitEntities())
                {
                    var res = db.DBServers.Select(s => new ServerModel()
                    {
                        ServerID = s.ServerID,
                        ServerName = s.Servername,
                        Username = s.Username,
                        Password = s.Password,
                        Database = s.Database,
                        DbAlias = s.DBName,
                        IsMain = s.IsMain,

                        IsVisible = s.IsVisible
                    });
                    return res.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AddServer(ServerModel server)
        {
            try
            {
                DBServer ns = new DBServer();
                ns.Servername = server.ServerName;
                ns.Username = server.Username;
                ns.Password = server.Password;
                ns.Database = server.Database;
                ns.DBName = server.DbAlias;
                ns.IsMain = server.IsMain;
                ns.IsVisible = server.IsVisible;

                using (DevKitEntities db = new DevKitEntities())
                {
                    db.DBServers.Add(ns);
                    db.SaveChanges();
                    return ns.ServerID;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int UpdateDatabases(List<ServerModel> slist)
        {
            try
            {
                using (DevKitEntities db = new DevKitEntities())
                {
                    foreach (var server in slist)
                    {
                        var sr = db.DBServers.Where(x => x.ServerID == server.ServerID).FirstOrDefault();
                        if (sr != null)
                        {
                            sr.IsVisible = server.IsVisible;
                        }
                    }
                    return db.SaveChanges();
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return 0;
        }

        public void RemoveServer(int id)
        {
            try
            {
                using (DevKitEntities db = new DevKitEntities())
                {
                    var server = db.DBServers.Where(s => s.ServerID == id).FirstOrDefault();
                    db.DBServers.Remove(server);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ClearAllDatabases()
        {
            try
            {
                using (DevKitEntities db = new DevKitEntities())
                {
                    db.Database.ExecuteSqlCommand("TRUNCATE TABLE DBServer");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<SPModel> GetAllStoredProcedures()
        {
            try
            {
                using (DevKitEntities db = new DevKitEntities())
                {
                    var res = db.StoredProcedures.Select(s => new SPModel()
                    {
                        SPID = s.Id,
                        SPName = s.SPName,
                        CreatedDate = s.CreatedDate,
                        SPDate = s.SPDate
                    }).ToList();
                    return res;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public long AddNewSP(SPModel sp)
        {
            try
            {
                using (DevKitEntities db = new DevKitEntities())
                {
                    bool exists = db.StoredProcedures.AsEnumerable().Any(x => x.SPName.ToLower() == sp.SPName.ToLower()
                    && x.SPDate == sp.SPDate);
                    if (exists)
                    {
                        return -1;
                    }
                    StoredProcedure nsp =new StoredProcedure();
                    nsp.SPName = sp.SPName;
                    nsp.CreatedDate = sp.CreatedDate;
                    nsp.SPDate = sp.SPDate;

                    db.StoredProcedures.Add(nsp);
                    db.SaveChanges();
                    return nsp.Id;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<SPModel> GetDailyStoredProcedures(DateTime date)
        {
            try
            {
                using (DevKitEntities db = new DevKitEntities())
                {
                    var res = db.StoredProcedures.AsEnumerable().Where(s=> s.SPDate.Value.Date == date.Date).Select(s => new SPModel()
                    {
                        SPID = s.Id,
                        SPName = s.SPName,
                        CreatedDate = s.CreatedDate,
                        SPDate = s.SPDate
                    }).ToList();
                    return res;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ImportStoredProcedures(List<Int64> splist,DateTime importdate)
        {
            try
            {
                using (DevKitEntities db = new DevKitEntities())
                {
                    var copylist = db.StoredProcedures.Where(x => splist.Contains(x.Id)).ToList();
                    var datelist = db.StoredProcedures.AsEnumerable()
                        .Where(x => x.SPDate.Value.Date == importdate.Date).ToList();
                    var filterlist =
                        copylist.Where(x => !datelist.Select(y => y.SPName.ToLower()).Contains(x.SPName.ToLower()))
                            .ToList();
                    var insertlist = filterlist.Select(x => new StoredProcedure()
                    {
                        SPName = x.SPName,
                        CreatedDate = DateTime.Now,
                        SPDate = importdate.Date
                    }).ToList();
                    foreach (var sp in insertlist)
                    {
                        db.StoredProcedures.Add(sp);
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveStoredProcedure(long id)
        {
            try
            {
                using (DevKitEntities db = new DevKitEntities())
                {
                    var obj = db.StoredProcedures.Where(x => x.Id == id).FirstOrDefault();
                    if (obj != null)
                    {
                        db.StoredProcedures.Remove(obj);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<TableModel> GetLastTableScriptSession()
        {
            try
            {
                using (DevKitEntities db = new DevKitEntities())
                {
                    var sess = db.DBScriptSessions.Select(x => new TableModel()
                    {
                        TableId = x.TableId,
                        TableName = x.TableName
                    }).OrderBy(x=> x.TableName).ToList();
                    return sess;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddTableObject(List<TableModel> tablelist)
        {
            try
            {
                using (DevKitEntities db = new DevKitEntities())
                {
                    foreach (var tbl in tablelist)
                    {
                        
                        db.DBScriptSessions.Add(new DBScriptSession()
                        {
                            TableId = tbl.TableId,
                            TableName = tbl.TableName
                        });
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveTabelObject(List<TableModel> tablelist)
        {
            try
            {
                using (DevKitEntities db = new DevKitEntities())
                {
                    foreach (var tbl in tablelist)
                    {
                        var obj = db.DBScriptSessions.Where(x => x.TableId == tbl.TableId).FirstOrDefault();
                        if (obj != null)
                        {
                            db.DBScriptSessions.Remove(obj);
                        }
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
