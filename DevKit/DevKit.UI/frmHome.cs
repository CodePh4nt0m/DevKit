using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            bool exits = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmDaily))
                {
                    form.Activate();
                    form.BringToFront();
                    form.WindowState = FormWindowState.Normal;
                    exits = true;
                    break;
                }
            }

            if (!exits)
            {
                frmDaily frm = new frmDaily();
                frm.MdiParent = this;
                frm.Show();
            }
            
        }

        private void smbtnDatabases_Click(object sender, EventArgs e)
        {
            bool exits = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmDatabases))
                {
                    form.Activate();
                    form.BringToFront();
                    form.WindowState = FormWindowState.Normal;
                    exits = true;
                    break;
                }
            }

            if (!exits)
            {
                frmDatabases frm = new frmDatabases();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        public void LoadDatabases()
        {
            cmbDatabase.SelectedIndexChanged -= cmbDatabase_SelectedIndexChanged;

            EntityBusiness entityBusiness = new EntityBusiness();
            var dbs = entityBusiness.GetServerList();
            cmbDatabase.ComboBox.DisplayMember = "Database";
            cmbDatabase.ComboBox.ValueMember = "ServerID";
            cmbDatabase.ComboBox.DataSource = dbs;
            string mainserver = new ConfigurationHelper().GetConfigurationValue("mainserver");
            if (mainserver != "0")
                cmbDatabase.ComboBox.SelectedValue = Convert.ToInt32(mainserver);
            else
                cmbDatabase.ComboBox.SelectedIndex = -1;

            cmbDatabase.SelectedIndexChanged += cmbDatabase_SelectedIndexChanged;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDatabases();
                string serverid = new ConfigurationHelper().GetConfigurationValue("mainserver");
                EntityBusiness data = new EntityBusiness();
                var servers = data.GetServerList();
                var server = servers.Where(x => x.ServerID == Convert.ToInt32(serverid)).FirstOrDefault();
                if (server != null)
                {
                    AppTimeConfiguration.MainServer = server;
                }
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
                        new ConfigurationHelper().AddConfiguration("mainserver",id.ToString());
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

        private void smbtnFolder_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\GeneratedScripts";
            Process.Start(path);
        }
    }
}
