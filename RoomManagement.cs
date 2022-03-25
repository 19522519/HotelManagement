using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_Management.Controller;
using Microsoft.Office.Interop.Excel;

namespace Hotel_Management
{
    public partial class RoomManagement : Form
    {

        RoomController roomController = new RoomController();

        public RoomManagement()
        {
            InitializeComponent();
            LoadData();
            LoadTenPhong();
            LoadTenPhongTimKiem();
            
        }

        void LoadTenPhongTimKiem()
        {
            cbTimLoaiPhong.DataSource = roomController.All();
            cbTimLoaiPhong.DisplayMember = "TENLOAIPHONG";
            cbTimLoaiPhong.ValueMember = "MALOAIPHONG";
        }

        void LoadTenPhong()
        {
            cbLoaiPhong.DataSource = roomController.All();
            cbLoaiPhong.DisplayMember = "TENLOAIPHONG";
            cbLoaiPhong.ValueMember = "MALOAIPHONG";
        }

        void LoadData()
        {
            dgvDanhSachPhong.DataSource = roomController.getAll();
            addBlinding();
        }
        void addBlinding()
        {
            txbMaPhong.DataBindings.Clear();
            txbMaPhong.DataBindings.Add("Text", dgvDanhSachPhong.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txbTenPhong.DataBindings.Clear();
            txbTenPhong.DataBindings.Add("Text", dgvDanhSachPhong.DataSource, "Name", true, DataSourceUpdateMode.Never);
            cbLoaiPhong.DataBindings.Clear();
            cbLoaiPhong.DataBindings.Add("Text", dgvDanhSachPhong.DataSource, "RoomType", true, DataSourceUpdateMode.Never);
            cbTrangThai.DataBindings.Clear();
            cbTrangThai.DataBindings.Add("Text", dgvDanhSachPhong.DataSource, "Status", true, DataSourceUpdateMode.Never);
            txbGhiChu.DataBindings.Clear();
            txbGhiChu.DataBindings.Add("Text", dgvDanhSachPhong.DataSource, "Note", true, DataSourceUpdateMode.Never);

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                roomController.DeleteRoom(Int32.Parse(txbMaPhong.Text));
                LoadData();
            }
        }
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            if (txbTenPhong.Text == "")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PHONG p = new PHONG()
            {
                TENPHONG = txbTenPhong.Text,
                MAPHONG = Int32.Parse(txbMaPhong.Text),
                MALOAIPHONG=(int)cbLoaiPhong.SelectedValue,
                TINHTRANG = cbTrangThai.Text,
                GHICHU = txbGhiChu.Text,
            };
            roomController.AddRoom(p);
            LoadData();
        } 
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string roomName = txbTimTenPhong.Text.Trim();
            string roomTypeName = cbTimLoaiPhong.Text.Trim();
            dgvDanhSachPhong.DataSource = roomController.findRoom(roomName, roomTypeName);
        }

        private void btnCapNhatPhong_Click(object sender, EventArgs e)
        {
            if (txbTenPhong.Text == "")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PHONG p = new PHONG()
            {
                MAPHONG=Int32.Parse(txbMaPhong.Text),
                TENPHONG = txbTenPhong.Text,
                MALOAIPHONG = (int)cbLoaiPhong.SelectedValue,
                TINHTRANG = cbTrangThai.Text,
                GHICHU = txbGhiChu.Text,
            };
            roomController.UpdateRoom(p);
            LoadData();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if(dgvDanhSachPhong.Rows.Count>0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for(int i=0;i<dgvDanhSachPhong.Columns.Count;i++)
                {
                    xcelApp.Cells[1, i+1] = dgvDanhSachPhong.Columns[i].HeaderText;
                }
                for (int i = 0;i<dgvDanhSachPhong.Rows.Count;i++)
                {
                    for(int j=0;j<dgvDanhSachPhong.Columns.Count;j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgvDanhSachPhong.Rows[i].Cells[j].Value.ToString();
                    }    

                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }    

        }

        private void dgvDanhSachPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dgvDanhSachPhong.Rows[e.RowIndex];
            txbMaPhong.Text = row.Cells[0].Value.ToString();
            txbTenPhong.Text = row.Cells[1].Value.ToString();
            cbLoaiPhong.Text= row.Cells[2].Value.ToString();
            cbTrangThai.Text = row.Cells[4].Value.ToString();
            txbGhiChu.Text = row.Cells[5].Value.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
