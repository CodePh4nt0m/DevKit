using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevKit.Data;
using DevKit.Model;

namespace DevKit.Business
{
    public class ScriptBusiness
    {
        private ScriptData scriptData = null;
        public ScriptBusiness()
        {
            scriptData = new ScriptData();
        }
        
        public string GenerateTableStructure(ServerModel server, StructureType gentype, List<TableModel> tables)
        {
            try
            {
                return scriptData.GenerateTableStructure(server, gentype, tables);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string GenerateTableData(ServerModel server, DataGenType gentype, List<TableModel> tables)
        {
            try
            {
                return scriptData.GenerateTableData(server, gentype, tables);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
