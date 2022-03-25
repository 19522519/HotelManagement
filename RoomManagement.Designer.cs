
namespace Hotel_Management
{
    partial class RoomManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomManagement));
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvDanhSachPhong = new System.Windows.Forms.DataGridView();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnCapNhatPhong = new System.Windows.Forms.Button();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.txbGhiChu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbMaPhong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbTenPhong = new System.Windows.Forms.TextBox();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbTimLoaiPhong = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txbTimTenPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhong)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dgvDanhSachPhong);
            this.panel4.Controls.Add(this.btnXuatExcel);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // dgvDanhSachPhong
            // 
            this.dgvDanhSachPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvDanhSachPhong, "dgvDanhSachPhong");
            this.dgvDanhSachPhong.Name = "dgvDanhSachPhong";
            this.dgvDanhSachPhong.RowTemplate.Height = 24;
            this.dgvDanhSachPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachPhong_CellClick);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btnXuatExcel, "btnXuatExcel");
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnDong);
            this.panel3.Controls.Add(this.btnCapNhatPhong);
            this.panel3.Controls.Add(this.btnXoaPhong);
            this.panel3.Controls.Add(this.btnThemPhong);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btnDong, "btnDong");
            this.btnDong.Name = "btnDong";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnCapNhatPhong
            // 
            this.btnCapNhatPhong.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btnCapNhatPhong, "btnCapNhatPhong");
            this.btnCapNhatPhong.Name = "btnCapNhatPhong";
            this.btnCapNhatPhong.UseVisualStyleBackColor = true;
            this.btnCapNhatPhong.Click += new System.EventHandler(this.btnCapNhatPhong_Click);
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btnXoaPhong, "btnXoaPhong");
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.UseVisualStyleBackColor = true;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btnThemPhong, "btnThemPhong");
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbLoaiPhong);
            this.panel2.Controls.Add(this.txbGhiChu);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txbMaPhong);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txbTenPhong);
            this.panel2.Controls.Add(this.cbTrangThai);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.FormattingEnabled = true;
            resources.ApplyResources(this.cbLoaiPhong, "cbLoaiPhong");
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            // 
            // txbGhiChu
            // 
            resources.ApplyResources(this.txbGhiChu, "txbGhiChu");
            this.txbGhiChu.Name = "txbGhiChu";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // txbMaPhong
            // 
            resources.ApplyResources(this.txbMaPhong, "txbMaPhong");
            this.txbMaPhong.Name = "txbMaPhong";
            this.txbMaPhong.ReadOnly = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // txbTenPhong
            // 
            resources.ApplyResources(this.txbTenPhong, "txbTenPhong");
            this.txbTenPhong.Name = "txbTenPhong";
            // 
            // cbTrangThai
            // 
            resources.ApplyResources(this.cbTrangThai, "cbTrangThai");
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            resources.GetString("cbTrangThai.Items"),
            resources.GetString("cbTrangThai.Items1")});
            this.cbTrangThai.Name = "cbTrangThai";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.cbTimLoaiPhong);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txbTimTenPhong);
            this.panel1.Controls.Add(this.label2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbTimLoaiPhong
            // 
            this.cbTimLoaiPhong.FormattingEnabled = true;
            resources.ApplyResources(this.cbTimLoaiPhong, "cbTimLoaiPhong");
            this.cbTimLoaiPhong.Name = "cbTimLoaiPhong";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btnTimKiem, "btnTimKiem");
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // txbTimTenPhong
            // 
            resources.ApplyResources(this.txbTimTenPhong, "txbTimTenPhong");
            this.txbTimTenPhong.Name = "txbTimTenPhong";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // RoomManagement
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "RoomManagement";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhong)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvDanhSachPhong;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnCapNhatPhong;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.TextBox txbGhiChu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbMaPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbTenPhong;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbTimLoaiPhong;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbTimTenPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
    }
}