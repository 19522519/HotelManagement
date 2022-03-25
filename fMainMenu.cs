using Hotel_Management.Controller;
using Microsoft.Reporting.WebForms;
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
    public partial class fMainMenu : Form
    {
        fBillManagement billManagement;
        public static fBookRoom bookRoom;
        fCustomerManagement customerManagement;
        fManageStaff manageStaff;
        fQuanLyPhieuThue quanLyPhieuThue;
        fParameterUpdate parameterUpdate;
        fReport report;
        ManageCustomerType manageCustomerType;
        ManageRoomType manageRoomType;
        PersionalInformation persionalInformation;
        RoomManagement roomManagement;

        UserController userController = new UserController();
        int UserID;
        bool isManager = false;


        public fMainMenu(int ID)
        {
            InitializeComponent();
            UserID = ID;
            NGUOIDUNG nguoiDung = userController.getUserByID(UserID);
            if (nguoiDung.QUYENTRUYCAP == "Quản lý")
                isManager = true;
            setAvatar(nguoiDung.ANHDAIDIEN);
            lbName.Text = nguoiDung.TENNGUOIDUNG;
        }

        private void gotoPersonnalInformation(object sender, EventArgs e)
        {
            if (persionalInformation == null || persionalInformation.IsDisposed)
            {
                persionalInformation = new PersionalInformation(UserID); //
            }
            persionalInformation.Show();
        }

        private void exit(object sender, EventArgs e)
        {
            Close();
        }

        private void gotoBookRoom(object sender, EventArgs e)
        {
            if (bookRoom == null || bookRoom.IsDisposed)
            {
                bookRoom = new fBookRoom();
            }
            bookRoom.Show();
        }

        private void gotoRoomManage(object sender, EventArgs e)
        {
            if (roomManagement == null || roomManagement.IsDisposed)
            {
                roomManagement = new RoomManagement();
            }
            roomManagement.Show();
        }

        private void gotoRentalManage(object sender, EventArgs e)
        {
            if (quanLyPhieuThue == null || quanLyPhieuThue.IsDisposed)
            {
                quanLyPhieuThue = new fQuanLyPhieuThue();
            }
            quanLyPhieuThue.Show();
        }

        private void gotoCustomerManage(object sender, EventArgs e)
        {
            if (customerManagement == null || customerManagement.IsDisposed)
            {
                customerManagement = new fCustomerManagement();
            }
            customerManagement.Show();
        }

        private void gotoBillManage(object sender, EventArgs e)
        {
            if (billManagement == null || billManagement.IsDisposed)
            {
                billManagement = new fBillManagement();
            }
            billManagement.Show();
        }

        private void gotoReport(object sender, EventArgs e)
        {
            if (report == null || report.IsDisposed)
            {
                report = new fReport();
            }
            report.Show();
        }

        private void gotoCustomerType(object sender, EventArgs e)
        {
            if (manageCustomerType == null || manageCustomerType.IsDisposed)
            {
                manageCustomerType = new ManageCustomerType();
            }
            if (isManager)
                manageCustomerType.Show();
            else MessageBox.Show("Bạn không có quyền truy cập vào khu vực này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void gotoRoomtype(object sender, EventArgs e)
        {
            if (manageRoomType == null || manageRoomType.IsDisposed)
            {
                manageRoomType = new ManageRoomType();
            }
            
            if (isManager)
                manageRoomType.Show();
            else MessageBox.Show("Bạn không có quyền truy cập vào khu vực này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void gotoStaffManage(object sender, EventArgs e)
        {
            if (manageStaff == null || manageStaff.IsDisposed)
            {
                manageStaff = new fManageStaff();
            }
            
            if (isManager)
                manageStaff.Show();
            else MessageBox.Show("Bạn không có quyền truy cập vào khu vực này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void gotoParameterUpdate(object sender, EventArgs e)
        {
            if (parameterUpdate == null || parameterUpdate.IsDisposed)
            {
                parameterUpdate = new fParameterUpdate();
            }
            
            if (isManager)
                parameterUpdate.Show();
            else MessageBox.Show("Bạn không có quyền truy cập vào khu vực này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void fMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát ứng dung", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        void setAvatar(int index)
        {
            if (index > 5)
                return;

            Bitmap bitmap = new Bitmap(Properties.Resources.avatar);
            int HEIGHT = bitmap.Height / 3;
            int WIDTH = bitmap.Width / 3;

            int row = index / 3;
            int column = index % 3;
            Bitmap avatar = new Bitmap(WIDTH, HEIGHT);

            for (int i = row * HEIGHT; i < (row + 1) * HEIGHT; i++)
            {
                for (int j = column * WIDTH; j < (column + 1) * WIDTH; j++)
                {
                    avatar.SetPixel(j - column * WIDTH, i - row * HEIGHT, bitmap.GetPixel(j, i));
                }
            }

            imgAvatar.Image = avatar;
        }

    }
}
