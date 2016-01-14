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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void smbtnConsole_Click(object sender, EventArgs e)
        {
            frmQueryWindow frm = new frmQueryWindow();
            frm.Show();
        }

        private void smbtnSQL_Click(object sender, EventArgs e)
        {
            frmDaily frm = new frmDaily();
            frm.Show();
        }

        private void smbtnDatabases_Click(object sender, EventArgs e)
        {
            frmDatabases frm = new frmDatabases();
            frm.MdiParent = this;
            frm.Show();
        }

        public void LoadDatabases()
        {
            EntityBusiness entityBusiness = new EntityBusiness();
            var dbs = entityBusiness.GetServerList();
            cmbDatabase.ComboBox.DisplayMember = "Database";
            cmbDatabase.ComboBox.ValueMember = "ServerID";
            cmbDatabase.ComboBox.DataSource = dbs;
            cmbDatabase.SelectedIndex = -1;
        }

        private void frmHome_Load(object sender, EventArgs e)
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

        private void cmbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbDatabase.ComboBox.Items.Count > 0)
                {
                    if (cmbDatabase.ComboBox.SelectedIndex != -1)
                    {
                        int id = Convert.ToInt32(cmbDatabase.ComboBox.SelectedValue);
                        EntityBusiness data= new EntityBusiness();
                        var servers = data.GetServerList();
                        AppTimeConfiguration.MainServer = servers.Where(x => x.ServerID == id).FirstOrDefault();
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmTest frm = new frmTest();
            frm.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            frm.ShowDialog();
        }
    }
}
