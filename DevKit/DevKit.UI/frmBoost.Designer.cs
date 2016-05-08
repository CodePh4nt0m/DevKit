namespace DevKit.UI
{
    partial class frmBoost
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
            this.tsojb = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tscomserver = new System.Windows.Forms.ToolStripComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsearchscript = new System.Windows.Forms.Button();
            this.txtSearchSpName = new System.Windows.Forms.TextBox();
            this.tsojb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.tsojb.Size = new System.Drawing.Size(819, 25);
            this.tsojb.TabIndex = 2;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel1.Text = "Database";
            // 
            // tscomserver
            // 
            this.tscomserver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscomserver.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tscomserver.Name = "tscomserver";
            this.tscomserver.Size = new System.Drawing.Size(180, 25);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchSpName);
            this.groupBox1.Controls.Add(this.btnsearchscript);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 59);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scripts";
            // 
            // btnsearchscript
            // 
            this.btnsearchscript.Location = new System.Drawing.Point(297, 12);
            this.btnsearchscript.Name = "btnsearchscript";
            this.btnsearchscript.Size = new System.Drawing.Size(96, 39);
            this.btnsearchscript.TabIndex = 0;
            this.btnsearchscript.Text = "Genereate Search SP";
            this.btnsearchscript.UseVisualStyleBackColor = true;
            this.btnsearchscript.Click += new System.EventHandler(this.btnsearchscript_Click);
            // 
            // txtSearchSpName
            // 
            this.txtSearchSpName.Location = new System.Drawing.Point(7, 21);
            this.txtSearchSpName.Name = "txtSearchSpName";
            this.txtSearchSpName.Size = new System.Drawing.Size(284, 20);
            this.txtSearchSpName.TabIndex = 1;
            // 
            // frmBoost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 433);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tsojb);
            this.Name = "frmBoost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boost";
            this.tsojb.ResumeLayout(false);
            this.tsojb.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsojb;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox tscomserver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearchSpName;
        private System.Windows.Forms.Button btnsearchscript;
    }
}