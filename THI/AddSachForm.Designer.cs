namespace _23520161_TranNguyenThaiBinh
{
    partial class AddSachForm
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
            this.TenSach_LabelBox = new System.Windows.Forms.Label();
            this.TenSach_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TacGia_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TheLoai_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SoLuongTon_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongTon_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TenSach_LabelBox
            // 
            this.TenSach_LabelBox.AutoSize = true;
            this.TenSach_LabelBox.Location = new System.Drawing.Point(26, 21);
            this.TenSach_LabelBox.Name = "TenSach_LabelBox";
            this.TenSach_LabelBox.Size = new System.Drawing.Size(66, 16);
            this.TenSach_LabelBox.TabIndex = 3;
            this.TenSach_LabelBox.Text = "Tên sách:";
            // 
            // TenSach_TextBox
            // 
            this.TenSach_TextBox.Location = new System.Drawing.Point(116, 21);
            this.TenSach_TextBox.Name = "TenSach_TextBox";
            this.TenSach_TextBox.Size = new System.Drawing.Size(223, 22);
            this.TenSach_TextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tác giả:";
            // 
            // TacGia_TextBox
            // 
            this.TacGia_TextBox.Location = new System.Drawing.Point(116, 63);
            this.TacGia_TextBox.Name = "TacGia_TextBox";
            this.TacGia_TextBox.Size = new System.Drawing.Size(223, 22);
            this.TacGia_TextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thể loại:";
            // 
            // TheLoai_TextBox
            // 
            this.TheLoai_TextBox.Location = new System.Drawing.Point(116, 111);
            this.TheLoai_TextBox.Name = "TheLoai_TextBox";
            this.TheLoai_TextBox.Size = new System.Drawing.Size(223, 22);
            this.TheLoai_TextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng tồn:";
            // 
            // SoLuongTon_numericUpDown
            // 
            this.SoLuongTon_numericUpDown.Location = new System.Drawing.Point(116, 163);
            this.SoLuongTon_numericUpDown.Name = "SoLuongTon_numericUpDown";
            this.SoLuongTon_numericUpDown.Size = new System.Drawing.Size(223, 22);
            this.SoLuongTon_numericUpDown.TabIndex = 3;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(116, 212);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 4;
            this.button.Text = "Thêm";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // AddSachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 253);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TheLoai_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TacGia_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TenSach_TextBox);
            this.Controls.Add(this.TenSach_LabelBox);
            this.Controls.Add(this.SoLuongTon_numericUpDown);
            this.Name = "AddSachForm";
            this.Text = "Thêm sách";
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongTon_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TenSach_LabelBox;
        private System.Windows.Forms.TextBox TenSach_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TacGia_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TheLoai_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown SoLuongTon_numericUpDown;
        private System.Windows.Forms.Button button;
    }
}