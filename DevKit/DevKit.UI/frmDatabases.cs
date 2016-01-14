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

namespace DevKit.UI
{
    public partial class frmDatabases : Form
    {
        public frmDatabases()
        {
            InitializeComponent();
            dgvDatabases.AutoGenerateColumns = false;
        }

        private void tsbtnNew_Click(object sender, EventArgs e)
        {
            frmNewDatabase frm = new frmNewDatabase(this);
            frm.ShowDialog();
        }

        private void frmDatabases_Load(object sender, EventArgs e)
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

        public void LoadDatabases()
        {
            EntityBusiness business = new EntityBusiness();
            var databases = business.GetServerList();
            dgvDatabases.DataSource = databases;
            dgvDatabases.ClearSelection();
        }

        private void dgvDatabases_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            AddRowNumbers();
        }

        private void dgvDatabases_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            AddRowNumbers();
        }

        void AddRowNumbers()
        {
            foreach (DataGridViewRow rw in dgvDatabases.Rows)
            {
                rw.Cells[0].Value = String.Format("{0}", rw.Index + 1);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDatabases.SelectedRows.Count > 0)
                {
                    RemoveDatabase();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void RemoveDatabase()
        {
            EntityBusiness entityBusiness = new EntityBusiness();
            int id = Convert.ToInt32(dgvDatabases.SelectedRows[0].Cells[1].Value);
            entityBusiness.RemoveServer(id);
            LoadDatabases();
        }

        void RemoveAll()
        {
            EntityBusiness entityBusiness = new EntityBusiness();
            entityBusiness.ClearAllDatabases();
            LoadDatabases();
        }
    }
}
