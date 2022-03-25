
namespace Hotel_Management
{
    partial class SignIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.labelLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.ckbShow = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelLogin.ForeColor = System.Drawing.Color.Teal;
            this.labelLogin.Location = new System.Drawing.Point(307, 14);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogin.MinimumSize = new System.Drawing.Size(15, 13);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(98, 32);
            this.labelLogin.TabIndex = 17;
            this.labelLogin.Text = "Đăng Nhập";
            this.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Hotel_Management.Properties.Resources.avatar_default;
            this.pictureBox1.Location = new System.Drawing.Point(32, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(239, 84);
            this.txbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(224, 20);
            this.txbUsername.TabIndex = 1;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(239, 136);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(175, 20);
            this.txbPassword.TabIndex = 2;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelPassword.ForeColor = System.Drawing.Color.Teal;
            this.labelPassword.Location = new System.Drawing.Point(239, 110);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(68, 19);
            this.labelPassword.TabIndex = 13;
            this.labelPassword.Text = "Mật khẩu";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelUsername.ForeColor = System.Drawing.Color.Teal;
            this.labelUsername.Location = new System.Drawing.Point(239, 55);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(102, 19);
            this.labelUsername.TabIndex = 12;
            this.labelUsername.Text = "Tên đăng nhập";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(239, 211);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(223, 30);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(239, 168);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(223, 30);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // ckbShow
            // 
            this.ckbShow.AutoSize = true;
            this.ckbShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbShow.Location = new System.Drawing.Point(418, 136);
            this.ckbShow.Margin = new System.Windows.Forms.Padding(2);
            this.ckbShow.Name = "ckbShow";
            this.ckbShow.Size = new System.Drawing.Size(57, 19);
            this.ckbShow.TabIndex = 20;
            this.ckbShow.Text = "Show";
            this.ckbShow.UseVisualStyleBackColor = true;
            this.ckbShow.CheckedChanged += new System.EventHandler(this.ckbShow_CheckedChanged);
            // 
            // SignIn
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(494, 256);
            this.Controls.Add(this.ckbShow);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox ckbShow;
    }
}

