using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevKit.Business;
using DevKit.Common;
using DevKit.Model;

namespace DevKit.UI
{
    public partial class frmScriptViewer : Form
    {
        private string _script = "";
        private List<ServerModel> _envlist = null;
        private StoredProcedureBusiness spdata = null;
        private bool _edit = false;
        private string _scriptname = "";
        public bool Edit
        {
            get { return _edit; }
            set
            {
                _edit = value;
                ChangeMode();
            }
        }
        public frmScriptViewer(string script,string filename = "")
        {
            InitializeComponent();
            _script = script;
            _envlist = new List<ServerModel>();
            _scriptname = filename;
        }

        private void ChangeMode()
        {
            if (Edit)
            {
                txtQuery.ReadOnly = false;
                tsbtnEdit.BackColor = Color.DarkOrange;
                tsbtnEdit.Text = "Disable Edit";
            }
            else
            {
                txtQuery.ReadOnly = true;
                tsbtnEdit.BackColor = SystemColors.Highlight;
                tsbtnEdit.Text = "Enable Edit";
            }
        }

        private void frmScriptViewer_Load(object sender, EventArgs e)
        {
            try
            {
                txtQuery.Text = _script;
                LoadEnvironments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadEnvironments()
        {
            EntityBusiness edata = new EntityBusiness();
            var serverlist =
                edata.GetServerList().Where(x => x.ServerID != AppTimeConfiguration.MainServer.ServerID).ToList();
            if (serverlist != null)
            {
                _envlist = serverlist;
                foreach (var s in serverlist)
                {
                    ToolStripItem item = new ToolStripMenuItem();
                    item.Text = s.Database;
                    item.Name = s.ServerID.ToString();
                    item.Click += new EventHandler(item_Click);
                    tsbtnExeOn.DropDownItems.Add(item);
                }
            }
            ToolStripSeparator tsSeparator = new ToolStripSeparator();
            tsbtnExeOn.DropDownItems.Add(tsSeparator);

            ToolStripItem itemall = new ToolStripMenuItem();
            itemall.Text = "All Environments";
            itemall.Name = "all";
            itemall.Click += new EventHandler(item_Click);
            tsbtnExeOn.DropDownItems.Add(itemall);
        }

        void item_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem item = sender as ToolStripMenuItem;
                if (item.Name == "all")
                {
                    foreach (var env in _envlist)
                    {
                        ExecuteQueryOnServer(env, _script);
                    }
                }
                else
                {
                    var server = _envlist.Where(x => x.ServerID.ToString() == item.Name).FirstOrDefault();
                    if (server != null)
                        ExecuteQueryOnServer(server, _script);
                }
                MessageBox.Show("Query executed successfully", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ExecuteQueryOnServer(ServerModel server, string query)
        {
            StoredProcedureBusiness spdata = new StoredProcedureBusiness();
            var res = spdata.ExecuteQuery(server == null ? AppTimeConfiguration.MainServer : server, query);
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            Edit = !Edit;
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                savefileDiag.DefaultExt = "sql";
                if (_scriptname.Trim().Length > 0)
                    savefileDiag.FileName = _scriptname;
                DialogResult res = savefileDiag.ShowDialog();
                if (res == DialogResult.OK)
                {
                    string path = savefileDiag.FileName;
                    string query = txtQuery.Text;
                    FileHelper.UpdateFileText(path, query);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
