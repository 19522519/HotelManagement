using Hotel_Management.Controller;
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
    public partial class fBookRoom : Form
    {
        RentalController RentalController = new RentalController();
        RoomController roomController = new RoomController();
        CustomerController customerController = new CustomerController();
        CustomerTypeController customerTypeController = new CustomerTypeController();
        ParameterController parameterController = new ParameterController();

        List<KHACHHANG> arrKhachHang;
        List<int> arrTypeCustomer;
        List<bool> isEmpty;

        int previousIndex = -1;

        public fBookRoom()
        {
            InitializeComponent();

            LoadRoom();
            LoadCustomerType();

            monthCalendar.MaxSelectionCount = 1;           

            arrKhachHang = new List<KHACHHANG>();
            arrTypeCustomer = new List<int>();
            isEmpty = new List<bool>();
            for (int i = 0; i < parameterController.SOKHTOIDA1PHONG(); i++)
            {
                arrKhachHang.Add(new KHACHHANG() { GIOITINH = ""});
                arrTypeCustomer.Add(0);
                isEmpty.Add(true);
            }

            MaxPeople();
        }
        
        void MaxPeople()
        {
            nudPeople.Maximum = parameterController.SOKHTOIDA1PHONG();
            nudPeople.Minimum = 1;
            nudPeople.Value = 1;

            cmbGender.SelectedIndex = 0;
        }

        void LoadCustomerType()
        {
            cmbCustomerType.DataSource = customerTypeController.getAll();
            cmbCustomerType.DisplayMember = "Name";
            cmbCustomerType.ValueMember = "ID";
        }
        void LoadRoom()
        {
            cmbRoom.DataSource = roomController.getAvaiableRoom();
            cmbRoom.DisplayMember = "Name";
            cmbRoom.ValueMember = "ID";

            
        }

        bool checkAllEmpty()
        {
            for (int i = 0; i < nudPeople.Value; i++)
            {
                if (isEmpty[i])
                {
                    return false;
                }
            }

            return true;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            saveTempCustomer();

            if (!checkAllEmpty())
            {
                MessageBox.Show("Vui lòng điền đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Xác nhận đặt phòng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                PHIEUTHUE pt = new PHIEUTHUE()
                {
                    MAPHONG = (int)cmbRoom.SelectedValue,
                    NGAYBDTHUE = dtpDayRecieve.Value,
                    GHICHU = "Chưa thanh toán"
                };

                int MaPhieuThue = RentalController.addRental(pt);

                roomController.setRoomBooked((int)cmbRoom.SelectedValue);

                for (int i = 0; i < nudPeople.Value; i++)
                {
                    if (arrKhachHang[i].MAKHACHHANG == 0)
                    {
                        arrKhachHang[i].MAKHACHHANG = customerController.insertCustomer(arrKhachHang[i]);
                    }
                    CHITIETPHIEUTHUE ctpt = new CHITIETPHIEUTHUE()
                    {
                        MAKHACHHANG = arrKhachHang[i].MAKHACHHANG
                    };
                    RentalController.addRentalDetail(MaPhieuThue, ctpt);
                }
                MessageBox.Show("Đặt phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRoom();
                LoadCustomerType();
            }
        }

        private bool checkEmpty()
        {
            foreach (Control item in groupBoxCustomer.Controls)
            {
                if (item is TextBox && item.Name != "txtMaKhachHang" && item.Text == "")
                {
                    return false;
                }
            }

            return true;
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            dynamic a = cmbRoom.SelectedItem;
            txtRoomTpye.Text = a.RoomType;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dynamic value = customerController.findKhachHangByCMND(txtCMND.Text);
            if (value != null)
            {
                txtCMND.Text = value.CMND;
                txtMaKhachHang.Text = value.ID.ToString();
                txtName.Text = value.Name;
                txtNationality.Text = value.Nationality;
                txtSDT.Text = value.Phone;
                txtAddress.Text = value.Address;
                cmbCustomerType.Text = value.Type;
                cmbGender.Text = value.Gender;
                dtpBirthDay.Value = value.BirthDay;
            }
            else MessageBox.Show("Không tìm thấy, vui lòng kiểm tra lại thông tin",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            dtpDayRecieve.Value = monthCalendar.SelectionRange.Start;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaKhachHang.Text = "";
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void nudPeople_ValueChanged(object sender, EventArgs e)
        {
            cmbSTT.Items.Clear();
            for (int i = 0; i < nudPeople.Value; i++)
            {
                cmbSTT.Items.Add(i + 1);
            }

            cmbSTT.SelectedIndex = 0;
        }

        private void cmbSTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (arrKhachHang == null)
            //{
            //    createNewList();
            //}

            //MessageBox.Show(previousIndex + " " + cmbSTT.SelectedIndex);

            if (previousIndex != -1)
            {
                saveTempCustomer();
            }

            txtCMND.Text = arrKhachHang[cmbSTT.SelectedIndex].CMND;
            txtName.Text = arrKhachHang[cmbSTT.SelectedIndex].TENKHACHHANG;
            txtAddress.Text = arrKhachHang[cmbSTT.SelectedIndex].DIACHI;
            txtSDT.Text = arrKhachHang[cmbSTT.SelectedIndex].SODIENTHOAI;
            txtNationality.Text = arrKhachHang[cmbSTT.SelectedIndex].QUOCTICH;
            if (arrKhachHang[cmbSTT.SelectedIndex].NGAYSINH != null)
            {
                dtpBirthDay.Value = (DateTime)arrKhachHang[cmbSTT.SelectedIndex].NGAYSINH;
            }
            if (arrKhachHang[cmbSTT.SelectedIndex].GIOITINH != "")
                cmbGender.Text = arrKhachHang[cmbSTT.SelectedIndex].GIOITINH;
            else cmbGender.SelectedIndex = 0;
            if (arrKhachHang[cmbSTT.SelectedIndex].MAKHACHHANG != 0)
            {
                txtMaKhachHang.Text = arrKhachHang[cmbSTT.SelectedIndex].MAKHACHHANG.ToString();
            }
            else txtMaKhachHang.Text = "";
            cmbCustomerType.SelectedIndex = arrTypeCustomer[cmbSTT.SelectedIndex];

            previousIndex = cmbSTT.SelectedIndex;
            //MessageBox.Show("PreviousIndex = " + previousIndex);
            //txtMaKhachHang.Text = arrKhachHang[cmbSTT.SelectedIndex].MAKHACHHANG.ToString();
            //
        }

        void saveTempCustomer()
        {
            arrKhachHang[previousIndex].CMND = txtCMND.Text;
            arrKhachHang[previousIndex].TENKHACHHANG = txtName.Text;
            arrKhachHang[previousIndex].DIACHI = txtAddress.Text;
            arrKhachHang[previousIndex].SODIENTHOAI = txtSDT.Text;
            arrKhachHang[previousIndex].QUOCTICH = txtNationality.Text;
            arrKhachHang[previousIndex].MALOAIKHACH = (int)cmbCustomerType.SelectedValue;
            arrKhachHang[previousIndex].NGAYSINH = dtpBirthDay.Value;
            arrKhachHang[previousIndex].GIOITINH = cmbGender.Text;
            if (txtMaKhachHang.Text != "")
            {
                arrKhachHang[previousIndex].MAKHACHHANG = Convert.ToInt32(txtMaKhachHang.Text);
            }
            arrTypeCustomer[previousIndex] = cmbCustomerType.SelectedIndex;

            isEmpty[previousIndex] = !checkEmpty();
        }

        private void TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbSTT.SelectedIndex + "");
            //return;
            //if (cmbSTT.SelectedIndex == -1)
            //{
            //    return;
            //}
            //arrKhachHang[cmbSTT.SelectedIndex].CMND = txtCMND.Text;
            //arrKhachHang[cmbSTT.SelectedIndex].TENKHACHHANG = txtName.Text;
            //arrKhachHang[cmbSTT.SelectedIndex].DIACHI = txtAddress.Text;
            //arrKhachHang[cmbSTT.SelectedIndex].SODIENTHOAI = txtSDT.Text;
            //arrKhachHang[cmbSTT.SelectedIndex].QUOCTICH = txtNationality.Text;
            //arrKhachHang[cmbSTT.SelectedIndex].MAKHACHHANG = Convert.ToInt32(txtMaKhachHang.Text);
            //arrKhachHang[cmbSTT.SelectedIndex].MALOAIKHACH = (int) cmbCustomerType.SelectedValue;
        }

        
    }
}
