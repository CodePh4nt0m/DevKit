namespace DevKit.UI
{
    partial class frmDBObject
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvallTables = new System.Windows.Forms.DataGridView();
            this.txtname = new System.Windows.Forms.TextBox();
            this.dgvtblSelected = new System.Windows.Forms.DataGridView();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsojb = new System.Windows.Forms.ToolStrip();
            this.tscomserver = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvallTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtblSelected)).BeginInit();
            this.tsojb.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 414);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRemove);
            this.tabPage2.Controls.Add(this.btnAddTable);
            this.tabPage2.Controls.Add(this.dgvtblSelected);
            this.tabPage2.Controls.Add(this.txtname);
            this.tabPage2.Controls.Add(this.dgvallTables);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(772, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tables";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvallTables
            // 
            this.dgvallTables.AllowUserToAddRows = false;
            this.dgvallTables.AllowUserToDeleteRows = false;
            this.dgvallTables.AllowUserToOrderColumns = true;
            this.dgvallTables.AllowUserToResizeColumns = false;
            this.dgvallTables.AllowUserToResizeRows = false;
            this.dgvallTables.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvallTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvallTables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvallTables.Location = new System.Drawing.Point(6, 42);
            this.dgvallTables.Name = "dgvallTables";
            this.dgvallTables.RowHeadersVisible = false;
            this.dgvallTables.Size = new System.Drawing.Size(370, 300);
            this.dgvallTables.TabIndex = 0;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(7, 16);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(369, 20);
            this.txtname.TabIndex = 1;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // dgvtblSelected
            // 
            this.dgvtblSelected.AllowUserToAddRows = false;
            this.dgvtblSelected.AllowUserToDeleteRows = false;
            this.dgvtblSelected.AllowUserToOrderColumns = true;
            this.dgvtblSelected.AllowUserToResizeColumns = false;
            this.dgvtblSelected.AllowUserToResizeRows = false;
            this.dgvtblSelected.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvtblSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtblSelected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvtblSelected.Location = new System.Drawing.Point(394, 42);
            this.dgvtblSelected.Name = "dgvtblSelected";
            this.dgvtblSelected.RowHeadersVisible = false;
            this.dgvtblSelected.Size = new System.Drawing.Size(369, 300);
            this.dgvtblSelected.TabIndex = 2;
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(252, 348);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(124, 23);
            this.btnAddTable.TabIndex = 3;
            this.btnAddTable.Text = "Add Selected";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(639, 348);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(124, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TableId";
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "bSelected";
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TableName";
            this.Column3.HeaderText = "Table Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 300;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TableId";
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "bSelected";
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TableName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Table Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // tsojb
            // 
            this.tsojb.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsojb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tscomserver});
            this.tsojb.Location = new System.Drawing.Point(0, 0);
            this.tsojb.Name = "tsojb";
            this.tsojb.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsojb.Size = new System.Drawing.Size(798, 25);
            this.tsojb.TabIndex = 1;
            // 
            // tscomserver
            // 
            this.tscomserver.Name = "tscomserver";
            this.tscomserver.Size = new System.Drawing.Size(180, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel1.Text = "Database";
            // 
            // frmDBObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 470);
            this.Controls.Add(this.tsojb);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDBObject";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Object";
            this.Load += new System.EventHandler(this.frmDBObject_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvallTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtblSelected)).EndInit();
            this.tsojb.ResumeLayout(false);
            this.tsojb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvallTables;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.DataGridView dgvtblSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ToolStrip tsojb;
        private System.Windows.Forms.ToolStripComboBox tscomserver;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}