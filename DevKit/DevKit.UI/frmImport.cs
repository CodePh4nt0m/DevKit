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

namespace DevKit.UI
{
    public partial class frmImport : Form
    {
        private frmDaily _parentForm = null;
        public frmImport(frmDaily frm)
        {
            InitializeComponent();
            dgvSP.AutoGenerateColumns = false;
            _parentForm = frm;
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

        private void frmImport_Load(object sender, EventArgs e)
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

        void LoadStoredProcedures(DateTime date)
        {
            EntityBusiness edata = new EntityBusiness();
            var splist = edata.GetDailyStoredProcedures(date);
            dgvSP.DataSource = splist;
        }

        private void cbAllSP_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rw in dgvSP.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)rw.Cells[2];
                chk.Value = cbAllSP.Checked;
            }
        }

        void ImportProcedures()
        {
            List<Int64> idlist = new List<Int64>();
            foreach (DataGridViewRow row in dgvSP.Rows)
            {
                if(Convert.ToBoolean(row.Cells[2].Value) == true)
                    idlist.Add(Convert.ToInt64(row.Cells[0].Value));
            }
            EntityBusiness entityBusiness = new EntityBusiness();
            entityBusiness.ImportStoredProcedures(idlist, _parentForm.dtpScriptDate.Value);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                ImportProcedures();
                _parentForm.LoadStoredProcedures(_parentForm.dtpScriptDate.Value);
                MessageBox.Show("Import Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
