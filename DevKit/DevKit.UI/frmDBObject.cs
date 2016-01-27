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
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Smo.SqlEnum;

namespace DevKit.UI
{
    public partial class frmDBObject : Form
    {
        private List<TableModel> selectedtables { get; set; }
        private ServerModel maindb { get; set; }
        public frmDBObject()
        {
            InitializeComponent();
            dgvallTables.AutoGenerateColumns = false;
            dgvtblSelected.AutoGenerateColumns = false;
            dgvDB.AutoGenerateColumns = false;
            selectedtables = new List<TableModel>();
            maindb = new ServerModel();
        }

        private void frmDBObject_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDatabases();
                if (tscomserver.SelectedIndex >= 0)
                {
                    LoadTables();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadTables()
        {
            TableBusiness tdata = new TableBusiness();
            var tlist = tdata.GetTableList(maindb);
            dgvallTables.DataSource = tlist;
        }

        private void SearchTable()
        {
            TableBusiness tdata = new TableBusiness();
            var tlist = tdata.SearchTable(maindb, txtname.Text.Trim());
            dgvallTables.DataSource = tlist;
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text.Trim().Length > 0)
                {
                    SearchTable();
                }
                else
                {
                    LoadTables();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddTables()
        {
            dgvallTables.EndEdit();
            var tbllist = new List<TableModel>();
            foreach (DataGridViewRow rw in dgvallTables.Rows)
            {
                if (Convert.ToBoolean(rw.Cells[1].Value))
                    tbllist.Add(new TableModel()
                    {
                        TableId = Convert.ToInt32(rw.Cells[0].Value.ToString()),
                        bSelected = true,
                        TableName = rw.Cells[2].Value.ToString()
                    });
            }

            var newtables =
                tbllist.Where(y => !selectedtables.Select(x => x.TableId).Contains(y.TableId))
                    .ToList();
            selectedtables.AddRange(newtables);
            selectedtables = selectedtables.OrderBy(x => x.TableName).ToList();
            dgvtblSelected.DataSource = selectedtables;
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            try
            {
                AddTables();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadDatabases()
        {
            tscomserver.SelectedIndexChanged -= tscomserver_SelectedIndexChanged;

            EntityBusiness entityBusiness = new EntityBusiness();
            var dbs = entityBusiness.GetServerList();
            tscomserver.ComboBox.DisplayMember = "Database";
            tscomserver.ComboBox.ValueMember = "ServerID";
            tscomserver.ComboBox.DataSource = dbs;
            string mainserver = new ConfigurationHelper().GetConfigurationValue("mainserver");
            if (mainserver != "0" && mainserver != "")
            {
                tscomserver.ComboBox.SelectedValue = Convert.ToInt32(mainserver);
                maindb = dbs.Where(x => x.ServerID == Convert.ToInt32(mainserver)).FirstOrDefault();
                LoadOtherDBs(dbs, Convert.ToInt32(mainserver));
            }

            else
            {
                tscomserver.ComboBox.SelectedIndex = -1;
                LoadOtherDBs(dbs, 0);
            }
                

            tscomserver.SelectedIndexChanged += tscomserver_SelectedIndexChanged;
        }

        private void tscomserver_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tscomserver.ComboBox.Items.Count > 0)
                {
                    if (tscomserver.ComboBox.SelectedIndex != -1)
                    {
                        int id = Convert.ToInt32(tscomserver.ComboBox.SelectedValue);
                        EntityBusiness data = new EntityBusiness();
                        var servers = data.GetServerList();
                        maindb = servers.Where(x => x.ServerID == id).FirstOrDefault();
                        LoadTables();
                        LoadOtherDBs(servers,id);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadOtherDBs(List<ServerModel> dblist,int mainid)
        {
            if (mainid == 0)
            {
                dgvDB.DataSource = dblist;
            }
            else
            {
                dgvDB.DataSource = dblist.Where(x => x.ServerID != mainid).ToList();
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                //GenerateScripts();
                TableBusiness tdata = new TableBusiness();
                //tdata.GenerateTableSript(AppTimeConfiguration.MainServer);
                EntityBusiness data = new EntityBusiness();
                var servers = data.GetServerList();
                var tbllist = new List<TableModel>();
                var compserver = servers.Where(x => x.ServerID == Convert.ToInt32(dgvDB.Rows[0].Cells[0].Value.ToString())).First();
                foreach (DataGridViewRow rw in dgvtblSelected.Rows)
                {
                    tbllist.Add(new TableModel()
                    {
                        TableName = rw.Cells[2].Value.ToString()
                    });
                }

                tdata.GenerateTableSript(AppTimeConfiguration.MainServer,compserver,tbllist);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateScripts()
        {
            EntityBusiness data = new EntityBusiness();
            var servers = data.GetServerList();
            var selectedservers = new List<ServerModel>();

            int id = Convert.ToInt32(tscomserver.ComboBox.SelectedValue);
            var mainserver = servers.Where(x => x.ServerID == id).First();

            foreach (DataGridViewRow rw in dgvDB.Rows)
            {
                if (Convert.ToBoolean(rw.Cells[1].Value))
                {
                    selectedservers.Add(servers.Where(x=> x.ServerID == Convert.ToInt32(rw.Cells[0].Value)).First());
                }
            }


        }
    }
}
