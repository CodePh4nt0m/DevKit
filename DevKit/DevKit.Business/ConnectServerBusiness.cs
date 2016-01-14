using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevKit.Data;
using DevKit.Model;

namespace DevKit.Business
{
    public class ConnectServerBusiness
    {
        ConnectServerData connectServerData= new ConnectServerData();
        public List<string> GetServerDatabaseList(ServerModel server)
        {
            try
            {
                return connectServerData.GetServerDatabaseList(server);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
