using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevKit.Common;
using DevKit.Data;
using DevKit.Model;

namespace DevKit.Business
{
    public class StoredProcedureBusiness
    {
        StoredProcedureData spData = new StoredProcedureData();
        public List<SPModel> GetStoredProcedureList(ServerModel server)
        {
            try
            {
                return spData.GetStoredProcedureList(server);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string GetScript(ServerModel server, string spname)
        {
            try
            {
                return spData.GetScript(server, spname);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public object ExecuteQuery(ServerModel server, string query)
        {
            try
            {
                return spData.ExecuteQuery(server,query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
