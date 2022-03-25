using Hotel_Management.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class DangKi : Form
    {
        UserController controller = new UserController();
        Bitmap bitmap = new Bitmap(Properties.Resources.avatar);
        Bitmap avatar;
        int avatarIndex = 0;
        int HEIGHT, WIDTH;

        public DangKi()
        {
            InitializeComponent();
            HEIGHT = bitmap.Height / 3;
            WIDTH = bitmap.Width / 3;
            avatar = new Bitmap(WIDTH, HEIGHT);
            changeAvatar(0);

            LoadAcess();
        }

        void LoadAcess()
        {
            cmbQuyen.Items.Add("Quản lý");
            cmbQuyen.Items.Add("Nhân viên");
            cmbQuyen.SelectedIndex = 0;
        }

        private void buttonDangKi_Click(object sender, EventArgs e)
        {
            if (GetMD5(txtPassword.Text) == "21232F297A57A5A743894A0E4A801FC3")
            {
                MessageBox.Show("Login");
            }
            if (!checkEmpty())
            {
                MessageBox.Show("Vui lòng điền đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPassword.Text != txtRePasswork.Text)
            {
                MessageBox.Show("Mật khẩu không giống nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            NGUOIDUNG nguoiDung = new NGUOIDUNG() {
                ANHDAIDIEN = avatarIndex,
                MATKHAU = GetMD5(txtPassword.Text),
                QUYENTRUYCAP = cmbQuyen.Text,
                TENDANGNHAP = txtNameLogin.Text,
                TENNGUOIDUNG = txtName.Text
            };

            controller.addUser(nguoiDung);
            MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        bool checkEmpty()
        {
            foreach (Control item in panel.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == "")
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void picAvatar_Click(object sender, EventArgs e)
        {
            avatarIndex++;
            if (avatarIndex > 5)
                avatarIndex = 0;
            changeAvatar(avatarIndex);
        }
        
        void changeAvatar(int index)
        {
            int row = index / 3;
            int column = index % 3;

            for (int i = row * HEIGHT; i < (row + 1) * HEIGHT; i++)
            {
                for (int j = column * WIDTH; j < (column + 1) * WIDTH; j++)
                {
                    avatar.SetPixel(j - column * WIDTH, i - row * HEIGHT, bitmap.GetPixel(j, i));
                }
            }

            picAvatar.Image = avatar;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string GetMD5(string chuoi)
        {
            string str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(chuoi);

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            mang = my_md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("X2");
            }

            return str_md5;
        }
    }
}
