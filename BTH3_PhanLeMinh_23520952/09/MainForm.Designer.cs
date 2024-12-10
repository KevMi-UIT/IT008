namespace _09
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
            this.studentID_Box = new System.Windows.Forms.TextBox();
            this.name_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.apartmentComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.manCheckbox = new System.Windows.Forms.CheckBox();
            this.womanCheckbox = new System.Windows.Forms.CheckBox();
            this.leftBox = new System.Windows.Forms.ListBox();
            this.toRightBox_Button = new System.Windows.Forms.Button();
            this.toLeftBox_Button = new System.Windows.Forms.Button();
            this.rightBox = new System.Windows.Forms.ListBox();
            this.saveInfo_Button = new System.Windows.Forms.Button();
            this.cancelChoice_Button = new System.Windows.Forms.Button();
            this.infoList = new System.Windows.Forms.DataGridView();
            this.studentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infoList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(102, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // studentID_Box
            // 
            this.studentID_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.studentID_Box.Location = new System.Drawing.Point(261, 91);
            this.studentID_Box.Name = "studentID_Box";
            this.studentID_Box.Size = new System.Drawing.Size(200, 22);
            this.studentID_Box.TabIndex = 1;
            // 
            // name_Box
            // 
            this.name_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.name_Box.Location = new System.Drawing.Point(261, 129);
            this.name_Box.Name = "name_Box";
            this.name_Box.Size = new System.Drawing.Size(400, 22);
            this.name_Box.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(102, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(102, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chuyên Ngành";
            // 
            // apartmentComboBox
            // 
            this.apartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.apartmentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.apartmentComboBox.FormattingEnabled = true;
            this.apartmentComboBox.Items.AddRange(new object[] {
            "Hệ Thống Thông Tin",
            "Kỹ Thuật Phần Mềm",
            "Khoa Học Máy Tính",
            "Thương Mại Điện Tử",
            "Mạng Máy Tính Và Truyền Thông",
            "Khoa Học Dữ Liệu",
            "Công Nghệ Thông Tin"});
            this.apartmentComboBox.Location = new System.Drawing.Point(261, 166);
            this.apartmentComboBox.Name = "apartmentComboBox";
            this.apartmentComboBox.Size = new System.Drawing.Size(400, 24);
            this.apartmentComboBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(102, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(102, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Chọn Các Môn Học Tham Gia";
            // 
            // manCheckbox
            // 
            this.manCheckbox.AutoSize = true;
            this.manCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.manCheckbox.Location = new System.Drawing.Point(261, 207);
            this.manCheckbox.Name = "manCheckbox";
            this.manCheckbox.Size = new System.Drawing.Size(56, 20);
            this.manCheckbox.TabIndex = 8;
            this.manCheckbox.Text = "Nam";
            this.manCheckbox.UseVisualStyleBackColor = true;
            // 
            // womanCheckbox
            // 
            this.womanCheckbox.AutoSize = true;
            this.womanCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.womanCheckbox.Location = new System.Drawing.Point(363, 206);
            this.womanCheckbox.Name = "womanCheckbox";
            this.womanCheckbox.Size = new System.Drawing.Size(44, 20);
            this.womanCheckbox.TabIndex = 9;
            this.womanCheckbox.Text = "Nữ";
            this.womanCheckbox.UseVisualStyleBackColor = true;
            // 
            // leftBox
            // 
            this.leftBox.FormattingEnabled = true;
            this.leftBox.Items.AddRange(new object[] {
            "Cơ Sở Dữ Liệu",
            "Cơ Sở DL NC",
            "PTTK Hệ Thống thông tin"});
            this.leftBox.Location = new System.Drawing.Point(103, 283);
            this.leftBox.Name = "leftBox";
            this.leftBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.leftBox.Size = new System.Drawing.Size(238, 95);
            this.leftBox.TabIndex = 10;
            // 
            // toRightBox_Button
            // 
            this.toRightBox_Button.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toRightBox_Button.Location = new System.Drawing.Point(357, 283);
            this.toRightBox_Button.Name = "toRightBox_Button";
            this.toRightBox_Button.Size = new System.Drawing.Size(48, 41);
            this.toRightBox_Button.TabIndex = 11;
            this.toRightBox_Button.Text = ">";
            this.toRightBox_Button.UseVisualStyleBackColor = true;
            this.toRightBox_Button.Click += new System.EventHandler(this.toRightBox_Button_Click);
            // 
            // toLeftBox_Button
            // 
            this.toLeftBox_Button.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toLeftBox_Button.Location = new System.Drawing.Point(357, 337);
            this.toLeftBox_Button.Name = "toLeftBox_Button";
            this.toLeftBox_Button.Size = new System.Drawing.Size(48, 41);
            this.toLeftBox_Button.TabIndex = 12;
            this.toLeftBox_Button.Text = "<";
            this.toLeftBox_Button.UseVisualStyleBackColor = true;
            this.toLeftBox_Button.Click += new System.EventHandler(this.toLeftBox_Button_Click);
            // 
            // rightBox
            // 
            this.rightBox.FormattingEnabled = true;
            this.rightBox.Location = new System.Drawing.Point(421, 283);
            this.rightBox.Name = "rightBox";
            this.rightBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.rightBox.Size = new System.Drawing.Size(238, 95);
            this.rightBox.TabIndex = 13;
            // 
            // saveInfo_Button
            // 
            this.saveInfo_Button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.saveInfo_Button.Location = new System.Drawing.Point(211, 384);
            this.saveInfo_Button.Name = "saveInfo_Button";
            this.saveInfo_Button.Size = new System.Drawing.Size(130, 32);
            this.saveInfo_Button.TabIndex = 14;
            this.saveInfo_Button.Text = "Lưu Thông Tin";
            this.saveInfo_Button.UseVisualStyleBackColor = true;
            this.saveInfo_Button.Click += new System.EventHandler(this.saveInfo_Button_Click);
            // 
            // cancelChoice_Button
            // 
            this.cancelChoice_Button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cancelChoice_Button.Location = new System.Drawing.Point(421, 384);
            this.cancelChoice_Button.Name = "cancelChoice_Button";
            this.cancelChoice_Button.Size = new System.Drawing.Size(130, 32);
            this.cancelChoice_Button.TabIndex = 15;
            this.cancelChoice_Button.Text = "Xóa Chọn";
            this.cancelChoice_Button.UseVisualStyleBackColor = true;
            this.cancelChoice_Button.Click += new System.EventHandler(this.cancelChoice_Button_Click);
            // 
            // infoList
            // 
            this.infoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentID,
            this.name,
            this.apartment,
            this.gender,
            this.subjectAmount});
            this.infoList.Location = new System.Drawing.Point(31, 432);
            this.infoList.Name = "infoList";
            this.infoList.Size = new System.Drawing.Size(700, 216);
            this.infoList.TabIndex = 16;
            // 
            // studentID
            // 
            this.studentID.HeaderText = "MSSV";
            this.studentID.Name = "studentID";
            this.studentID.Width = 80;
            // 
            // name
            // 
            this.name.HeaderText = "Họ Tên";
            this.name.Name = "name";
            this.name.Width = 180;
            // 
            // apartment
            // 
            this.apartment.FillWeight = 200F;
            this.apartment.HeaderText = "Chuyên Ngành";
            this.apartment.Name = "apartment";
            this.apartment.Width = 230;
            // 
            // gender
            // 
            this.gender.HeaderText = "Giới Tính";
            this.gender.Name = "gender";
            // 
            // subjectAmount
            // 
            this.subjectAmount.HeaderText = "Số Môn";
            this.subjectAmount.Name = "subjectAmount";
            this.subjectAmount.Width = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(157, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(448, 46);
            this.label6.TabIndex = 17;
            this.label6.Text = "THÔNG TIN SINH VIÊN";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 677);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.infoList);
            this.Controls.Add(this.cancelChoice_Button);
            this.Controls.Add(this.saveInfo_Button);
            this.Controls.Add(this.rightBox);
            this.Controls.Add(this.toLeftBox_Button);
            this.Controls.Add(this.toRightBox_Button);
            this.Controls.Add(this.leftBox);
            this.Controls.Add(this.womanCheckbox);
            this.Controls.Add(this.manCheckbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.apartmentComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentID_Box);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Liệu Sinh Viên";
            ((System.ComponentModel.ISupportInitialize)(this.infoList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentID_Box;
        private System.Windows.Forms.TextBox name_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox apartmentComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox manCheckbox;
        private System.Windows.Forms.CheckBox womanCheckbox;
        private System.Windows.Forms.ListBox leftBox;
        private System.Windows.Forms.Button toRightBox_Button;
        private System.Windows.Forms.Button toLeftBox_Button;
        private System.Windows.Forms.ListBox rightBox;
        private System.Windows.Forms.Button saveInfo_Button;
        private System.Windows.Forms.Button cancelChoice_Button;
        private System.Windows.Forms.DataGridView infoList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectAmount;
    }
}

