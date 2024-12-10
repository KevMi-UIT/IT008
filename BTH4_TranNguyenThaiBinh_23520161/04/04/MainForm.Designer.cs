namespace _04
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.openDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.exitDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.formatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tool = new System.Windows.Forms.ToolStrip();
            this.newFile_Button = new System.Windows.Forms.ToolStripButton();
            this.saveFile_Button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fontCombobox = new System.Windows.Forms.ToolStripComboBox();
            this.fontSizeCombobox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bold = new System.Windows.Forms.ToolStripButton();
            this.italic = new System.Windows.Forms.ToolStripButton();
            this.underline = new System.Windows.Forms.ToolStripButton();
            this.textSpace = new System.Windows.Forms.RichTextBox();
            this.menu.SuspendLayout();
            this.tool.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenu,
            this.formatMenu});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(881, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // mainMenu
            // 
            this.mainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDocument,
            this.openDocument,
            this.saveDocument,
            this.exitDocument});
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(69, 20);
            this.mainMenu.Text = "Hệ thống";
            // 
            // newDocument
            // 
            this.newDocument.Image = ((System.Drawing.Image)(resources.GetObject("newDocument.Image")));
            this.newDocument.Name = "newDocument";
            this.newDocument.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newDocument.Size = new System.Drawing.Size(230, 22);
            this.newDocument.Text = "Tạo văn bản mới";
            this.newDocument.Click += new System.EventHandler(this.newDocument_Click);
            // 
            // openDocument
            // 
            this.openDocument.Image = ((System.Drawing.Image)(resources.GetObject("openDocument.Image")));
            this.openDocument.Name = "openDocument";
            this.openDocument.Size = new System.Drawing.Size(230, 22);
            this.openDocument.Text = "Mở tập tin";
            this.openDocument.Click += new System.EventHandler(this.openDocument_Click);
            // 
            // saveDocument
            // 
            this.saveDocument.Image = ((System.Drawing.Image)(resources.GetObject("saveDocument.Image")));
            this.saveDocument.Name = "saveDocument";
            this.saveDocument.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveDocument.Size = new System.Drawing.Size(230, 22);
            this.saveDocument.Text = "Lưu nội dung văn bản";
            this.saveDocument.Click += new System.EventHandler(this.saveDocument_Click);
            // 
            // exitDocument
            // 
            this.exitDocument.Name = "exitDocument";
            this.exitDocument.Size = new System.Drawing.Size(230, 22);
            this.exitDocument.Text = "Thoát";
            this.exitDocument.Click += new System.EventHandler(this.exitDocument_Click);
            // 
            // formatMenu
            // 
            this.formatMenu.Name = "formatMenu";
            this.formatMenu.Size = new System.Drawing.Size(74, 20);
            this.formatMenu.Text = "Định dạng";
            this.formatMenu.Click += new System.EventHandler(this.formatMenu_Click);
            // 
            // tool
            // 
            this.tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFile_Button,
            this.saveFile_Button,
            this.toolStripSeparator1,
            this.fontCombobox,
            this.fontSizeCombobox,
            this.toolStripSeparator2,
            this.bold,
            this.italic,
            this.underline});
            this.tool.Location = new System.Drawing.Point(0, 24);
            this.tool.Name = "tool";
            this.tool.Size = new System.Drawing.Size(881, 25);
            this.tool.TabIndex = 3;
            this.tool.Text = "toolStrip1";
            // 
            // newFile_Button
            // 
            this.newFile_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newFile_Button.Image = ((System.Drawing.Image)(resources.GetObject("newFile_Button.Image")));
            this.newFile_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newFile_Button.Name = "newFile_Button";
            this.newFile_Button.Size = new System.Drawing.Size(23, 22);
            this.newFile_Button.Text = "New";
            this.newFile_Button.Click += new System.EventHandler(this.newFile_Button_Click);
            // 
            // saveFile_Button
            // 
            this.saveFile_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveFile_Button.Image = ((System.Drawing.Image)(resources.GetObject("saveFile_Button.Image")));
            this.saveFile_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveFile_Button.Name = "saveFile_Button";
            this.saveFile_Button.Size = new System.Drawing.Size(23, 22);
            this.saveFile_Button.Text = "toolStripButton2";
            this.saveFile_Button.Click += new System.EventHandler(this.saveFile_Button_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // fontCombobox
            // 
            this.fontCombobox.Name = "fontCombobox";
            this.fontCombobox.Size = new System.Drawing.Size(121, 25);
            this.fontCombobox.Text = "Arial";
            this.fontCombobox.TextChanged += new System.EventHandler(this.changeFontStyle);
            // 
            // fontSizeCombobox
            // 
            this.fontSizeCombobox.Name = "fontSizeCombobox";
            this.fontSizeCombobox.Size = new System.Drawing.Size(121, 25);
            this.fontSizeCombobox.Text = "12";
            this.fontSizeCombobox.TextChanged += new System.EventHandler(this.changeFontStyle);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bold
            // 
            this.bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bold.Image = ((System.Drawing.Image)(resources.GetObject("bold.Image")));
            this.bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(23, 22);
            this.bold.Text = "toolStripButton3";
            this.bold.Click += new System.EventHandler(this.bold_Click);
            // 
            // italic
            // 
            this.italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italic.Image = ((System.Drawing.Image)(resources.GetObject("italic.Image")));
            this.italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italic.Name = "italic";
            this.italic.Size = new System.Drawing.Size(23, 22);
            this.italic.Text = "toolStripButton4";
            this.italic.Click += new System.EventHandler(this.italic_Click);
            // 
            // underline
            // 
            this.underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underline.Image = ((System.Drawing.Image)(resources.GetObject("underline.Image")));
            this.underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(23, 22);
            this.underline.Text = "toolStripButton5";
            this.underline.Click += new System.EventHandler(this.underline_Click);
            // 
            // textSpace
            // 
            this.textSpace.BackColor = System.Drawing.Color.White;
            this.textSpace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textSpace.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textSpace.Location = new System.Drawing.Point(0, 49);
            this.textSpace.Name = "textSpace";
            this.textSpace.Size = new System.Drawing.Size(881, 466);
            this.textSpace.TabIndex = 4;
            this.textSpace.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 515);
            this.Controls.Add(this.textSpace);
            this.Controls.Add(this.tool);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soạn thảo văn bản";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tool.ResumeLayout(false);
            this.tool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mainMenu;
        private System.Windows.Forms.ToolStripMenuItem formatMenu;
        private System.Windows.Forms.ToolStripMenuItem newDocument;
        private System.Windows.Forms.ToolStripMenuItem openDocument;
        private System.Windows.Forms.ToolStripMenuItem saveDocument;
        private System.Windows.Forms.ToolStripMenuItem exitDocument;
        private System.Windows.Forms.ToolStrip tool;
        private System.Windows.Forms.ToolStripButton newFile_Button;
        private System.Windows.Forms.ToolStripButton saveFile_Button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox fontCombobox;
        private System.Windows.Forms.ToolStripComboBox fontSizeCombobox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton bold;
        private System.Windows.Forms.ToolStripButton italic;
        private System.Windows.Forms.ToolStripButton underline;
        private System.Windows.Forms.RichTextBox textSpace;
    }
}

