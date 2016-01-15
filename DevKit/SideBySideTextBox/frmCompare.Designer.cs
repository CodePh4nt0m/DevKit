namespace SideBySideTextBox
{
    partial class frmCompare
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
            this.comparebox = new SideBySideTextBox.SideBySideRichTextBox();
            this.SuspendLayout();
            // 
            // comparebox
            // 
            this.comparebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comparebox.LeftText = "";
            this.comparebox.Location = new System.Drawing.Point(0, 0);
            this.comparebox.Name = "comparebox";
            this.comparebox.RightText = "";
            this.comparebox.Size = new System.Drawing.Size(819, 464);
            this.comparebox.TabIndex = 0;
            // 
            // frmCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 464);
            this.Controls.Add(this.comparebox);
            this.Name = "frmCompare";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private SideBySideRichTextBox comparebox;
    }
}