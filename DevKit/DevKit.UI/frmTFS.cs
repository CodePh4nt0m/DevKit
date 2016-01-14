using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevKit.Business;
using DevKit.Common;
using DevKit.Model;
using DevKit.UI.Helpers;

namespace DevKit.UI
{
    public partial class frmTFS : Form
    {
        private List<CheckInModel> StoredProcedures = null;
        private DateTime ScriptDate = DateTime.Now;
        ConfigurationHelper config = new ConfigurationHelper();

        private string _username = "";
        private string _password = "";

        private string _path_sp_local = "";
        private string _path_sp_tfs = "";
        private string _path_version_local = "";
        private string _path_version_tfs = "";

        public frmTFS(List<CheckInModel> list,DateTime date)
        {
            InitializeComponent();
            StoredProcedures = list;
            ScriptDate = date;
            txtConsole.WordWrap = true;
            LoadConfiguration();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                //CommandHelper cmd = new CommandHelper();
                //var res = cmd.ExecuteCommand(txtComment.Text);
                //if(res != null)
                //{
                //    if (res.IsError)
                //    {
                //        AddConsoleText(res.Error, res.IsError);
                //    }
                //    else
                //    {
                //        AddConsoleText(res.Output, res.IsError);
                //    }
                //}
                CheckInScripts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtConsole.Clear();
        }

        private void frmTFS_Load(object sender, EventArgs e)
        {
            //txtComment.Text = "tf checkout \"$/Salestar_V4/Salestar/Database Scripts/VersionScripts/20160107.sql\" /login:dilnuwan,nuw@123";
        }

        void AddConsoleText(ShellOutput result)
        {
            if (result != null)
            {
                string text = "";
                if (result.IsError)
                    text = result.Error;
                else
                    text = result.Output;

                int length = txtConsole.TextLength;
                txtConsole.AppendText(text);
                txtConsole.SelectionStart = length;
                txtConsole.SelectionLength = text.Length;
                if (result.IsError)
                    txtConsole.SelectionColor = Color.Orange;
                else
                    txtConsole.SelectionColor = Color.White;
                txtConsole.AppendText(Environment.NewLine);
                txtConsole.SelectionStart = txtConsole.Text.Length;
                txtConsole.ScrollToCaret();
            }
            
        }

