namespace _06
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
            this.gprProcess = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.grpPath = new System.Windows.Forms.GroupBox();
            this.endLocation = new System.Windows.Forms.TextBox();
            this.startLocation = new System.Windows.Forms.TextBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.endLocation_Button = new System.Windows.Forms.Button();
            this.startLocation_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.copyProcess = new System.ComponentModel.BackgroundWorker();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.gprProcess.SuspendLayout();
            this.grpPath.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gprProcess
            // 
            this.gprProcess.Controls.Add(this.progressBar);
            this.gprProcess.Location = new System.Drawing.Point(18, 269);
            this.gprProcess.Margin = new System.Windows.Forms.Padding(2);
            this.gprProcess.Name = "gprProcess";
            this.gprProcess.Padding = new System.Windows.Forms.Padding(2);
            this.gprProcess.Size = new System.Drawing.Size(851, 99);
            this.gprProcess.TabIndex = 11;
            this.gprProcess.TabStop = false;
            this.gprProcess.Text = "Tiến trình sao chép";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(54, 34);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(742, 40);
            this.progressBar.TabIndex = 0;
            // 
            // grpPath
            // 
            this.grpPath.Controls.Add(this.endLocation);
            this.grpPath.Controls.Add(this.startLocation);
            this.grpPath.Controls.Add(this.copyButton);
            this.grpPath.Controls.Add(this.endLocation_Button);
            this.grpPath.Controls.Add(this.startLocation_Button);
            this.grpPath.Controls.Add(this.label2);
            this.grpPath.Controls.Add(this.label1);
            this.grpPath.Location = new System.Drawing.Point(18, 20);
            this.grpPath.Margin = new System.Windows.Forms.Padding(2);
            this.grpPath.Name = "grpPath";
            this.grpPath.Padding = new System.Windows.Forms.Padding(2);
            this.grpPath.Size = new System.Drawing.Size(851, 217);
            this.grpPath.TabIndex = 10;
            this.grpPath.TabStop = false;
            this.grpPath.Text = "Sao chép tập tin";
            // 
            // endLocation
            // 
            this.endLocation.Enabled = false;
            this.endLocation.Location = new System.Drawing.Point(226, 114);
            this.endLocation.Margin = new System.Windows.Forms.Padding(2);
            this.endLocation.Multiline = true;
            this.endLocation.Name = "endLocation";
            this.endLocation.Size = new System.Drawing.Size(478, 18);
            this.endLocation.TabIndex = 8;
            // 
            // startLocation
            // 
            this.startLocation.Enabled = false;
            this.startLocation.Location = new System.Drawing.Point(226, 57);
            this.startLocation.Margin = new System.Windows.Forms.Padding(2);
            this.startLocation.Multiline = true;
            this.startLocation.Name = "startLocation";
            this.startLocation.Size = new System.Drawing.Size(478, 18);
            this.startLocation.TabIndex = 7;
            // 
            // copyButton
            // 
            this.copyButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.copyButton.Location = new System.Drawing.Point(226, 151);
            this.copyButton.Margin = new System.Windows.Forms.Padding(2);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(271, 39);
            this.copyButton.TabIndex = 6;
            this.copyButton.Text = "Sao chép";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // endLocation_Button
            // 
            this.endLocation_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.endLocation_Button.Location = new System.Drawing.Point(720, 109);
            this.endLocation_Button.Margin = new System.Windows.Forms.Padding(0);
            this.endLocation_Button.Name = "endLocation_Button";
            this.endLocation_Button.Size = new System.Drawing.Size(72, 28);
            this.endLocation_Button.TabIndex = 5;
            this.endLocation_Button.Text = "...";
            this.endLocation_Button.UseVisualStyleBackColor = true;
            this.endLocation_Button.Click += new System.EventHandler(this.endLocation_Button_Click);
            // 
            // startLocation_Button
            // 
            this.startLocation_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.startLocation_Button.Location = new System.Drawing.Point(720, 52);
            this.startLocation_Button.Margin = new System.Windows.Forms.Padding(0);
            this.startLocation_Button.Name = "startLocation_Button";
            this.startLocation_Button.Size = new System.Drawing.Size(72, 28);
            this.startLocation_Button.TabIndex = 4;
            this.startLocation_Button.Text = "...";
            this.startLocation_Button.UseVisualStyleBackColor = true;
            this.startLocation_Button.Click += new System.EventHandler(this.startLocation_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(47, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đường dẫn thư mục đích";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(47, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đường dẫn thư mục nguồn";
            // 
            // copyProcess
            // 
            this.copyProcess.DoWork += new System.ComponentModel.DoWorkEventHandler(this.copyProcess_DoWork);
            this.copyProcess.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.copyProcess_ProgressChanged);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 378);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(887, 22);
            this.statusStrip.TabIndex = 12;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(88, 17);
            this.statusLabel.Text = "Đang sao chép:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 400);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gprProcess);
            this.Controls.Add(this.grpPath);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sao chép tập tin";
            this.TopMost = true;
            this.gprProcess.ResumeLayout(false);
            this.grpPath.ResumeLayout(false);
            this.grpPath.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gprProcess;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox grpPath;
        private System.Windows.Forms.TextBox endLocation;
        private System.Windows.Forms.TextBox startLocation;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button endLocation_Button;
        private System.Windows.Forms.Button startLocation_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker copyProcess;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}

