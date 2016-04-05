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
            selectedtables = new List<TableModel>();
            maindb = new ServerModel();
            LoadLastSavedSession();
        }

        private void LoadLastSavedSession()
        {
            try
            {
                EntityBusiness entityBusiness = new EntityBusiness();
                var lastsess = entityBusiness.GetLastTableScriptSession();
                selectedtables = lastsess;
                dgvtblSelected.DataSource = selectedtables;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            EntityBusiness entityBusiness = new EntityBusiness();
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
            entityBusiness.AddTableObject(newtables);
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
            tscomserver.ComboBox.DisplayMember = "DbAlias";
            tscomserver.ComboBox.ValueMember = "ServerID";
            tscomserver.ComboBox.DataSource = dbs;
            string mainserver = new ConfigurationHelper().GetConfigurationValue("mainserver");
            if (mainserver != "0" && mainserver != "")
            {
                tscomserver.ComboBox.SelectedValue = Convert.ToInt32(mainserver);
                maindb = dbs.Where(x => x.ServerID == Convert.ToInt32(mainserver)).FirstOrDefault();
                //LoadOtherDBs(dbs, Convert.ToInt32(mainserver));
            }

            else
            {
                tscomserver.ComboBox.SelectedIndex = -1;
                //LoadOtherDBs(dbs, 0);
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
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            dgvtblSelected.EndEdit();
            var remlist = new List<int>();
            foreach (DataGridViewRow rw in dgvtblSelected.Rows)
            {
                if (Convert.ToBoolean(rw.Cells[1].Value))
                {
                    remlist.Add(Convert.ToInt32(rw.Cells[0].Value));
                }
            }

            EntityBusiness entityBusiness = new EntityBusiness();
            entityBusiness.RemoveTabelObject(remlist.Select(x=> new TableModel()
            {
                TableId = x
            }).ToList());
            foreach (var id in remlist)
            {
                selectedtables.Remove(selectedtables.Where(x => x.TableId == id).First());
            }
            selectedtables = selectedtables.OrderBy(x => x.TableName).ToList();
            dgvtblSelected.DataSource = selectedtables;
        }

        private void btnStuctGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                if (cbStructure.Checked)
                {
                    sb.AppendLine("/******* Table Structures *******/ \n");
                    sb.Append(GenerateStructureScript());
                    sb.AppendLine("/******* End Table Structures *******/ \n");
                    sb.Append("\n \n \n \n");
                }

                if (cbData.Checked)
                {
                    sb.AppendLine("/******* Data Script *******/ \n");
                    sb.Append(GenerateDataScript());
                    sb.AppendLine("/******* End Data Script *******/ \n");
                }


                frmScriptViewer frm = new frmScriptViewer(sb.ToString(), "Script-" + DateTime.Now.Ticks);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string GenerateStructureScript()
        {
            StructureType stype = StructureType.IfNotExists;
            if(rbStIfNotExists.Checked)
                stype = StructureType.IfNotExists;
            else if (rbStDropnCreate.Checked)
                stype = StructureType.DropAndCreate;
            else if (rbStCreate.Checked)
                stype = StructureType.Create;

            ScriptBusiness scriptBusiness = new ScriptBusiness();
            string query = scriptBusiness.GenerateTableStructure(AppTimeConfiguration.MainServer, stype, selectedtables);
            return query;
        }

        public string GenerateDataScript()
        {
            DataGenType dtype = DataGenType.Insert;

            if (rbDInsert.Checked)
                dtype = DataGenType.Insert;
            else if (rbDUpdate.Checked)
                dtype = DataGenType.Update;
            else if (rbDTruncate.Checked)
                dtype = DataGenType.Truncate;
            else if (rbDTruncateInsert.Checked)
                dtype = DataGenType.TruncateInsert;

            ScriptBusiness scriptBusiness = new ScriptBusiness();
            var server = new EntityBusiness().GetServerList().Where(x=> x.ServerID == Convert.ToInt32(tscomserver.ComboBox.SelectedValue)).First();
            string query = scriptBusiness.GenerateTableData(server, dtype, selectedtables);
            return query;
        }

        private void cbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            //foreach (var tbl in selectedtables)
            //{
            //    tbl.bSelected = cbSelectAll.Checked;
            //}
            //foreach (DataGridViewRow row in dgvtblSelected.Rows)
            //{
            //    var cb = row.Cells[1] as DataGridViewCheckBoxCell;
            //    cb.Value = cbSelectAll.Checked;
            //}
            //dgvtblSelected.EndEdit();
            //dgvtblSelected.DataSource = selectedtables;
        }
    }
}