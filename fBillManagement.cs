using Hotel_Management.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class fBillManagement : Form
    {
        BillController billController = new BillController();
        int RentalID = 0;

        public fBillManagement()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            dgvBillManagement.DataSource = billController.getAll();
            addBinding();
        }

        void addBinding()
        {
            txtMaHoaDon.DataBindings.Clear();
            txtTriGia.DataBindings.Clear();
            dtpkNgayThanhToan.DataBindings.Clear();
            txtSoNgayThue.DataBindings.Clear();
            txtMaKhachHang.DataBindings.Clear();
            txtTenKhachHang.DataBindings.Clear();
            txtMaPhong.DataBindings.Clear();
            txtTenPhong.DataBindings.Clear();
            txtDonGia.DataBindings.Clear();
            txtThanhTien.DataBindings.Clear();

            txtMaHoaDon.DataBindings.Add("Text", dgvBillManagement.DataSource, "ID", true, DataSourceUpdateMode.Never);

            dtpkNgayThanhToan.DataBindings.Add("Text", dgvBillManagement.DataSource, "PaymentDay", true, DataSourceUpdateMode.Never);
            txtTriGia.DataBindings.Add("Text", dgvBillManagement.DataSource, "Value", true, DataSourceUpdateMode.Never);
            txtSoNgayThue.DataBindings.Add("Text", dgvBillManagement.DataSource, "RentalDays", true, DataSourceUpdateMode.Never);

            txtTenPhong.DataBindings.Add("Text", dgvBillManagement.DataSource, "RoomName", true, DataSourceUpdateMode.Never);
            txtMaPhong.DataBindings.Add("Text", dgvBillManagement.DataSource, "RoomID", true, DataSourceUpdateMode.Never);

            txtDonGia.DataBindings.Add("Text", dgvBillManagement.DataSource, "UnitPrice", true, DataSourceUpdateMode.Never);
            txtMaKhachHang.DataBindings.Add("Text", dgvBillManagement.DataSource, "CustomerID", true, DataSourceUpdateMode.Never);
            txtTenKhachHang.DataBindings.Add("Text", dgvBillManagement.DataSource, "CustomerName", true, DataSourceUpdateMode.Never);
            txtThanhTien.DataBindings.Add("Text", dgvBillManagement.DataSource, "Amount", true, DataSourceUpdateMode.Never);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            InHoaDon inHoaDon = new InHoaDon(billController.getBillID(RentalID));
            inHoaDon.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                billController.deleteBill(Int32.Parse(txtMaHoaDon.Text));
                LoadData();
            }
        }

        private void dgvBillManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //DataGridViewRow row = this.dgvBillManagement.Rows[e.RowIndex];
                //txtMaHoaDon.Text = row.Cells[0].Value.ToString();

                //dtpkNgayThanhToan.Value = (DateTime)row.Cells[1].Value;

                //txtTriGia.Text = row.Cells[2].Value.ToString();
                //txtSoNgayThue.Text = row.Cells[3].Value.ToString();

                //txtTenPhong.Text = row.Cells[4].Value.ToString();
                //txtMaPhong.Text = row.Cells[5].Value.ToString();

                //txtDonGia.Text = row.Cells[6].Value.ToString();

                //txtMaKhachHang.Text = row.Cells[7].Value.ToString();
                //txtTenKhachHang.Text = row.Cells[8].Value.ToString();
                RentalID = (int) dgvBillManagement.Rows[e.RowIndex].Cells["RentalID"].Value;
                //MessageBox.Show("here");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int ID = -1;
            if (txtTimMaHoaDon.Text != "")
            {
                ID = Convert.ToInt32(txtTimMaHoaDon.Text);
            }
            dgvBillManagement.DataSource = billController
                .findBill(ID, txtTimTenKhachHang.Text, txtTimTenPhong.Text, txtTimTenLoaiPhong.Text);

            addBinding();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            txtTimMaHoaDon.Text = "";
            txtTimTenKhachHang.Text = "";
            txtTimTenLoaiPhong.Text = "";
            txtTimTenPhong.Text = "";
            LoadData();
        }
    }
}