namespace _23520161_TranNguyenThaiBinh
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ThemMoi_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GioiThieu_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimKiem_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThemMoi_ToolStripMenuItem,
            this.GioiThieu_ToolStripMenuItem,
            this.TimKiem_ToolStripMenuItem,
            this.ToolStripComboBox});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1052, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ThemMoi_ToolStripMenuItem
            // 
            this.ThemMoi_ToolStripMenuItem.Name = "ThemMoi_ToolStripMenuItem";
            this.ThemMoi_ToolStripMenuItem.Size = new System.Drawing.Size(90, 28);
            this.ThemMoi_ToolStripMenuItem.Text = "Thêm mới";
            this.ThemMoi_ToolStripMenuItem.Click += new System.EventHandler(this.ThemMoi_ToolStripMenuItem_Click);
            // 
            // GioiThieu_ToolStripMenuItem
            // 
            this.GioiThieu_ToolStripMenuItem.Name = "GioiThieu_ToolStripMenuItem";
            this.GioiThieu_ToolStripMenuItem.Size = new System.Drawing.Size(87, 28);
            this.GioiThieu_ToolStripMenuItem.Text = "Giới thiệu";
            this.GioiThieu_ToolStripMenuItem.Click += new System.EventHandler(this.GioiThieu_ToolStripMenuItem_Click);
            // 
            // TimKiem_ToolStripMenuItem
            // 
            this.TimKiem_ToolStripMenuItem.Name = "TimKiem_ToolStripMenuItem";
            this.TimKiem_ToolStripMenuItem.Size = new System.Drawing.Size(217, 28);
            this.TimKiem_ToolStripMenuItem.Text = "Tìm kiếm theo đầu danh sách";
            this.TimKiem_ToolStripMenuItem.Click += new System.EventHandler(this.TimKiem_ToolStripMenuItem_Click);
            // 
            // ToolStripComboBox
            // 
            this.ToolStripComboBox.Items.AddRange(new object[] {
            "Hiển thị toàn bộ sách",
            "Hiển thị sách còn",
            "Hiển thị sách đã hết"});
            this.ToolStripComboBox.Name = "ToolStripComboBox";
            this.ToolStripComboBox.Size = new System.Drawing.Size(200, 28);
            this.ToolStripComboBox.ToolTipText = "Lựa chọn hiển thị";
            this.ToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.ToolStripComboBox_SelectedIndexChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView.Location = new System.Drawing.Point(0, 32);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1052, 391);
            this.dataGridView.TabIndex = 1;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(_23520161_TranNguyenThaiBinh.Program);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 423);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Quản lý thư viện";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ThemMoi_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GioiThieu_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TimKiem_ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.ToolStripComboBox ToolStripComboBox;
    }
}

