namespace Hotel_Management
{
    partial class fCustomerManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCustomerManagement));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuocTich = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTimTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.txtTimCMND = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbGender);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dtpBirthDay);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.cmbLoai);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtQuocTich);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(283, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbGender.Location = new System.Drawing.Point(15, 139);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(122, 21);
            this.cmbGender.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 123);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Giới tính";
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDay.Location = new System.Drawing.Point(16, 233);
            this.dtpBirthDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(121, 20);
            this.dtpBirthDay.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 217);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Ngày sinh";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(142, 46);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(133, 20);
            this.txtCMND.TabIndex = 15;
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Thẻ căn cước/CMND";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(165, 186);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(110, 20);
            this.txtSDT.TabIndex = 5;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // cmbLoai
            // 
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Items.AddRange(new object[] {
            "Nội địa",
            "Nước ngoài"});
            this.cmbLoai.Location = new System.Drawing.Point(165, 236);
            this.cmbLoai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(101, 21);
            this.cmbLoai.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(163, 221);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Loại khách hàng";
            // 
            // txtQuocTich
            // 
            this.txtQuocTich.Location = new System.Drawing.Point(16, 186);
            this.txtQuocTich.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQuocTich.Name = "txtQuocTich";
            this.txtQuocTich.Size = new System.Drawing.Size(121, 20);
            this.txtQuocTich.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(165, 139);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(101, 20);
            this.txtDiaChi.TabIndex = 16;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(15, 91);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(260, 20);
            this.txtTenKH.TabIndex = 2;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(15, 46);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(101, 20);
            this.txtMaKH.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 123);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 168);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quốc tịch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.txtTimTen);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnExport);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.btnTraCuu);
            this.groupBox2.Controls.Add(this.txtTimCMND);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(9, 284);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(283, 180);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng chính";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(16, 140);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 25);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTimTen
            // 
            this.txtTimTen.Location = new System.Drawing.Point(111, 27);
            this.txtTimTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimTen.Name = "txtTimTen";
            this.txtTimTen.Size = new System.Drawing.Size(153, 20);
            this.txtTimTen.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên khách hàng";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(136, 140);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(101, 23);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export file Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(136, 99);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 25);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Tải lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(16, 99);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(101, 25);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(208, 58);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(56, 27);
            this.btnTraCuu.TabIndex = 2;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // txtTimCMND
            // 
            this.txtTimCMND.Location = new System.Drawing.Point(64, 62);
            this.txtTimCMND.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimCMND.Name = "txtTimCMND";
            this.txtTimCMND.Size = new System.Drawing.Size(128, 20);
            this.txtTimCMND.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 65);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "CMND";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvData);
            this.groupBox3.Location = new System.Drawing.Point(309, 10);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(708, 388);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách khách hàng";
            // 
            // dgvData
            // 
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(4, 29);
            this.dgvData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(700, 355);
            this.dgvData.TabIndex = 0;
            // 
            // fCustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 473);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "fCustomerManagement";
            this.Text = "fCustomerManagement";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.ComboBox cmbLoai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuocTich;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.TextBox txtTimCMND;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox txtTimTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
    }
}