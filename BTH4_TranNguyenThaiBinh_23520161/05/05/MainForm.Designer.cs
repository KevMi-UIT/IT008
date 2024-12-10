namespace _05
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.preferenceMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addNew_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.tool = new System.Windows.Forms.ToolStrip();
            this.addNew_Button = new System.Windows.Forms.ToolStripButton();
            this.addNew_Label = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.searchBox = new System.Windows.Forms.ToolStripTextBox();
            this.studentInfoList = new System.Windows.Forms.DataGridView();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu.SuspendLayout();
            this.tool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferenceMenu});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(931, 28);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // preferenceMenu
            // 
            this.preferenceMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNew_Menu,
            this.exit_Menu});
            this.preferenceMenu.Name = "preferenceMenu";
            this.preferenceMenu.Size = new System.Drawing.Size(96, 24);
            this.preferenceMenu.Text = "Chức Năng";
            // 
            // addNew_Menu
            // 
            this.addNew_Menu.Name = "addNew_Menu";
            this.addNew_Menu.Size = new System.Drawing.Size(159, 26);
            this.addNew_Menu.Text = "Thêm Mới";
            this.addNew_Menu.Click += new System.EventHandler(this.addNew_Menu_Click);
            // 
            // exit_Menu
            // 
            this.exit_Menu.Name = "exit_Menu";
            this.exit_Menu.Size = new System.Drawing.Size(159, 26);
            this.exit_Menu.Text = "Thoát";
            this.exit_Menu.Click += new System.EventHandler(this.exit_Menu_Click);
            // 
            // tool
            // 
            this.tool.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNew_Button,
            this.addNew_Label,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.searchBox});
            this.tool.Location = new System.Drawing.Point(0, 28);
            this.tool.Name = "tool";
            this.tool.Size = new System.Drawing.Size(931, 28);
            this.tool.TabIndex = 1;
            this.tool.Text = "toolStrip1";
            // 
            // addNew_Button
            // 
            this.addNew_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addNew_Button.Image = ((System.Drawing.Image)(resources.GetObject("addNew_Button.Image")));
            this.addNew_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addNew_Button.Margin = new System.Windows.Forms.Padding(0);
            this.addNew_Button.Name = "addNew_Button";
            this.addNew_Button.Size = new System.Drawing.Size(29, 28);
            this.addNew_Button.Text = "Thêm Mới";
            this.addNew_Button.Click += new System.EventHandler(this.addNew_Click);
            // 
            // addNew_Label
            // 
            this.addNew_Label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.addNew_Label.Name = "addNew_Label";
            this.addNew_Label.Size = new System.Drawing.Size(97, 25);
            this.addNew_Label.Text = "Thêm Mới";
            this.addNew_Label.Click += new System.EventHandler(this.addNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(200, 25);
            this.toolStripLabel1.Text = "                Tìm Kiếm Theo Tên";
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.SystemColors.Window;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchBox.Name = "searchBox";
            this.searchBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchBox.Size = new System.Drawing.Size(333, 28);
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // studentInfoList
            // 
            this.studentInfoList.AllowUserToAddRows = false;
            this.studentInfoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentInfoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order,
            this.studentID,
            this.studentName,
            this.apartment,
            this.averageScore});
            this.studentInfoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentInfoList.Location = new System.Drawing.Point(0, 56);
            this.studentInfoList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studentInfoList.Name = "studentInfoList";
            this.studentInfoList.RowHeadersWidth = 51;
            this.studentInfoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentInfoList.Size = new System.Drawing.Size(931, 498);
            this.studentInfoList.TabIndex = 2;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(_05.student);
            // 
            // order
            // 
            this.order.HeaderText = "Số TT";
            this.order.MinimumWidth = 6;
            this.order.Name = "order";
            this.order.Width = 60;
            // 
            // studentID
            // 
            this.studentID.HeaderText = "Mã Số SV";
            this.studentID.MinimumWidth = 6;
            this.studentID.Name = "studentID";
            this.studentID.Width = 125;
            // 
            // studentName
            // 
            this.studentName.HeaderText = "Tên Sinh Viên";
            this.studentName.MinimumWidth = 6;
            this.studentName.Name = "studentName";
            this.studentName.Width = 300;
            // 
            // apartment
            // 
            this.apartment.HeaderText = "Khoa";
            this.apartment.MinimumWidth = 6;
            this.apartment.Name = "apartment";
            this.apartment.Width = 200;
            // 
            // averageScore
            // 
            this.averageScore.HeaderText = "Điểm TB";
            this.averageScore.MinimumWidth = 6;
            this.averageScore.Name = "averageScore";
            this.averageScore.ReadOnly = true;
            this.averageScore.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 554);
            this.Controls.Add(this.studentInfoList);
            this.Controls.Add(this.tool);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sinh Viên";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tool.ResumeLayout(false);
            this.tool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem preferenceMenu;
        private System.Windows.Forms.ToolStripMenuItem addNew_Menu;
        private System.Windows.Forms.ToolStripMenuItem exit_Menu;
        private System.Windows.Forms.ToolStrip tool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox searchBox;
        private System.Windows.Forms.ToolStripButton addNew_Button;
        private System.Windows.Forms.DataGridView studentInfoList;
        private System.Windows.Forms.ToolStripLabel addNew_Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn order;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageScore;
        private System.Windows.Forms.BindingSource studentBindingSource;
    }
}

