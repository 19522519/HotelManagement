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
using System.Data.SqlClient;
namespace Hotel_Management
{
    public partial class ManageCustomerType : Form
    {
        CustomerTypeController controller = new CustomerTypeController();

        public ManageCustomerType()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvData.DataSource = controller.getAll();

            txtMaLoaiKhach.DataBindings.Clear();
            txtMaLoaiKhach.DataBindings.Add("Text", dgvData.DataSource, "ID", false, DataSourceUpdateMode.Never);

            txtTenLoaiKhach.DataBindings.Clear();
            txtTenLoaiKhach.DataBindings.Add("Text", dgvData.DataSource, "Name", false, DataSourceUpdateMode.Never);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiKhach.Text == "")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LOAIKHACH loaiKhach = new LOAIKHACH()
            {
                TENLOAIKHACH = txtTenLoaiKhach.Text
            };

            controller.insertCustomerType(loaiKhach);
            LoadData();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                controller.deleteCustomer(Int32.Parse(txtMaLoaiKhach.Text));
                LoadData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiKhach.Text == "")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LOAIKHACH loaiKhach = new LOAIKHACH()
            {
                MALOAIKHACH = Convert.ToInt32(txtMaLoaiKhach.Text),
                TENLOAIKHACH = txtTenLoaiKhach.Text
            };

            controller.updateCustomerType(loaiKhach);
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
