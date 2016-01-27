namespace DevKit.UI
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToobar = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmbDatabase = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.smbtnDatabases = new System.Windows.Forms.ToolStripButton();
            this.smbtnSQL = new System.Windows.Forms.ToolStripButton();
            this.smbtnConsole = new System.Windows.Forms.ToolStripButton();
            this.smbtnFolder = new System.Windows.Forms.ToolStripButton();
            this.smbtnObject = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.mainToobar.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 395);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(767, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(767, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.helpToolStripMenuItem.Text = "About";
            // 
            // mainToobar
            // 
            this.mainToobar.AutoSize = false;
            this.mainToobar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainToobar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cmbDatabase,
            this.toolStripSeparator1});
            this.mainToobar.Location = new System.Drawing.Point(0, 24);
            this.mainToobar.Name = "mainToobar";
            this.mainToobar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mainToobar.Size = new System.Drawing.Size(767, 30);
            this.mainToobar.TabIndex = 5;
            this.mainToobar.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(55, 27);
            this.toolStripLabel1.Text = "Database";
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(150, 30);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smbtnDatabases,
            this.smbtnSQL,
            this.smbtnConsole,
            this.smbtnFolder,
            this.smbtnObject});
            this.toolStrip2.Location = new System.Drawing.Point(0, 54);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(50, 341);
            this.toolStrip2.TabIndex = 6;
            // 
            // smbtnDatabases
            // 
            this.smbtnDatabases.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.smbtnDatabases.Image = ((System.Drawing.Image)(resources.GetObject("smbtnDatabases.Image")));
            this.smbtnDatabases.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.smbtnDatabases.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.smbtnDatabases.Name = "smbtnDatabases";
            this.smbtnDatabases.Size = new System.Drawing.Size(48, 39);
            this.smbtnDatabases.Text = "Database";
            this.smbtnDatabases.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.smbtnDatabases.Click += new System.EventHandler(this.smbtnDatabases_Click);
            // 
            // smbtnSQL
            // 
            this.smbtnSQL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.smbtnSQL.Image = ((System.Drawing.Image)(resources.GetObject("smbtnSQL.Image")));
            this.smbtnSQL.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.smbtnSQL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.smbtnSQL.Name = "smbtnSQL";
            this.smbtnSQL.Size = new System.Drawing.Size(48, 39);
            this.smbtnSQL.Text = "SQL";
            this.smbtnSQL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.smbtnSQL.Click += new System.EventHandler(this.smbtnSQL_Click);
            // 
            // smbtnConsole
            // 
            this.smbtnConsole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.smbtnConsole.Image = ((System.Drawing.Image)(resources.GetObject("smbtnConsole.Image")));
            this.smbtnConsole.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.smbtnConsole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.smbtnConsole.Name = "smbtnConsole";
            this.smbtnConsole.Size = new System.Drawing.Size(48, 39);
            this.smbtnConsole.Text = "Console";
            this.smbtnConsole.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.smbtnConsole.Click += new System.EventHandler(this.smbtnConsole_Click);
            // 
            // smbtnFolder
            // 
            this.smbtnFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.smbtnFolder.Image = ((System.Drawing.Image)(resources.GetObject("smbtnFolder.Image")));
            this.smbtnFolder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.smbtnFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.smbtnFolder.Name = "smbtnFolder";
            this.smbtnFolder.Size = new System.Drawing.Size(48, 39);
            this.smbtnFolder.Text = "Console";
            this.smbtnFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.smbtnFolder.Click += new System.EventHandler(this.smbtnFolder_Click);
            // 
            // smbtnObject
            // 
            this.smbtnObject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.smbtnObject.Image = global::DevKit.UI.Properties.Resources.table;
            this.smbtnObject.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.smbtnObject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.smbtnObject.Name = "smbtnObject";
            this.smbtnObject.Size = new System.Drawing.Size(48, 39);
            this.smbtnObject.Text = "Console";
            this.smbtnObject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.smbtnObject.Click += new System.EventHandler(this.smbtnObject_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 417);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.mainToobar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHome";
            this.Text = "SQL Plus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainToobar.ResumeLayout(false);
            this.mainToobar.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip mainToobar;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton smbtnConsole;
        private System.Windows.Forms.ToolStripButton smbtnDatabases;
        private System.Windows.Forms.ToolStripButton smbtnSQL;
        private System.Windows.Forms.ToolStripButton smbtnFolder;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cmbDatabase;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton smbtnObject;
    }
}