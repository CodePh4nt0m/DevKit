namespace DevKit.UI
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Project Settings");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Team Foundation Server");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Settings", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeSettings = new System.Windows.Forms.TreeView();
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tabProject = new System.Windows.Forms.TabPage();
            this.btnSaveProject = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_path_tfs_version = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_path_tfs_sp = new System.Windows.Forms.TextBox();
            this.btnBrowseVersion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_path_local_version = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowseSP = new System.Windows.Forms.Button();
            this.txt_path_local_sp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabTeam = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSaveTFS = new System.Windows.Forms.Button();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dialogFolder = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabProject.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabTeam.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeSettings);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabSettings);
            this.splitContainer1.Size = new System.Drawing.Size(704, 402);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeSettings
            // 
            this.treeSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeSettings.Location = new System.Drawing.Point(0, 0);
            this.treeSettings.Name = "treeSettings";
            treeNode4.Name = "nodeProject";
            treeNode4.Text = "Project Settings";
            treeNode5.Name = "nodeTFS";
            treeNode5.Text = "Team Foundation Server";
            treeNode6.Name = "nodeSettings";
            treeNode6.Text = "Settings";
            this.treeSettings.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeSettings.Size = new System.Drawing.Size(230, 402);
            this.treeSettings.TabIndex = 0;
            this.treeSettings.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeSettings_AfterSelect);
            this.treeSettings.Click += new System.EventHandler(this.treeSettings_Click);
            // 
            // tabSettings
            // 
            this.tabSettings.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabSettings.Controls.Add(this.tabProject);
            this.tabSettings.Controls.Add(this.tabTeam);
            this.tabSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSettings.ItemSize = new System.Drawing.Size(0, 1);
            this.tabSettings.Location = new System.Drawing.Point(0, 0);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(470, 402);
            this.tabSettings.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabSettings.TabIndex = 0;
            // 
            // tabProject
            // 
            this.tabProject.BackColor = System.Drawing.SystemColors.Window;
            this.tabProject.Controls.Add(this.btnSaveProject);
            this.tabProject.Controls.Add(this.groupBox1);
            this.tabProject.Location = new System.Drawing.Point(4, 5);
            this.tabProject.Name = "tabProject";
            this.tabProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabProject.Size = new System.Drawing.Size(462, 393);
            this.tabProject.TabIndex = 0;
            this.tabProject.Text = "tabPage1";
            // 
            // btnSaveProject
            // 
            this.btnSaveProject.Location = new System.Drawing.Point(348, 259);
            this.btnSaveProject.Name = "btnSaveProject";
            this.btnSaveProject.Size = new System.Drawing.Size(108, 23);
            this.btnSaveProject.TabIndex = 1;
            this.btnSaveProject.Text = "Save";
            this.btnSaveProject.UseVisualStyleBackColor = true;
            this.btnSaveProject.Click += new System.EventHandler(this.btnSaveProject_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_path_tfs_version);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_path_tfs_sp);
            this.groupBox1.Controls.Add(this.btnBrowseVersion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_path_local_version);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBrowseSP);
            this.groupBox1.Controls.Add(this.txt_path_local_sp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project Folders";
            // 
            // txt_path_tfs_version
            // 
            this.txt_path_tfs_version.Location = new System.Drawing.Point(10, 198);
            this.txt_path_tfs_version.Name = "txt_path_tfs_version";
            this.txt_path_tfs_version.Size = new System.Drawing.Size(434, 20);
            this.txt_path_tfs_version.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TFS Path";
            // 
            // txt_path_tfs_sp
            // 
            this.txt_path_tfs_sp.Location = new System.Drawing.Point(10, 86);
            this.txt_path_tfs_sp.Name = "txt_path_tfs_sp";
            this.txt_path_tfs_sp.Size = new System.Drawing.Size(433, 20);
            this.txt_path_tfs_sp.TabIndex = 1;
            // 
            // btnBrowseVersion
            // 
            this.btnBrowseVersion.Location = new System.Drawing.Point(367, 154);
            this.btnBrowseVersion.Name = "btnBrowseVersion";
            this.btnBrowseVersion.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseVersion.TabIndex = 4;
            this.btnBrowseVersion.Text = "Browse";
            this.btnBrowseVersion.UseVisualStyleBackColor = true;
            this.btnBrowseVersion.Click += new System.EventHandler(this.btnBrowseVersion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "TFS Path";
            // 
            // txt_path_local_version
            // 
            this.txt_path_local_version.Location = new System.Drawing.Point(9, 156);
            this.txt_path_local_version.Name = "txt_path_local_version";
            this.txt_path_local_version.Size = new System.Drawing.Size(352, 20);
            this.txt_path_local_version.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "\"Version Scripts\" path";
            // 
            // btnBrowseSP
            // 
            this.btnBrowseSP.Location = new System.Drawing.Point(368, 42);
            this.btnBrowseSP.Name = "btnBrowseSP";
            this.btnBrowseSP.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSP.TabIndex = 1;
            this.btnBrowseSP.Text = "Browse";
            this.btnBrowseSP.UseVisualStyleBackColor = true;
            this.btnBrowseSP.Click += new System.EventHandler(this.btnBrowseSP_Click);
            // 
            // txt_path_local_sp
            // 
            this.txt_path_local_sp.Location = new System.Drawing.Point(10, 44);
            this.txt_path_local_sp.Name = "txt_path_local_sp";
            this.txt_path_local_sp.Size = new System.Drawing.Size(352, 20);
            this.txt_path_local_sp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "\"Stored Procedures\" path";
            // 
            // tabTeam
            // 
            this.tabTeam.BackColor = System.Drawing.SystemColors.Window;
            this.tabTeam.Controls.Add(this.groupBox2);
            this.tabTeam.Location = new System.Drawing.Point(4, 5);
            this.tabTeam.Name = "tabTeam";
            this.tabTeam.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeam.Size = new System.Drawing.Size(462, 393);
            this.tabTeam.TabIndex = 1;
            this.tabTeam.Text = "tabPage2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnSaveTFS);
            this.groupBox2.Controls.Add(this.txtusername);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 129);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Team Foundation Server Account";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(114, 55);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(205, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Password";
            // 
            // btnSaveTFS
            // 
            this.btnSaveTFS.Location = new System.Drawing.Point(222, 90);
            this.btnSaveTFS.Name = "btnSaveTFS";
            this.btnSaveTFS.Size = new System.Drawing.Size(97, 23);
            this.btnSaveTFS.TabIndex = 2;
            this.btnSaveTFS.Text = "Save Details";
            this.btnSaveTFS.UseVisualStyleBackColor = true;
            this.btnSaveTFS.Click += new System.EventHandler(this.btnSaveTFS_Click);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(114, 30);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(205, 20);
            this.txtusername.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Username";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 402);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabProject.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabTeam.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeSettings;
        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage tabProject;
        private System.Windows.Forms.TabPage tabTeam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowseVersion;
        private System.Windows.Forms.TextBox txt_path_local_version;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowseSP;
        private System.Windows.Forms.TextBox txt_path_local_sp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog dialogFolder;
        private System.Windows.Forms.TextBox txt_path_tfs_version;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_path_tfs_sp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSaveTFS;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveProject;
    }
}