using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevKit.Data;
using DevKit.Model;

namespace DevKit.Business
{
    public class TableBusiness
    {
        private TableData tdata = new TableData();
        public List<TableModel> GetTableList(ServerModel server)
        {
            try
            {
                return tdata.GetTableList(server);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<TableModel> SearchTable(ServerModel server,string tablename)
        {
            try
            {
                return tdata.SearchTable(server,tablename);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
