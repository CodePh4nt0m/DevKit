using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevKit.Business;
using DevKit.Common;
using DevKit.Model;
using FastColoredTextBoxNS;

namespace DevKit.UI
{
    public partial class frmQueryWindow : Form
    {
        private List<ServerModel> _envlist = null;
        FastColoredTextBoxNS.Style greenStyle = new TextStyle(Brushes.Green, null, FontStyle.Regular);
        FastColoredTextBoxNS.Style redsStyle = new TextStyle(Brushes.Red, null, FontStyle.Regular);
        FastColoredTextBoxNS.Style blueStyle = new TextStyle(Brushes.DodgerBlue, null, FontStyle.Regular);
        public frmQueryWindow()
        {
            InitializeComponent();
            _envlist = new List<ServerModel>();
        }

        public frmQueryWindow(string script)
        {
            InitializeComponent();
            _envlist = new List<ServerModel>();
            txtQuery.Text = script;
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
                    item.Text = s.DbAlias;
                    item.Name = s.ServerID.ToString();
                    item.Click += new EventHandler(item_Click);
                    tsbtnExeOn.DropDownItems.Add(item);

                    ToolStripItem item2 = new ToolStripMenuItem();
                    item2.Text = s.DbAlias;
                    item2.Name = s.ServerID.ToString();
                    item2.Click += new EventHandler(itemcheck_Click);
                    tsbtnExeOnSelected.DropDownItems.Add(item2);
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
                //MessageBox.Show(ex.Message);
                LogMessages(ex);
            }

        }

        void itemcheck_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem item = sender as ToolStripMenuItem;
                item.Checked = !item.Checked;
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

        private void LogMessages(Exception er)
        {
            try
            {
                if (er.InnerException == null)
                {
                    MessageBox.Show(er.Message);
                }
                else
                {
                    var exp = er.InnerException as SqlException;
                    MessageBox.Show(exp.Server + " : " + exp.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsbtnClear_Click(object sender, EventArgs e)
        {
            txtQuery.Clear();
        }

        private void tsbtnExeOnSelected_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                ExecuteOnSelected();
                MessageBox.Show("Query executed successfully", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                LogMessages(ex);
            }
        }

        private void ExecuteOnSelected()
        {
            string script = txtQuery.Text;
            foreach (var dtm in tsbtnExeOnSelected.DropDownItems)
            {
                ToolStripMenuItem item = dtm as ToolStripMenuItem;
                if (item.Checked)
                {
                    var server = _envlist.Where(x => x.ServerID.ToString() == item.Name).FirstOrDefault();
                    if (server != null)
                        ExecuteQueryOnServer(server, script);
                }
            }
        }
    }
}
