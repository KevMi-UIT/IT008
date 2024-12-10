namespace _02
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
            this.contentPanel = new System.Windows.Forms.Panel();
            this.drawButton = new System.Windows.Forms.Button();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.drawButton);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(956, 661);
            this.contentPanel.TabIndex = 0;
            // 
            // drawButton
            // 
            this.drawButton.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.drawButton.Location = new System.Drawing.Point(796, 607);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(148, 42);
            this.drawButton.TabIndex = 0;
            this.drawButton.Text = "DRAW TEXT";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 661);
            this.Controls.Add(this.contentPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Button drawButton;
    }
}

