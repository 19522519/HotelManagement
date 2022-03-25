
namespace Hotel_Management
{
    partial class fReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fReport));
            this.btnDong = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chartReport = new LiveCharts.WinForms.PieChart();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXemKetQua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericNam = new System.Windows.Forms.NumericUpDown();
            this.cmbThang = new System.Windows.Forms.ComboBox();
            this.lbTittle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNam)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(881, 521);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(140, 25);
            this.btnDong.TabIndex = 18;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(415, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "BÁO CÁO DOANH THU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Chức năng";
            // 
            // chartReport
            // 
            this.chartReport.Location = new System.Drawing.Point(22, 183);
            this.chartReport.Name = "chartReport";
            this.chartReport.Size = new System.Drawing.Size(415, 290);
            this.chartReport.TabIndex = 15;
            this.chartReport.Text = "Báo cáo doanh thu";
            // 
            // dgvReport
            // 
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.Location = new System.Drawing.Point(459, 147);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(581, 360);
            this.dgvReport.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tỉ lệ doanh thu theo phòng";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnXemKetQua);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericNam);
            this.panel1.Controls.Add(this.cmbThang);
            this.panel1.Location = new System.Drawing.Point(22, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 63);
            this.panel1.TabIndex = 12;
            // 
            // btnXemKetQua
            // 
            this.btnXemKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemKetQua.Location = new System.Drawing.Point(659, 20);
            this.btnXemKetQua.Name = "btnXemKetQua";
            this.btnXemKetQua.Size = new System.Drawing.Size(140, 25);
            this.btnXemKetQua.TabIndex = 6;
            this.btnXemKetQua.Text = "Xem kết quả";
            this.btnXemKetQua.UseVisualStyleBackColor = true;
            this.btnXemKetQua.Click += new System.EventHandler(this.btnXemKetQua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Năm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tháng:";
            // 
            // numericNam
            // 
            this.numericNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericNam.Location = new System.Drawing.Point(474, 20);
            this.numericNam.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericNam.Minimum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numericNam.Name = "numericNam";
            this.numericNam.Size = new System.Drawing.Size(140, 21);
            this.numericNam.TabIndex = 3;
            this.numericNam.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // cmbThang
            // 
            this.cmbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbThang.Location = new System.Drawing.Point(249, 19);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(139, 23);
            this.cmbThang.TabIndex = 2;
            // 
            // lbTittle
            // 
            this.lbTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.Location = new System.Drawing.Point(22, 487);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(415, 20);
            this.lbTittle.TabIndex = 19;
            this.lbTittle.Text = "BÁO CÁO DOANH THU";
            this.lbTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 561);
            this.Controls.Add(this.lbTittle);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartReport);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fReport";
            this.Text = "Thống kê doanh thu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private LiveCharts.WinForms.PieChart chartReport;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXemKetQua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericNam;
        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.Label lbTittle;
    }
}