        void AddManualConsoleTest(string text)
        {
            int length = txtConsole.TextLength;
            txtConsole.AppendText(text);
            txtConsole.SelectionStart = length;
            txtConsole.SelectionLength = text.Length;
            txtConsole.SelectionColor = Color.ForestGreen;
            txtConsole.AppendText(Environment.NewLine);
            txtConsole.SelectionStart = txtConsole.Text.Length;
            txtConsole.ScrollToCaret();
        }
        void LoadConfiguration()
        {
            string sp_local = config.GetConfigurationValue("path_local_sp");
            string sp_tfs = config.GetConfigurationValue("path_tfs_sp");
            string version_local = config.GetConfigurationValue("path_local_version");
            string version_tfs = config.GetConfigurationValue("path_tfs_version");
            string tfs_username = config.GetConfigurationValue("tfs_username");
            string tfs_password = config.GetConfigurationValue("tfs_password");

            _username = tfs_username;
            _password = tfs_password;

            _path_sp_local = sp_local;
            _path_sp_tfs = sp_tfs;
            _path_version_local = version_local;
            _path_version_tfs = version_tfs;
    }
        void CheckInScripts()
        {
            List<CheckInModel> errorlist = new List<CheckInModel>();
            List<CheckInModel> successlist = new List<CheckInModel>();

            successlist = StoredProcedures;

            var bVersion = cbVersion.Checked;
            var bSingle = cbSP.Checked;

            if (_username.Length > 0 && _password.Length > 0)
            {
                TFSAuthModel auth = new TFSAuthModel() { Username = _username, Password = _password };

                if (StoredProcedures.Count > 0)
                {
                    if (bVersion || bSingle)
                    {
                        // get latest project files
                        if (bVersion)
                        {
                            var res = TFSHelper.GetLatest(_path_version_tfs, auth);
                            AddConsoleText(res);
                            if (res.IsError)
                            {
                                
                                MessageBox.Show("Error occured while updating version scripts", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        if (bSingle)
                        {
                            var res = TFSHelper.GetLatest(_path_sp_tfs, auth);
                            AddConsoleText(res);
                            if (res.IsError)
                            {
                                
                                MessageBox.Show("Error occured while updating Stored Procedures", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                        }

                        AddManualConsoleTest("Getting latest scripts successful....");

                        // end getting latest

                        //create files if not exists - version
                        bool vcreated = false;
                        if (bVersion)
                        {
                            string path = _path_version_local + "\\" + FileHelper.GenerateDateFile(ScriptDate);
                            if (!File.Exists(path))
                            {
                                FileHelper.CreateFile(path);
                                vcreated = true;
                            }
                        }

                        //create files if not exists - single
                        if (bSingle)
                        {
                            foreach (var sp in StoredProcedures)
                            {
                                string path = _path_sp_local + "\\" + sp.Name + ".sql";
                                if (!File.Exists(path))
                                {
                                    FileHelper.CreateFile(path);
                                    sp.fCreated = true;
                                }
                            }
                        }

                        //checkout files for edit
                        if (bVersion)
                        {
                            if (!vcreated)
                            {
                                string path = _path_version_tfs + "\\" + FileHelper.GenerateDateFile(ScriptDate);
                                var res = TFSHelper.Checkout(path, auth);
                                AddConsoleText(res);
                            }
                        }

                        if (bSingle)
                        {
                            foreach (var sp in StoredProcedures)
                            {
                                string path = _path_sp_tfs + "\\" + sp.Name + ".sql";
                                if (!sp.fCreated)
                                {
                                    var res = TFSHelper.Checkout(path, auth);
                                    AddConsoleText(res);
                                    if(res.IsError)
                                        errorlist.Add(sp);
                                }
                            }
                        }


                        //add new files to tfs
                        //version script
                        if(bVersion)
                        {
                            if (vcreated)
                            {
                                var res = TFSHelper.AddFile(_path_version_local, FileHelper.GenerateDateFile(ScriptDate), auth);
                                AddConsoleText(res);
                            }
                        }

                        if (bSingle)
                        {
                            foreach (var sp in StoredProcedures)
                            {
                                string name = sp.Name + ".sql";
                                if (sp.fCreated)
                                {
                                    var res = TFSHelper.AddFile(_path_sp_local,name, auth);
                                    AddConsoleText(res);
                                }
                            }
                        }
                        

                        //update scripts text
                        if (bVersion)
                        {
                            if (vcreated)
                            {
                                string path = _path_version_local + "\\" + FileHelper.GenerateDateFile(ScriptDate);
                                FileHelper.UpdateFileText(path,new ScriptHelper().GenerateVersionScript(successlist.Select(x=> x.Name).ToList()));
                            }
                            else
                            {
                                string path = _path_version_local + "\\" + FileHelper.GenerateDateFile(ScriptDate);
                                string vscript = FileHelper.ReadFile(path);
                                StoredProcedureBusiness spData = new StoredProcedureBusiness();
                                foreach (var s in successlist)
                                {
                                    string script = new ScriptHelper().GenerateIndividualScript(s.Name, spData.GetScript(null, s.Name).Trim(),true);
                                    vscript = ReplaceScript(vscript,script,s.Name);
                                }
                                FileHelper.UpdateFileText(path,vscript);
                            }
                        }

                        //update single scripts
                        if (bSingle)
                        {
                            StoredProcedureBusiness spData = new StoredProcedureBusiness();
                            foreach (var sp in StoredProcedures)
                            {
                                string script = new ScriptHelper().GenerateIndividualScript(sp.Name, spData.GetScript(null, sp.Name).Trim(), false);
                                string path = _path_sp_local + "\\" + sp.Name + ".sql";
                                FileHelper.UpdateFileText(path, script);
                            }
                        }


                        //checkin pending changes
                        string comment = "";
                        if (txtComment.Text.Trim().Length > 0)
                            comment = txtComment.Text.Trim();
                        else
                            comment = "Script Changes";
                        var checkinres = TFSHelper.CheckIn(comment, auth);
                        AddConsoleText(checkinres);
                        AddManualConsoleTest("Operation completed successfuly");

                    }
                }
            }
            
        }

        string ReplaceScript(string original, string script, string name)
        {
            int indexstart = original.IndexOf("--- *** Begin " + name + " *** ---");
            int indexend = original.IndexOf("--- *** End " + name + " *** ---");

            int indexwith = indexend - indexstart + 20 + name.Length;
            int querylength = original.Length;

            string sub = original.Substring(indexend + 20 + name.Length);
            //int nextcharindex = Regex.Match(sub, @"\S").Index;
            string retstr = original;
            if (indexstart != -1 && indexend != -1)
            {
                retstr = original.Remove(indexstart);
                retstr = retstr.Trim();
                if(retstr.Length > 0)
                    retstr += Environment.NewLine + Environment.NewLine + Environment.NewLine;
                string endquery = sub.Trim();
                if(endquery.Length > 0)
                    retstr += endquery + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            }
            retstr += script;
            return retstr;
        }
    }
}
