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
using DevKit.UI.Helpers;
using SideBySideTextBox;

namespace DevKit.UI
{
    public partial class frmDaily : Form
    {
        public frmDaily()
        {
            InitializeComponent();
            dgvSP.AutoGenerateColumns = false;
        }

        private void frmDaily_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDatabaseStoredProcedures();
                LoadStoredProcedures(dtpScriptDate.Value);
                LoadDataBases();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUpdateTFS_Click(object sender, EventArgs e)
        {
            try
            {
                dgvSP.EndEdit();
                List<CheckInModel> splist = new List<CheckInModel>();
                foreach (DataGridViewRow rw in dgvSP.Rows)
                {
                    if (Convert.ToBoolean(rw.Cells[2].Value))
                        splist.Add(new CheckInModel()
                        {
                            ID = Convert.ToInt32(rw.Cells[0].Value),
                            Name = rw.Cells[3].Value.ToString()
                        });
                }
                frmTFS frm = new frmTFS(splist, dtpScriptDate.Value);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadDatabaseStoredProcedures()
        {
            StoredProcedureBusiness spData = new StoredProcedureBusiness();
            var splist = spData.GetStoredProcedureList(AppTimeConfiguration.MainServer);
            if (splist != null)
            {
                txtspname.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtspname.AutoCompleteSource = AutoCompleteSource.CustomSource;
                var autosource = new AutoCompleteStringCollection();
                autosource.AddRange(splist.Select(x => x.SPName).ToArray());
                txtspname.AutoCompleteCustomSource = autosource;
            }
        }

        void AddNewStoredProcedure()
        {
            string spname = txtspname.Text.Trim();
            StoredProcedureBusiness spData = new StoredProcedureBusiness();
            var splist = spData.GetStoredProcedureList(AppTimeConfiguration.MainServer);
            if (splist.Select(x => x.SPName.ToLower()).Contains(spname.ToLower()))
            {
                string procname = splist.Where(x => x.SPName.ToLower() == spname.ToLower()).First().SPName;
                EntityBusiness edata = new EntityBusiness();
                SPModel sp = new SPModel();
                sp.SPName = procname;
                sp.SPDate = dtpScriptDate.Value;
                sp.CreatedDate = DateTime.Now;
                long res = edata.AddNewSP(sp);
                if (res != -1)
                {
                    LoadStoredProcedures(dtpScriptDate.Value);
                    txtspname.Clear();
                }
                else
                {
                    MessageBox.Show("Stored Procedures already exists.", "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Stored Procedures does not exists in current database.", "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtspname.Text.Trim().Length < 1)
                {
                    MessageBox.Show("Enter the name of the stored procedure", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    AddNewStoredProcedure();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void LoadStoredProcedures(DateTime date)
        {
            EntityBusiness edata = new EntityBusiness();
            var splist = edata.GetDailyStoredProcedures(date);
            dgvSP.DataSource = splist;

            var ms = AppTimeConfiguration.MainServer.ServerID;
            foreach (DataGridViewRow rw in dgvSP.Rows)
            {
                rw.Cells[5].Value = ms;
                rw.Cells[6].Value = ms;
            }
        }

        private void dgvSP_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow rw in dgvSP.Rows)
            {
                rw.Cells[1].Value = String.Format("{0}", rw.Index + 1);
            }
        }

        private void dgvSP_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            foreach (DataGridViewRow rw in dgvSP.Rows)
            {
                rw.Cells[1].Value = String.Format("{0}", rw.Index + 1);
            }
        }

        private void cbAllSP_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rw in dgvSP.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)rw.Cells[2];
                chk.Value = cbAllSP.Checked;
            }
        }

        void LoadDataBases()
        {
            EntityBusiness edata = new EntityBusiness();
            var serverlist = edata.GetServerList();
            DataGridViewComboBoxColumn colsource = (DataGridViewComboBoxColumn)(dgvSP.Columns[5]);
            colsource.DataSource = serverlist;
            colsource.DisplayMember = "Database";
            colsource.ValueMember = "ServerID";

            DataGridViewComboBoxColumn colto = (DataGridViewComboBoxColumn)(dgvSP.Columns[6]);
            colto.DataSource = serverlist;
            colto.DisplayMember = "Database";
            colto.ValueMember = "ServerID";
        }

        private void dtpScriptDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                LoadStoredProcedures(dtpScriptDate.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImport frm = new frmImport(this);
            frm.ShowDialog();
        }

        private void GenerateVersionScript()
        {
            ScriptHelper spHelper = new ScriptHelper();
            List<string> splist = new List<string>();
            foreach (DataGridViewRow rw in dgvSP.Rows)
            {
                if (Convert.ToBoolean(rw.Cells[2].Value))
                    splist.Add(rw.Cells[3].Value.ToString());
            }
            string version_script = spHelper.GenerateVersionScript(splist);
            string filename = FileHelper.GenerateDateFile(dtpScriptDate.Value);
            frmScriptViewer frm = new frmScriptViewer(version_script, filename);
            frm.Show();
        }

        private void btnVersion_Click(object sender, EventArgs e)
        {
            try
            {
                dgvSP.EndEdit();
                GenerateVersionScript();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void GenerateScript(int index)
        {
            string spname = dgvSP.Rows[index].Cells[3].Value.ToString();
            StoredProcedureBusiness spdata = new StoredProcedureBusiness();
            string spbody = spdata.GetScript(null, spname);
            frmScriptViewer frm = new frmScriptViewer(new ScriptHelper().GenerateIndividualScript(spname, spbody,false), spname);
            frm.Show();
        }

        private void dgvSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                    GenerateScript(e.RowIndex);
                else if (e.ColumnIndex == 7)
                {
                    CompareScript(e.RowIndex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                dgvSP.EndEdit();
                EntityBusiness entityBusiness = new EntityBusiness();
                foreach (DataGridViewRow rw in dgvSP.Rows)
                {
                    if (Convert.ToBoolean(rw.Cells[2].Value))
                        entityBusiness.RemoveStoredProcedure(Convert.ToInt64(rw.Cells[0].Value));
                }
                LoadStoredProcedures(dtpScriptDate.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CompareScript(int rowindex)
        {
            string spname = dgvSP.Rows[rowindex].Cells[3].Value.ToString();
            StoredProcedureBusiness spdata = new StoredProcedureBusiness();
            int sourceid = Convert.ToInt32(dgvSP.Rows[rowindex].Cells[5].Value);
            int toid = Convert.ToInt32(dgvSP.Rows[rowindex].Cells[6].Value);

            var serverlist = new EntityBusiness().GetServerList();
            var serversource = serverlist.Where(x => x.ServerID == sourceid).First();
            var serverto = serverlist.Where(x => x.ServerID == toid).First();

            string leftquery = new StoredProcedureBusiness().GetScript(serversource, spname);
            string rightquery = new StoredProcedureBusiness().GetScript(serverto, spname);

            frmCompare frm = new frmCompare(leftquery,rightquery);
            frm.Show();
        }

        private void btnIndividual_Click(object sender, EventArgs e)
        {
            List<string> splist = new List<string>();
            foreach (DataGridViewRow rw in dgvSP.Rows)
            {
                if (Convert.ToBoolean(rw.Cells[2].Value))
                    splist.Add(rw.Cells[3].Value.ToString());
            }
            IOHelper fh = new IOHelper();
            fh.SaveSingleScript(splist);
        }
    }
}
