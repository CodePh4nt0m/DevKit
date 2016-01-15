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
    public partial class frmQueryWindow : Form
    {
        private List<ServerModel> _envlist = null;
        public frmQueryWindow()
        {
            InitializeComponent();
            _envlist = new List<ServerModel>();
        }

        private void LoadEnvironments()
        {
            EntityBusiness edata = new EntityBusiness();
            var serverlist =
                edata.GetServerList().ToList();
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
                string script = txtQuery.Text;
                ToolStripMenuItem item = sender as ToolStripMenuItem;
                if (item.Name == "all")
                {
                    foreach (var env in _envlist)
                    {
                        ExecuteQueryOnServer(env, script);
                    }
                }
                else
                {
                    var server = _envlist.Where(x => x.ServerID.ToString() == item.Name).FirstOrDefault();
                    if (server != null)
                        ExecuteQueryOnServer(server, script);
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

        private void frmQueryWindow_Load(object sender, EventArgs e)
        {
            LoadEnvironments();
        }

        private void tsbtnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                openfileDiag.Filter = "*.sql|*.sql";
                DialogResult res = openfileDiag.ShowDialog();
                if(res == DialogResult.OK)
                {
                    string text = FileHelper.ReadFile(openfileDiag.FileName);
                    txtQuery.Text = text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                savefileDiag.DefaultExt = "sql";
                DialogResult res = savefileDiag.ShowDialog();
                if (res == DialogResult.OK)
                {
                    string path = savefileDiag.FileName;
                    string query = txtQuery.Text;
                    FileHelper.UpdateFileText(path,query);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
