using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevKit.Business;
using DevKit.Model;

namespace DevKit.UI
{
    public partial class frmNewDatabase : Form
    {
        public Form _parentForm = null;
        public frmNewDatabase(Form frm)
        {
            InitializeComponent();
            _parentForm = frm;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDatabase.Text.Trim().Length < 1)
                {
                    MessageBox.Show("Databse Alias is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                AddNewServer();

                if (_parentForm is frmDatabases)
                {
                    frmDatabases frm = _parentForm as frmDatabases;
                    frm.LoadDatabases();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNewDatabase_Load(object sender, EventArgs e)
        {
            try
            {
                LoadExistingServers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadExistingServers()
        {
            EntityBusiness business = new EntityBusiness();
            var servers = business.GetServerList();
            cmbServerName.DisplayMember = "ServerName";
            cmbServerName.ValueMember = "ServerID";
            cmbServerName.DataSource = servers;
            cmbServerName.SelectedIndex = -1;
        }

        void AddNewServer()
        {
            ServerModel ns = new ServerModel();
            ns.ServerName = cmbServerName.Text.Trim();
            ns.Username = txtUsername.Text.Trim();
            ns.Password = txtPassword.Text.Trim();
            ns.Database = cmbDatabase.Text.Trim();
            ns.DbAlias = txtDatabase.Text.Trim();

            EntityBusiness business = new EntityBusiness();
            int res = business.AddNewDbServer(ns);
            ClearForm();

            if (res > 0)
                MessageBox.Show("Details saved succesfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        void ClearForm()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            cmbDatabase.DataSource = null;
            LoadExistingServers();
        }

        private void btnLoadDB_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDatabases();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadDatabases()
        {
            ServerModel sm = new ServerModel();
            sm.ServerName = cmbServerName.Text.Trim();
            sm.Username = txtUsername.Text.Trim();
            sm.Password = txtPassword.Text.Trim();

            ConnectServerBusiness business = new ConnectServerBusiness();
            var dblist = business.GetServerDatabaseList(sm);
            cmbDatabase.DataSource = dblist;
        }

        private void cmbServerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SelectServer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void SelectServer()
        {
            if (cmbServerName.SelectedIndex >= 0)
            {
                if (cmbServerName.Items.Count > 0)
                {
                    EntityBusiness business = new EntityBusiness();
                    var server = business.SelectServer(Convert.ToInt32(cmbServerName.SelectedValue));
                    if (server != null)
                    {
                        txtUsername.Text = server.Username;
                        txtPassword.Text = server.Password;
                    }
                }
            }
            
        }
    }
}
