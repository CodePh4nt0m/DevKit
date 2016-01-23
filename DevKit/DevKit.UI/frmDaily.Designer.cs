﻿namespace DevKit.UI
{
    partial class frmDaily
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDaily));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtspname = new System.Windows.Forms.TextBox();
            this.cbAllSP = new System.Windows.Forms.CheckBox();
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dtpScriptDate = new System.Windows.Forms.DateTimePicker();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateTFS = new System.Windows.Forms.Button();
            this.btnIndividual = new System.Windows.Forms.Button();
            this.btnVersion = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnImport = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(6, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(872, 373);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtspname);
            this.tabPage1.Controls.Add(this.cbAllSP);
            this.tabPage1.Controls.Add(this.dgvSP);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.dtpScriptDate);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(864, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stored Procedures";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtspname
            // 
            this.txtspname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtspname.Location = new System.Drawing.Point(9, 13);
            this.txtspname.Name = "txtspname";
            this.txtspname.Size = new System.Drawing.Size(403, 20);
            this.txtspname.TabIndex = 13;
            // 
            // cbAllSP
            // 
            this.cbAllSP.AutoSize = true;
            this.cbAllSP.Location = new System.Drawing.Point(49, 49);
            this.cbAllSP.Name = "cbAllSP";
            this.cbAllSP.Size = new System.Drawing.Size(15, 14);
            this.cbAllSP.TabIndex = 12;
            this.cbAllSP.UseVisualStyleBackColor = true;
            this.cbAllSP.CheckedChanged += new System.EventHandler(this.cbAllSP_CheckedChanged);
            // 
            // dgvSP
            // 
            this.dgvSP.AllowUserToAddRows = false;
            this.dgvSP.AllowUserToDeleteRows = false;
            this.dgvSP.AllowUserToOrderColumns = true;
            this.dgvSP.AllowUserToResizeColumns = false;
            this.dgvSP.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSP.ColumnHeadersHeight = 28;
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvSP.Location = new System.Drawing.Point(9, 40);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.RowHeadersVisible = false;
            this.dgvSP.Size = new System.Drawing.Size(849, 301);
            this.dgvSP.TabIndex = 11;
            this.dgvSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSP_CellContentClick);
            this.dgvSP.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvSP_RowsAdded);
            this.dgvSP.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvSP_RowsRemoved);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SPID";
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 30;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.Width = 30;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SPName";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column4.HeaderText = "SP Name";
            this.Column4.Name = "Column4";
            this.Column4.Width = 270;
            // 
            // Column5
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column5.HeaderText = "Script";
            this.Column5.Name = "Column5";
            this.Column5.Text = "Generate";
            this.Column5.UseColumnTextForButtonValue = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Source";
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "To";
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column8.HeaderText = "Compare";
            this.Column8.Name = "Column8";
            this.Column8.Text = "Compare";
            this.Column8.UseColumnTextForButtonValue = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(418, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(802, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(32, 21);
            this.button7.TabIndex = 9;
            this.button7.Text = ">>";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // dtpScriptDate
            // 
            this.dtpScriptDate.Location = new System.Drawing.Point(596, 13);
            this.dtpScriptDate.Name = "dtpScriptDate";
            this.dtpScriptDate.Size = new System.Drawing.Size(200, 20);
            this.dtpScriptDate.TabIndex = 1;
            this.dtpScriptDate.ValueChanged += new System.EventHandler(this.dtpScriptDate_ValueChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(558, 13);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 21);
            this.button6.TabIndex = 8;
            this.button6.Text = "<<";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateTFS);
            this.groupBox1.Controls.Add(this.btnIndividual);
            this.groupBox1.Controls.Add(this.btnVersion);
            this.groupBox1.Location = new System.Drawing.Point(6, 418);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 53);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commands";
            // 
            // btnUpdateTFS
            // 
            this.btnUpdateTFS.Location = new System.Drawing.Point(222, 19);
            this.btnUpdateTFS.Name = "btnUpdateTFS";
            this.btnUpdateTFS.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateTFS.TabIndex = 7;
            this.btnUpdateTFS.Text = "Update TFS";
            this.btnUpdateTFS.UseVisualStyleBackColor = true;
            this.btnUpdateTFS.Click += new System.EventHandler(this.btnUpdateTFS_Click);
            // 
            // btnIndividual
            // 
            this.btnIndividual.Location = new System.Drawing.Point(116, 19);
            this.btnIndividual.Name = "btnIndividual";
            this.btnIndividual.Size = new System.Drawing.Size(100, 23);
            this.btnIndividual.TabIndex = 6;
            this.btnIndividual.Text = "Save Individual";
            this.btnIndividual.UseVisualStyleBackColor = true;
            this.btnIndividual.Click += new System.EventHandler(this.btnIndividual_Click);
            // 
            // btnVersion
            // 
            this.btnVersion.Location = new System.Drawing.Point(10, 19);
            this.btnVersion.Name = "btnVersion";
            this.btnVersion.Size = new System.Drawing.Size(100, 23);
            this.btnVersion.TabIndex = 5;
            this.btnVersion.Text = "Version Script";
            this.btnVersion.UseVisualStyleBackColor = true;
            this.btnVersion.Click += new System.EventHandler(this.btnVersion_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnImport,
            this.toolStripSeparator1,
            this.tsbtnRemove});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(888, 30);
            this.toolStrip1.TabIndex = 4;
            // 
            // tsbtnRemove
            // 
            this.tsbtnRemove.Image = global::DevKit.UI.Properties.Resources.Clearallrequests_8816;
            this.tsbtnRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRemove.Name = "tsbtnRemove";
            this.tsbtnRemove.Size = new System.Drawing.Size(70, 27);
            this.tsbtnRemove.Text = "Remove";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // tsbtnImport
            // 
            this.tsbtnImport.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnImport.Image")));
            this.tsbtnImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnImport.Name = "tsbtnImport";
            this.tsbtnImport.Size = new System.Drawing.Size(63, 27);
            this.tsbtnImport.Text = "Import";
            this.tsbtnImport.Click += new System.EventHandler(this.tsbtnImport_Click);
            // 
            // frmDaily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 477);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmDaily";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDaily_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdateTFS;
        private System.Windows.Forms.Button btnIndividual;
        private System.Windows.Forms.Button btnVersion;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.CheckBox cbAllSP;
        public System.Windows.Forms.DateTimePicker dtpScriptDate;
        private System.Windows.Forms.TextBox txtspname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column6;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnRemove;
        private System.Windows.Forms.ToolStripButton tsbtnImport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}