namespace _08
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
            this.acountID = new System.Windows.Forms.TextBox();
            this.customerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customerAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.accountMoney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.order = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.money = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(171, 126);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tài khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // acountID
            // 
            this.acountID.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.acountID.Location = new System.Drawing.Point(284, 123);
            this.acountID.Name = "acountID";
            this.acountID.Size = new System.Drawing.Size(525, 27);
            this.acountID.TabIndex = 1;
            // 
            // customerName
            // 
            this.customerName.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.customerName.Location = new System.Drawing.Point(284, 174);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(525, 27);
            this.customerName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(144, 177);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên khách hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // customerAddress
            // 
            this.customerAddress.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.customerAddress.Location = new System.Drawing.Point(284, 225);
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.Size = new System.Drawing.Size(525, 27);
            this.customerAddress.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(120, 228);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(158, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa chỉ khách hàng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // accountMoney
            // 
            this.accountMoney.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold);
            this.accountMoney.Location = new System.Drawing.Point(284, 276);
            this.accountMoney.Name = "accountMoney";
            this.accountMoney.Size = new System.Drawing.Size(525, 27);
            this.accountMoney.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(89, 276);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(189, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số tiền trong tài khoản";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(81, 31);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(778, 55);
            this.label5.TabIndex = 8;
            this.label5.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.deleteButton.Location = new System.Drawing.Point(471, 327);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 34);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Xóa";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.exitButton.Location = new System.Drawing.Point(659, 327);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 34);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Thoát";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.modifyButton.Location = new System.Drawing.Point(284, 327);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(150, 34);
            this.modifyButton.TabIndex = 13;
            this.modifyButton.Text = "Thêm / Cập Nhật";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.order,
            this.ID,
            this.name,
            this.address,
            this.money});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.HoverSelection = true;
            this.listView.Location = new System.Drawing.Point(20, 394);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(900, 339);
            this.listView.TabIndex = 14;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // order
            // 
            this.order.Text = "STT";
            this.order.Width = 50;
            // 
            // ID
            // 
            this.ID.Text = "Mã tài khoản";
            this.ID.Width = 150;
            // 
            // name
            // 
            this.name.Text = "Tên khách hàng";
            this.name.Width = 200;
            // 
            // address
            // 
            this.address.Text = "Địa chỉ";
            this.address.Width = 350;
            // 
            // money
            // 
            this.money.Text = "Số tiền";
            this.money.Width = 145;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 753);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.accountMoney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customerAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.acountID);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tài Khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox acountID;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox accountMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader order;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader money;
    }
}

