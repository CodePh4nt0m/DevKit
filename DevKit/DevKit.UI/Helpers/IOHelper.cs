using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using  System.Windows.Forms;
using DevKit.Business;

namespace DevKit.UI.Helpers
{
    public class IOHelper
    {
        public void SaveSingleScript(List<string> splist)
        {
            if (splist != null && splist.Count > 0)
            {
                string dirname = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();
                string path = Application.StartupPath + "\\GeneratedScripts\\" + dirname;
                Directory.CreateDirectory(path);
                string[] dirs = Directory.GetDirectories(path);
                int dirno = 0;
                if (dirs.Length > 0)
                {
                    int maxno = 1;
                    foreach (var dir in dirs)
                    {
                        string no = Regex.Match(new DirectoryInfo(dir).Name, @"\d+").Value;
                        if (no.Trim().Length > 0)
                        {
                            if (Convert.ToInt32(no.Trim()) > maxno)
                                maxno = Convert.ToInt32(no.Trim());
                        }
                    }
                    if (dirno < maxno)
                        dirno = maxno;
                }
                dirno = dirno + 1;
                string grouppath = path + "\\" + dirno.ToString("00");
                Directory.CreateDirectory(grouppath);
                StoredProcedureBusiness spdata = new StoredProcedureBusiness();
                ScriptHelper spHelper = new ScriptHelper();
                foreach (var sp in splist)
                {
                    string query = spHelper.GenerateIndividualScript(sp, spdata.GetScript(null, sp),false);
                    System.IO.File.WriteAllText(grouppath + "\\" + sp + ".sql", query);
                }
                Process.Start(grouppath);
            }
        }
    }
}
