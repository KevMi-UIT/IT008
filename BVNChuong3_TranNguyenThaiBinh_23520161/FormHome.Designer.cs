namespace BVNChuong3_TranNguyenThaiBinh_23520161
{
    partial class FormHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.PhanSoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SoPhucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PhanSoToolStripMenuItem,
            this.SoPhucToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // PhanSoToolStripMenuItem
            // 
            this.PhanSoToolStripMenuItem.Name = "PhanSoToolStripMenuItem";
            this.PhanSoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.PhanSoToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.PhanSoToolStripMenuItem.Text = "Phân số";
            this.PhanSoToolStripMenuItem.Click += new System.EventHandler(this.PhanSoToolStripMenuItem_Click);
            // 
            // SoPhucToolStripMenuItem
            // 
            this.SoPhucToolStripMenuItem.Name = "SoPhucToolStripMenuItem";
            this.SoPhucToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.SoPhucToolStripMenuItem.Text = "Số phức";
            this.SoPhucToolStripMenuItem.Click += new System.EventHandler(this.SoPhucToolStripMenuItem_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormHome";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem PhanSoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SoPhucToolStripMenuItem;
    }
}

