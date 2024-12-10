namespace _02
{
    partial class MainWindow
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
            this.timeNow = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timeNow
            // 
            this.timeNow.AutoSize = true;
            this.timeNow.Location = new System.Drawing.Point(310, 185);
            this.timeNow.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.timeNow.Name = "timeNow";
            this.timeNow.Size = new System.Drawing.Size(176, 40);
            this.timeNow.TabIndex = 0;
            this.timeNow.Text = "Time Now";
            // 
            // clock
            // 
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 403);
            this.Controls.Add(this.timeNow);
            this.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Clock";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeNow;
        private System.Windows.Forms.Timer clock;
    }
}

