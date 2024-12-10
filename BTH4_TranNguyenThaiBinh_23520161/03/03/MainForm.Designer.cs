namespace _03
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
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.timeNow = new System.Windows.Forms.ToolStripStatusLabel();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.menu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1149, 28);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFile,
            this.exit});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(46, 24);
            this.fileMenu.Text = "File";
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFile.Size = new System.Drawing.Size(224, 26);
            this.openFile.Text = "Open File";
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exit.Size = new System.Drawing.Size(224, 26);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeNow});
            this.statusStrip.Location = new System.Drawing.Point(0, 700);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1149, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "Time";
            // 
            // timeNow
            // 
            this.timeNow.Name = "timeNow";
            this.timeNow.Size = new System.Drawing.Size(77, 20);
            this.timeNow.Text = "Time Now";
            // 
            // clock
            // 
            this.clock.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(0, 24);
            this.mediaPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(944, 639);
            this.mediaPlayer.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 726);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình Windows Media";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel timeNow;
        private System.Windows.Forms.Timer clock;
    }
}

