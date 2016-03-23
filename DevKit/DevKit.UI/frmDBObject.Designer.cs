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
            this.btnDataGenerate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbStIfNotExists = new System.Windows.Forms.RadioButton();
            this.rbStCreate = new System.Windows.Forms.RadioButton();
            this.rbStDropnCreate = new System.Windows.Forms.RadioButton();
            this.btnStuctGenerate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.dgvtblSelected = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtname = new System.Windows.Forms.TextBox();
            this.dgvallTables = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsojb = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tscomserver = new System.Windows.Forms.ToolStripComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtblSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvallTables)).BeginInit();
            this.tsojb.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 524);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDataGenerate);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnStuctGenerate);
            this.tabPage2.Controls.Add(this.btnRemove);
            this.tabPage2.Controls.Add(this.btnAddTable);
            this.tabPage2.Controls.Add(this.dgvtblSelected);
            this.tabPage2.Controls.Add(this.txtname);
            this.tabPage2.Controls.Add(this.dgvallTables);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(772, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tables";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDataGenerate
            // 
            this.btnDataGenerate.Location = new System.Drawing.Point(639, 442);
            this.btnDataGenerate.Name = "btnDataGenerate";
            this.btnDataGenerate.Size = new System.Drawing.Size(124, 23);
            this.btnDataGenerate.TabIndex = 11;
            this.btnDataGenerate.Text = "Generate";
            this.btnDataGenerate.UseVisualStyleBackColor = true;
            this.btnDataGenerate.Click += new System.EventHandler(this.btnDataGenerate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Location = new System.Drawing.Point(602, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 117);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(65, 17);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "INSERT";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 42);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(69, 17);
            this.radioButton5.TabIndex = 8;
            this.radioButton5.Text = "UPDATE";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 65);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(84, 17);
            this.radioButton6.TabIndex = 6;
            this.radioButton6.Text = "TRUNCATE";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbStIfNotExists);
            this.groupBox1.Controls.Add(this.rbStCreate);
            this.groupBox1.Controls.Add(this.rbStDropnCreate);
            this.groupBox1.Location = new System.Drawing.Point(393, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Structure";
            // 
            // rbStIfNotExists
            // 
            this.rbStIfNotExists.AutoSize = true;
            this.rbStIfNotExists.Checked = true;
            this.rbStIfNotExists.Location = new System.Drawing.Point(6, 19);
            this.rbStIfNotExists.Name = "rbStIfNotExists";
            this.rbStIfNotExists.Size = new System.Drawing.Size(101, 17);
            this.rbStIfNotExists.TabIndex = 9;
            this.rbStIfNotExists.TabStop = true;
            this.rbStIfNotExists.Text = "IF NOT EXISTS";
            this.rbStIfNotExists.UseVisualStyleBackColor = true;
            // 
            // rbStCreate
            // 
            this.rbStCreate.AutoSize = true;
            this.rbStCreate.Location = new System.Drawing.Point(6, 65);
            this.rbStCreate.Name = "rbStCreate";
            this.rbStCreate.Size = new System.Drawing.Size(68, 17);
            this.rbStCreate.TabIndex = 8;
            this.rbStCreate.Text = "CREATE";
            this.rbStCreate.UseVisualStyleBackColor = true;
            // 
            // rbStDropnCreate
            // 
            this.rbStDropnCreate.AutoSize = true;
            this.rbStDropnCreate.Location = new System.Drawing.Point(6, 42);
            this.rbStDropnCreate.Name = "rbStDropnCreate";
            this.rbStDropnCreate.Size = new System.Drawing.Size(128, 17);
            this.rbStDropnCreate.TabIndex = 6;
            this.rbStDropnCreate.Text = "DROP AND CREATE";
            this.rbStDropnCreate.UseVisualStyleBackColor = true;
            // 
            // btnStuctGenerate
            // 
            this.btnStuctGenerate.Location = new System.Drawing.Point(394, 425);
            this.btnStuctGenerate.Name = "btnStuctGenerate";
            this.btnStuctGenerate.Size = new System.Drawing.Size(124, 23);
            this.btnStuctGenerate.TabIndex = 5;
            this.btnStuctGenerate.Text = "Generate";
            this.btnStuctGenerate.UseVisualStyleBackColor = true;
            this.btnStuctGenerate.Click += new System.EventHandler(this.btnStuctGenerate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(639, 14);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(124, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(252, 469);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(124, 23);
            this.btnAddTable.TabIndex = 3;
            this.btnAddTable.Text = "Add Selected";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
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
            this.dgvtblSelected.Size = new System.Drawing.Size(369, 264);
            this.dgvtblSelected.TabIndex = 2;
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
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(7, 16);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(369, 20);
            this.txtname.TabIndex = 1;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
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
            this.dgvallTables.Size = new System.Drawing.Size(370, 421);
            this.dgvallTables.TabIndex = 0;
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
            // tsojb
            // 
            this.tsojb.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsojb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tscomserver});
            this.tsojb.Location = new System.Drawing.Point(0, 0);
            this.tsojb.Name = "tsojb";
            this.tsojb.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsojb.Size = new System.Drawing.Size(792, 25);
            this.tsojb.TabIndex = 1;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel1.Text = "Database";
            // 
            // tscomserver
            // 
            this.tscomserver.Name = "tscomserver";
            this.tscomserver.Size = new System.Drawing.Size(180, 25);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 88);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(136, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.Text = "TRUNCATE n INSERT";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // frmDBObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 557);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtblSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvallTables)).EndInit();
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
        private System.Windows.Forms.Button btnStuctGenerate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbStCreate;
        private System.Windows.Forms.RadioButton rbStDropnCreate;
        private System.Windows.Forms.Button btnDataGenerate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton rbStIfNotExists;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}