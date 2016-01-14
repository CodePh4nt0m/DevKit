using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevKit.Common;

namespace DevKit.UI
{
    public partial class frmSettings : Form
    {
        ConfigurationHelper config = new ConfigurationHelper();
        public frmSettings()
        {
            InitializeComponent();
            treeSettings.ExpandAll();
            this.ActiveControl = tabSettings;
        }

        private void treeSettings_Click(object sender, EventArgs e)
        {
        }

        private void treeSettings_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (treeSettings.SelectedNode.Index == 0)
                {
                    tabSettings.SelectedTab = tabProject;
                    LoadProjectData();
                }
                else if (treeSettings.SelectedNode.Index == 1)
                {
                    tabSettings.SelectedTab = tabTeam;
                    LoadTFSData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBrowseSP_Click(object sender, EventArgs e)
        {
            var res = dialogFolder.ShowDialog();
            if (res == DialogResult.OK)
            {
                txt_path_local_sp.Text = dialogFolder.SelectedPath;
            }
        }

        private void btnBrowseVersion_Click(object sender, EventArgs e)
        {
            var res = dialogFolder.ShowDialog();
            if (res == DialogResult.OK)
            {
                txt_path_local_version.Text = dialogFolder.SelectedPath;
            }
        }

        void LoadProjectData()
        {
            string sp_local = config.GetConfigurationValue("path_local_sp");
            string sp_tfs = config.GetConfigurationValue("path_tfs_sp");
            string version_local = config.GetConfigurationValue("path_local_version");
            string version_tfs = config.GetConfigurationValue("path_tfs_version");

            txt_path_local_sp.Text = sp_local;
            txt_path_tfs_sp.Text = sp_tfs;
            txt_path_local_version.Text = version_local;
            txt_path_tfs_version.Text = version_tfs;
        }

        void LoadTFSData()
        {
            string tfs_username = config.GetConfigurationValue("tfs_username");
            string tfs_password = config.GetConfigurationValue("tfs_password");

            txtusername.Text = tfs_username;
            txtPassword.Text = tfs_password;
        }

        private void btnSaveProject_Click(object sender, EventArgs e)
        {
            try
            {
                SaveProjectDetails();
                MessageBox.Show("Details saved successfuly", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void SaveProjectDetails()
        {
            string sp_local = txt_path_local_sp.Text.Trim();
            string sp_tfs = txt_path_tfs_sp.Text.Trim();
            string version_local = txt_path_local_version.Text.Trim();
            string version_tfs = txt_path_tfs_version.Text.Trim();

            config.AddConfiguration("path_local_sp",sp_local);
            config.AddConfiguration("path_tfs_sp", sp_tfs);
            config.AddConfiguration("path_local_version", version_local);
            config.AddConfiguration("path_tfs_version", version_tfs);
        }

        void SaveTeamDetails()
        {
            string username = txtusername.Text.Trim();
            string password = txtPassword.Text.Trim();

            config.AddConfiguration("tfs_username", username);
            config.AddConfiguration("tfs_password", password);
        }

        private void btnSaveTFS_Click(object sender, EventArgs e)
        {
            try
            {
                SaveTeamDetails();
                MessageBox.Show("Details saved successfuly", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            LoadProjectData();
        }
    }
}
