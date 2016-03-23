namespace DevKit.UI
{
    partial class frmQueryWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQueryWindow));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnExeOn = new System.Windows.Forms.ToolStripSplitButton();
            this.openfileDiag = new System.Windows.Forms.OpenFileDialog();
            this.savefileDiag = new System.Windows.Forms.SaveFileDialog();
            this.txtQuery = new FastColoredTextBoxNS.FastColoredTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnClear = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnExeOnSelected = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnOpen,
            this.toolStripSeparator2,
            this.tsbtnSave,
            this.toolStripSeparator1,
            this.tsbtnExeOn,
            this.toolStripSeparator4,
            this.tsbtnExeOnSelected,
            this.toolStripSeparator3,
            this.tsbtnClear});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(913, 30);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsbtnOpen
            // 
            this.tsbtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnOpen.Image")));
            this.tsbtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnOpen.Name = "tsbtnOpen";
            this.tsbtnOpen.Size = new System.Drawing.Size(23, 27);
            this.tsbtnOpen.Text = "toolStripButton2";
            this.tsbtnOpen.Click += new System.EventHandler(this.tsbtnOpen_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSave.Image")));
            this.tsbtnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(23, 27);
            this.tsbtnSave.Text = "Save";
            this.tsbtnSave.Click += new System.EventHandler(this.tsbtnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // tsbtnExeOn
            // 
            this.tsbtnExeOn.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExeOn.Image")));
            this.tsbtnExeOn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnExeOn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExeOn.Name = "tsbtnExeOn";
            this.tsbtnExeOn.Size = new System.Drawing.Size(79, 27);
            this.tsbtnExeOn.Text = "Execute";
            // 
            // savefileDiag
            // 
            this.savefileDiag.DefaultExt = "sql";
            // 
            // txtQuery
            // 
            this.txtQuery.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtQuery.AutoIndentCharsPatterns = "";
            this.txtQuery.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.txtQuery.BackBrush = null;
            this.txtQuery.CharHeight = 14;
            this.txtQuery.CharWidth = 8;
            this.txtQuery.CommentPrefix = "--";
            this.txtQuery.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuery.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQuery.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtQuery.IsReplaceMode = false;
            this.txtQuery.Language = FastColoredTextBoxNS.Language.SQL;
            this.txtQuery.LeftBracket = '(';
            this.txtQuery.Location = new System.Drawing.Point(0, 30);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Paddings = new System.Windows.Forms.Padding(0);
            this.txtQuery.RightBracket = ')';
            this.txtQuery.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtQuery.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtQuery.ServiceColors")));
            this.txtQuery.Size = new System.Drawing.Size(913, 547);
            this.txtQuery.TabIndex = 3;
            this.txtQuery.Zoom = 100;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 30);
            // 
            // tsbtnClear
            // 
            this.tsbtnClear.BackColor = System.Drawing.Color.Pink;
            this.tsbtnClear.Name = "tsbtnClear";
            this.tsbtnClear.Size = new System.Drawing.Size(51, 27);
            this.tsbtnClear.Text = "Clear All";
            this.tsbtnClear.Click += new System.EventHandler(this.tsbtnClear_Click);
            // 
            // tsbtnExeOnSelected
            // 
            this.tsbtnExeOnSelected.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExeOnSelected.Image")));
            this.tsbtnExeOnSelected.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnExeOnSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExeOnSelected.Name = "tsbtnExeOnSelected";
            this.tsbtnExeOnSelected.Size = new System.Drawing.Size(98, 27);
            this.tsbtnExeOnSelected.Text = "Execute On";
            this.tsbtnExeOnSelected.ButtonClick += new System.EventHandler(this.tsbtnExeOnSelected_ButtonClick);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 30);
            // 
            // frmQueryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 577);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmQueryWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Query Console";
            this.Load += new System.EventHandler(this.frmQueryWindow_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton tsbtnExeOn;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.ToolStripButton tsbtnOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.OpenFileDialog openfileDiag;
        private System.Windows.Forms.SaveFileDialog savefileDiag;
        private FastColoredTextBoxNS.FastColoredTextBox txtQuery;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel tsbtnClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSplitButton tsbtnExeOnSelected;
    }
}