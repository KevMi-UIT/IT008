namespace _05
{
    partial class addNew_Form
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
            this.studentID_TextBox = new System.Windows.Forms.TextBox();
            this.studentName_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.averageScore__TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.apartment_ComboBox = new System.Windows.Forms.ComboBox();
            this.addNew_Button = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(42, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Số Sinh Viên";
            // 
            // studentID_TextBox
            // 
            this.studentID_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentID_TextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.studentID_TextBox.Location = new System.Drawing.Point(227, 31);
            this.studentID_TextBox.Name = "studentID_TextBox";
            this.studentID_TextBox.Size = new System.Drawing.Size(400, 29);
            this.studentID_TextBox.TabIndex = 1;
            // 
            // studentName_TextBox
            // 
            this.studentName_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentName_TextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.studentName_TextBox.Location = new System.Drawing.Point(227, 88);
            this.studentName_TextBox.Name = "studentName_TextBox";
            this.studentName_TextBox.Size = new System.Drawing.Size(400, 29);
            this.studentName_TextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(42, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Sinh Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(42, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khoa";
            // 
            // averageScore__TextBox
            // 
            this.averageScore__TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.averageScore__TextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.averageScore__TextBox.Location = new System.Drawing.Point(227, 202);
            this.averageScore__TextBox.Name = "averageScore__TextBox";
            this.averageScore__TextBox.Size = new System.Drawing.Size(137, 29);
            this.averageScore__TextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(42, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Điểm TB";
            // 
            // apartment_ComboBox
            // 
            this.apartment_ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.apartment_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.apartment_ComboBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.apartment_ComboBox.FormattingEnabled = true;
            this.apartment_ComboBox.Items.AddRange(new object[] {
            "Công Nghệ Thông Tin",
            "Công Nghệ Phần Mềm",
            "Hệ Thống Thông Tin",
            "Khoa Học Và Kỹ Thuật Thông Tin"});
            this.apartment_ComboBox.Location = new System.Drawing.Point(227, 145);
            this.apartment_ComboBox.Name = "apartment_ComboBox";
            this.apartment_ComboBox.Size = new System.Drawing.Size(400, 30);
            this.apartment_ComboBox.TabIndex = 8;
            // 
            // addNew_Button
            // 
            this.addNew_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addNew_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(181)))), ((int)(((byte)(107)))));
            this.addNew_Button.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.addNew_Button.Location = new System.Drawing.Point(359, 253);
            this.addNew_Button.Name = "addNew_Button";
            this.addNew_Button.Size = new System.Drawing.Size(126, 43);
            this.addNew_Button.TabIndex = 10;
            this.addNew_Button.Text = "Thêm Mới";
            this.addNew_Button.UseVisualStyleBackColor = false;
            this.addNew_Button.Click += new System.EventHandler(this.addNew_Button_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(109)))), ((int)(((byte)(49)))));
            this.exitButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.exitButton.Location = new System.Drawing.Point(501, 253);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(126, 43);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Thoát";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addNew_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 314);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addNew_Button);
            this.Controls.Add(this.apartment_ComboBox);
            this.Controls.Add(this.averageScore__TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.studentName_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentID_TextBox);
            this.Controls.Add(this.label1);
            this.Name = "addNew_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Sinh Viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentID_TextBox;
        private System.Windows.Forms.TextBox studentName_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox averageScore__TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox apartment_ComboBox;
        private System.Windows.Forms.Button addNew_Button;
        private System.Windows.Forms.Button exitButton;
    }
}