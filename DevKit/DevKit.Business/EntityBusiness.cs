using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevKit.Data;
using DevKit.Model;

namespace DevKit.Business
{
    public class EntityBusiness
    {
        private EntityData entityData = new EntityData();

        public List<ServerModel> GetServerList()
        {
            try
            {
                var res = entityData.GetServerList();
                return res;
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
                var res = entityData.GetAllServers();
                return res;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AddNewDbServer(ServerModel newServer)
        {
            try
            {
                return entityData.AddServer(newServer);
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
                return entityData.UpdateDatabases(slist);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveServer(int serverid)
        {
            try
            {
                entityData.RemoveServer(serverid);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ServerModel SelectServer(int id)
        {
            try
            {
                var res = entityData.GetServerList();
                return res.Where(x => x.ServerID == id).FirstOrDefault();
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
                entityData.ClearAllDatabases();
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
                return entityData.GetAllStoredProcedures().OrderBy(x => x.SPName).ToList();
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
                return entityData.AddNewSP(sp);
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
                return entityData.GetDailyStoredProcedures(date).OrderBy(x=> x.SPName).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ImportStoredProcedures(List<Int64> splist, DateTime date)
        {
            try
            {
                entityData.ImportStoredProcedures(splist, date);
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
                return entityData.GetLastTableScriptSession();
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
                entityData.RemoveStoredProcedure(id);
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
                entityData.AddTableObject(tablelist);
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
                entityData.RemoveTabelObject(tablelist);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
   }
}
