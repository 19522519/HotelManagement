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
//using Hotel_Management.Controller;

namespace Hotel_Management
{ 
    public partial class fCustomerManagement : Form
    {

        CustomerController CustomerController = new CustomerController();
        CustomerTypeController CustomerTypeController = new CustomerTypeController();

        public fCustomerManagement()
        {
            InitializeComponent();
            LoadData();
            cmbLoai.DataSource = CustomerTypeController.getAll();
            cmbLoai.DisplayMember = "Name";
            cmbLoai.ValueMember = "ID";
        }

        void LoadData()
        {
            dgvData.DataSource = CustomerController.getAll();
            addBinding();
        }
        void addBinding()
        {
            txtMaKH.DataBindings.Clear();
            txtCMND.DataBindings.Clear();
            txtTenKH.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtQuocTich.DataBindings.Clear();
            cmbLoai.DataBindings.Clear();
            cmbGender.DataBindings.Clear();
            dtpBirthDay.DataBindings.Clear();

            txtMaKH.DataBindings.Add("Text", dgvData.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txtCMND.DataBindings.Add("Text", dgvData.DataSource, "CMND", true, DataSourceUpdateMode.Never);
            txtTenKH.DataBindings.Add("Text", dgvData.DataSource, "Name", true, DataSourceUpdateMode.Never);
            txtSDT.DataBindings.Add("Text", dgvData.DataSource, "Phone", true, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Add("Text", dgvData.DataSource, "Address", true, DataSourceUpdateMode.Never);
            txtQuocTich.DataBindings.Add("Text", dgvData.DataSource, "Nationality", true, DataSourceUpdateMode.Never);
            cmbLoai.DataBindings.Add("Text", dgvData.DataSource, "Type", true, DataSourceUpdateMode.Never);
            cmbGender.DataBindings.Add("Text", dgvData.DataSource, "Gender", true, DataSourceUpdateMode.Never);
            dtpBirthDay.DataBindings.Add("Value", dgvData.DataSource, "BirthDay", true, DataSourceUpdateMode.Never);
        }


        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            KHACHHANG kh = new KHACHHANG()
            {
                MAKHACHHANG = Convert.ToInt32(txtMaKH.Text),
                TENKHACHHANG = txtTenKH.Text,
                CMND = txtCMND.Text,
                DIACHI = txtDiaChi.Text,
                MALOAIKHACH = (int)cmbLoai.SelectedValue,
                QUOCTICH = txtQuocTich.Text,
                SODIENTHOAI = txtSDT.Text,
                GIOITINH = cmbGender.Text,
                NGAYSINH = dtpBirthDay.Value
            };

            CustomerController.updateCustomer(kh);
            LoadData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = CustomerController.findCustomer(txtTimTen.Text, txtTimCMND.Text);
            addBinding();
        }

        private void btnExport_Click(object sender, EventArgs e)
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
                for (int i = 1; i < dgvData.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgvData.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dgvData.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvData.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvData.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // save the application  
                workbook.SaveAs(dialog.InitialDirectory + dialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application  
                app.Quit();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KHACHHANG kh = new KHACHHANG()
            {
                TENKHACHHANG = txtTenKH.Text,
                CMND = txtCMND.Text,
                DIACHI = txtDiaChi.Text,
                MALOAIKHACH = (int)cmbLoai.SelectedValue,
                QUOCTICH = txtQuocTich.Text,
                SODIENTHOAI = txtSDT.Text,
                GIOITINH = cmbGender.Text,
                NGAYSINH = dtpBirthDay.Value
            };

            CustomerController.insertCustomer(kh);
            LoadData();
        }
    }
}
