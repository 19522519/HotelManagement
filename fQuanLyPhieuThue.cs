using Hotel_Management.Controller;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class fQuanLyPhieuThue : Form
    {
        RentalController rentalController = new RentalController();
        RoomController roomController = new RoomController();
        CustomerController customerController = new CustomerController();
        BillController billController = new BillController();
        ParameterController parameterController = new ParameterController();

        DateTime dateStart = new DateTime();
        bool isPaid = true;

        public fQuanLyPhieuThue()
        {
            InitializeComponent();
            LoadData();
            LoadTenPhong();

            if (dgvDanhSachPhieuThue.Rows.Count <= 0)
                return;
            dtpkNgayBatDauThue.Value = (DateTime) dgvDanhSachPhieuThue.Rows[0].Cells["DayStart"].Value;
            dateStart = dtpkNgayBatDauThue.Value;
            if (dgvDanhSachPhieuThue.Rows[0].Cells["NOTE"].Value.ToString() == "Đã thanh toán")
                isPaid = true;
            else isPaid = false;
        }

        void LoadTenPhong()
        {
            cmbTenPhong.DataSource = roomController.getAll();
            cmbTenPhong.DisplayMember = "Name";
            cmbTenPhong.ValueMember = "ID";
        }
        void LoadData()
        {
            dgvDanhSachPhieuThue.DataSource = rentalController.getAll();
            addBinding();
        }

        void addBinding()
        {
            txtMaPhieuThue.DataBindings.Clear();
            txtTenKhachHang.DataBindings.Clear();
            txtCMND.DataBindings.Clear();

            txtDiaChi.DataBindings.Clear();
            txtMaKhachHang.DataBindings.Clear();


            txtMaPhieuThue.DataBindings.Add("Text", dgvDanhSachPhieuThue.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txtTenKhachHang.DataBindings.Add("Text", dgvDanhSachPhieuThue.DataSource, "CustomerName", true, DataSourceUpdateMode.Never);
            txtCMND.DataBindings.Add("Text", dgvDanhSachPhieuThue.DataSource, "CMND", true, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Add("Text", dgvDanhSachPhieuThue.DataSource, "Address", true, DataSourceUpdateMode.Never);

            txtMaKhachHang.DataBindings.Add("Text", dgvDanhSachPhieuThue.DataSource, "CustomerID", true, DataSourceUpdateMode.Never);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (isPaid)
            {
                MessageBox.Show("Không thể xóa hóa đơn đã thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                rentalController.deleteRental(Int32.Parse(txtMaPhieuThue.Text));
                LoadData();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (isPaid)
            {
                MessageBox.Show("Không thể cập nhật hóa đơn đã thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!checkEmpty())
            {
                MessageBox.Show("Vui lòng điền đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PHIEUTHUE pt = new PHIEUTHUE()
            {
                MAPHONG = (int) cmbTenPhong.SelectedValue,
                MAPHIEUTHUE = Int32.Parse(txtMaPhieuThue.Text),
                NGAYBDTHUE = dtpkNgayBatDauThue.Value
            };

            CHITIETPHIEUTHUE ct = new CHITIETPHIEUTHUE()
            {
                MAKHACHHANG = Convert.ToInt32(txtMaKhachHang.Text)
            };

            KHACHHANG kh = customerController.findKhachHangByID(Convert.ToInt32(txtMaKhachHang.Text));
            kh.TENKHACHHANG = txtTenKhachHang.Text;
            kh.CMND = txtCMND.Text;
            kh.DIACHI = txtDiaChi.Text;
            rentalController.updateRental(pt, ct);
            customerController.updateCustomer(kh);

            LoadData();
        }

        private bool checkEmpty()
        {
            foreach (Control item in panelRental.Controls)
            {
                if (item is TextBox && item.Text == "")
                {
                    return false;
                }
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (fMainMenu.bookRoom == null || fMainMenu.bookRoom.IsDisposed)
                fMainMenu.bookRoom = new fBookRoom();
            fMainMenu.bookRoom.Show();
        }

        private void dgvDanhSachPhieuThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 1)
            {
                return;
            }
            string RoomName = (string)dgvDanhSachPhieuThue.Rows[row].Cells["RoomName"].Value;
            dateStart = (DateTime) dgvDanhSachPhieuThue.Rows[row].Cells["DayStart"].Value;
            string pay = (string) dgvDanhSachPhieuThue.Rows[row].Cells["NOTE"].Value;
            if ( pay == "Đã thanh toán")
                isPaid = true;
            else
                isPaid = false;

            dtpkNgayBatDauThue.Value = dateStart;
            cmbTenPhong.Text = RoomName;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int ID = -1;
            if (txtTimMaPhieuThue.Text != "")
            {
                ID = Convert.ToInt32(txtTimMaPhieuThue.Text);
            }
            dgvDanhSachPhieuThue.DataSource = rentalController
                .findRental(ID, txtTimTenKH.Text, txtTimTenPhong.Text);

            addBinding();
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnXuatFileExcel_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "*.xls|.xls";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Exported from gridview";
                // storing header part in Excel  
                for (int i = 1; i < dgvDanhSachPhieuThue.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgvDanhSachPhieuThue.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dgvDanhSachPhieuThue.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvDanhSachPhieuThue.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvDanhSachPhieuThue.Rows[i].Cells[j].Value.ToString();
                    }
                }
                
                // save the application  
                workbook.SaveAs(dialog.InitialDirectory + dialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application  
                app.Quit();
            }
            
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn xuất hóa đơn cho phiếu thuê này không ?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }
            //MessageBox.Show("" + TriGia);
            if (!isPaid)
            {
                TimeSpan timeSpan = DateTime.Now - dateStart;
                decimal unitPrice = getUnitPrice();
                int percent = (int)unitPrice;                
                int soNgay = timeSpan.Days + 1;
                dynamic room = cmbTenPhong.SelectedItem;
                int price = (int) room.Price;
                int temp = (int) (price * soNgay * (percent * 1.0) / 100);
                Decimal TriGia = temp;

                HOADON hoadon = new HOADON()
                {
                    MAKHACHHANG = Convert.ToInt32(txtMaKhachHang.Text),
                    NGAYTHANHTOAN = DateTime.Now,
                    TRIGIA = room.Price
                };

                CHITIETHOADON chitiet = new CHITIETHOADON()
                {
                    DONGIA = unitPrice,
                    MAPHONG = (int)cmbTenPhong.SelectedValue,
                    SONGAYTHUE = soNgay,
                    THANHTIEN = TriGia,
                    MAPHIEUTHUE = Convert.ToInt32(txtMaPhieuThue.Text)
                };

                billController.addBill(hoadon, chitiet);
                rentalController.setPaid(Convert.ToInt32(txtMaPhieuThue.Text));

                roomController.setRoomCheck((int)cmbTenPhong.SelectedValue);
            }

            //rentalController.deleteRental(Convert.ToInt32(txtMaPhieuThue.Text));
            InHoaDon inHoaDon = new InHoaDon(billController.getBillID(Convert.ToInt32(txtMaPhieuThue.Text)));
            inHoaDon.Show();
            LoadData();  
        }

        private decimal getUnitPrice()
        {
            decimal unitPrice = 100;
            int ID = Convert.ToInt32(txtMaPhieuThue.Text);
            if (rentalController.isForeign(ID))
                unitPrice += (parameterController.HESOKHNUOCNGOAI() - 1)*100;
            //MessageBox.Show(unitPrice + "");
            if (rentalController.getNumberPeople(ID) > 2)
                unitPrice += parameterController.PHUTHU();
            //MessageBox.Show(unitPrice + "");

            return unitPrice;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadData();
        }


    }
}
