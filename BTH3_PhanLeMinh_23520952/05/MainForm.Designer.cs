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
            this.label1 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.congButton = new System.Windows.Forms.Button();
            this.truButton = new System.Windows.Forms.Button();
            this.nhanButton = new System.Windows.Forms.Button();
            this.chiaButton = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1";
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.num1.Location = new System.Drawing.Point(174, 86);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(255, 22);
            this.num1.TabIndex = 1;
            this.num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.num2.Location = new System.Drawing.Point(174, 134);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(255, 22);
            this.num2.TabIndex = 3;
            this.num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number 1";
            // 
            // congButton
            // 
            this.congButton.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.congButton.Location = new System.Drawing.Point(135, 178);
            this.congButton.Name = "congButton";
            this.congButton.Size = new System.Drawing.Size(51, 42);
            this.congButton.TabIndex = 4;
            this.congButton.Text = "+";
            this.congButton.UseVisualStyleBackColor = true;
            this.congButton.Click += new System.EventHandler(this.congButton_Click);
            // 
            // truButton
            // 
            this.truButton.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.truButton.Location = new System.Drawing.Point(203, 178);
            this.truButton.Name = "truButton";
            this.truButton.Size = new System.Drawing.Size(51, 42);
            this.truButton.TabIndex = 5;
            this.truButton.Text = "-";
            this.truButton.UseVisualStyleBackColor = true;
            this.truButton.Click += new System.EventHandler(this.truButton_Click);
            // 
            // nhanButton
            // 
            this.nhanButton.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nhanButton.Location = new System.Drawing.Point(271, 178);
            this.nhanButton.Name = "nhanButton";
            this.nhanButton.Size = new System.Drawing.Size(51, 42);
            this.nhanButton.TabIndex = 6;
            this.nhanButton.Text = "x";
            this.nhanButton.UseVisualStyleBackColor = true;
            this.nhanButton.Click += new System.EventHandler(this.nhanButton_Click);
            // 
            // chiaButton
            // 
            this.chiaButton.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chiaButton.Location = new System.Drawing.Point(339, 178);
            this.chiaButton.Name = "chiaButton";
            this.chiaButton.Size = new System.Drawing.Size(51, 42);
            this.chiaButton.TabIndex = 7;
            this.chiaButton.Text = "/";
            this.chiaButton.UseVisualStyleBackColor = true;
            this.chiaButton.Click += new System.EventHandler(this.chiaButton_Click);
            // 
            // answer
            // 
            this.answer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.answer.ForeColor = System.Drawing.Color.Red;
            this.answer.Location = new System.Drawing.Point(174, 238);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(255, 26);
            this.answer.TabIndex = 9;
            this.answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Answer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 345);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chiaButton);
            this.Controls.Add(this.nhanButton);
            this.Controls.Add(this.truButton);
            this.Controls.Add(this.congButton);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab02-Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button congButton;
        private System.Windows.Forms.Button truButton;
        private System.Windows.Forms.Button nhanButton;
        private System.Windows.Forms.Button chiaButton;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Label label3;
    }
}

