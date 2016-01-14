using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevKit.Business;

namespace DevKit.UI.Helpers
{
    public class ScriptHelper
    {
        public string DropQuery(string spname, bool version)
        {
            string query = "";
            if(version)
                query += "--- *** Begin " + spname + " *** ---" + Environment.NewLine + Environment.NewLine;
            
            query += "IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id(N'[dbo].[" + spname + "]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)" + Environment.NewLine +
                           "DROP PROCEDURE [dbo].[" + spname + "]" + Environment.NewLine +
                           "" + Environment.NewLine +
                           "/****** Object:  StoredProcedure [dbo].[" + spname + "]    Script Date: " +
                           DateTime.Now.ToString("dd-MM-yy hh:mm:ss tt") + " ******/" + Environment.NewLine +
                           "SET ANSI_NULLS ON" + Environment.NewLine +
                           "GO" + Environment.NewLine +
                           "SET QUOTED_IDENTIFIER ON" + Environment.NewLine +
                           "GO" + Environment.NewLine;
            return query;

        }


        public string GenerateIndividualScript(string spname, string query,bool version)
        {
            string dropquery = DropQuery(spname,version);
            string script = dropquery + query + Environment.NewLine + Environment.NewLine + "GO" + Environment.NewLine +
                            Environment.NewLine;
            if (version)
                script += "--- *** End " + spname + " *** ---" + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            else
                script += Environment.NewLine;
            return script;
        }

        public string GenerateVersionScript(List<string> splist)
        {
            StoredProcedureBusiness spData = new StoredProcedureBusiness();
            string ver_script = "";
            foreach (var spname in splist)
            {
                string dropquery = DropQuery(spname,true);
                string script = dropquery + spData.GetScript(null, spname).Trim() + Environment.NewLine + Environment.NewLine + "GO" + Environment.NewLine + Environment.NewLine + Environment.NewLine;
                script += "--- *** End " + spname + " *** ---" + Environment.NewLine + Environment.NewLine
                + Environment.NewLine;
                ver_script += script;
            }
            return ver_script;
        }
    }
}
